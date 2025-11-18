using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataAccessLayer;
using BusinessEntities;
using System.Xml.Linq;

namespace BusinessLayer
{
    public class Model : IModel
    {
        #region Static Attributes
        private static IModel modelSingletonInstance;  // Model object is a singleton so only one instance allowed
        static readonly object padlock = new object(); // Need this for thread safety on the Model singleton creation. ie in GetInstance () method
        #endregion
        #region Instance Attribures
        private IDataLayer dataLayer;  
        private IUser currentUser;
        private List<IUser> userList;
        private List<IProductLine> productLineList=new List<IProductLine>();   
        private List<IOrder> orderList;

        public List<IOrder> OrderList
        {
            get { return orderList; }
            set { orderList = value; }
        }

        public List<IProductLine> ProductLineList
        {
            get { return productLineList; }
            set { productLineList = value; }
        }
        #endregion
        #region Instance Properties
        public IDataLayer DataLayer
        {
            get { return dataLayer; }
            set { dataLayer = value; }
        }
        public IUser CurrentUser
        {
            get
            {
                return currentUser;
            }
            set
            {
                currentUser = value;
            }
        }


        public List<IUser> UserList
        {
            get
            {
                return userList;
            }
            //set
            //{
            //}
        }
        #endregion

        #region Constructors/Destructors
        public static IModel GetInstance(IDataLayer _DataLayer) // With Singleton pattern this method is used rather than constructor
        {
            lock (padlock) 
            {
                if (modelSingletonInstance == null)
                {
                    modelSingletonInstance = new Model( _DataLayer);
                }
                return modelSingletonInstance;
            }
        }
        private Model(IDataLayer _DataLayer)  
        {
            userList = new List<IUser>();
            dataLayer = _DataLayer;
            userList = dataLayer.getAllUsers(); 
        }

        ~Model()
        {
            tearDown();
        }
        #endregion
        public Boolean login(String name, String password)
        {
            
            //foreach (User user in userList) // now using template so can simplify this code as shown below
            //{
            //    if (name == user.Name && password == user.Password)
            //    {
                  
            //        CurrentUser=user;
            //        return true;
            //    }
            //}
            //return false;

            IUser matchUser = userList.FirstOrDefault(user => user.Name == name && user.Password == password);
            if (matchUser == null)
            {
                return false;
            }
            else
            {
                CurrentUser = matchUser;
                return true;
            }
        }
        public Boolean addNewUser(string name, string password, string userType)
        {
            try
            {
                int maxId = 0;
                // need some code to avoid dulicate usernames
                // maybe add some logic (busiess rules) about password policy
          //      IUser user = new User(name, password, userType); // Construct a User Object
                foreach (User user in UserList)
                {
                    if (user.UserID > maxId)
                        maxId = user.UserID;
                }
                IUser theUser = UserFactory.GetUser(name, password, userType,maxId+1);   // Using a Factory to create the user entity object. ie seperating object creation from business logic
                UserList.Add(theUser);                             // Add a reference to the newly created object to the Models UserList
                DataLayer.addNewUserToDB(theUser); //Gets the DataLayer to add the new user to the DB. 
                return true;
            }
                catch (System.Exception excep)
            {
                return false;
            }   
    }

        public bool deleteUser(IUser user)
        {

            DataLayer.deleteUserFromDB(user);
            UserList.Remove(user); //remove object from collection
           return true;

        }
        public bool editUser(IUser user)
        {
            DataLayer.editUserInDB(user);
            return true;
        }

        public String getUserTypeForCurrentuser()
        {
            if (currentUser == null)
                return "Unknown";

            return currentUser.UserType;
        }

        public void populateOrders()
        {
            OrderList = dataLayer.getAllOrders(); // setup Models orderList 
            // an order can have one or many productLines so need to setup ProductLineList in each order object.
              foreach (Order order in OrderList)
              {
                  order.ProductLineList = DataLayer.getProductLinesForOrder(order.OrderCode); // pass the order code to get back the product lines for the order ie the produc lines that were ordered on that order.
                                                                                     // Each order object has its own ArrayList of reference to ProductLineObjects ie the ProductLines for that specific order.
                                                                                     // Now the small list of ProductLines is sorted for this order so keep looping until the small ProductLineList is set for all orders. 
                  foreach (ProductLine productLine in order.ProductLineList)         // There is also an ArrayList for each entity class in the model, these are the big lists. This is an ArrayList of references to all ProductLines (for all orders)
                  {
                      this.ProductLineList.Add(productLine); // This adds the reference to the ProductLine to the Models ProductLineList ie big list. 
                  }
              }

        }
 
        public void tearDown()
        {
            DataLayer.closeConnection();
        }

        public bool updateProductLine(IProductLine productLine)
        {
            DataLayer.editProductLineInDB(productLine);
            return true;
        }


       // Available Rooms (Student) -FG

        public List<ILibraryRoom> LibraryRoomList { get; set; } = new List<ILibraryRoom>();

        public void populateLibraryRooms()
        {
            LibraryRoomList = DataLayer.getAllLibraryRooms();
        }
        public void populateLibraryRooms(DateTime date, DateTime startTime, DateTime endTime)
        {
            LibraryRoomList = DataLayer.getLibraryRoomsAvailable(date, startTime, endTime);
        }

        //Count for "Active bookings" - FG
        public int CountActiveBookingsForUser(int userId)
        {
            return DataLayer.CountActiveBookingsForUser(userId);
        }


        //Count for "Hours Booked" - FG
        public int GetHoursBookedThisMonth(int userId)
        {
            return DataLayer.GetHoursBookedThisMonth(userId);
        }

        //Count for "No of Upcoming bookings" - FG
        public int GetUpcomingBookingsCount(int userId)
        {
            return DataLayer.GetUpcomingBookingsCount(userId);
        }



        // Book Library Room (Student) -TM

        public bool AddNewLibraryBooking(LibraryRoomBooking booking)
        {
            try
            {
                DataLayer.addNewBookingToDB(booking);
                return true;
            }
            catch (Exception _)
            {
                return false;
            }
        }

        


    }
}
