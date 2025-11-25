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
               
                if (UserList.Any(u => u.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("A user with that name already exists.");
                    return false;
                }

               
                int maxId = 0;
                foreach (User user in UserList)
                {
                    if (user.UserID > maxId)
                        maxId = user.UserID;
                }

                int newId = maxId + 1;

               
                IUser theUser = UserFactory.GetUser(name, password, userType, newId);
                DataLayer.addNewUserToDB(theUser);
                UserList.Add(theUser);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool deleteUser(IUser user)
        {

            DataLayer.deleteUserFromDB(user);
            UserList.Remove(user); 
           return true;

        }
        public bool editUser(IUser user)
        {
           
            bool ok = DataLayer.editUserInDB(user);
            if (!ok) return false;

            
            var existing = UserList.FirstOrDefault(u => u.UserID == user.UserID);
            if (existing != null)
            {
                existing.Name = user.Name;
                existing.Password = user.Password;
                existing.UserType = user.UserType;
            }

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

        public List<LibraryRoom> LibraryRoomList { get; set; } = new List<LibraryRoom>();

        public void populateLibraryRooms()
        {
            LibraryRoomList = DataLayer.getAllLibraryRooms();
        }
        public void populateLibraryRooms(DateTime date, DateTime startTime, DateTime endTime)
        {
            LibraryRoomList = DataLayer.getLibraryRoomsAvailable(date, startTime, endTime);
        }

        //Count for "Total bookings" - TM
        public int CountTotalBookings(int? userId)
        {
            return DataLayer.CountTotalBookings(userId);
        }

        //Count for "Active bookings" - FG & TM
        public int CountActiveBookings(int? userId)
        {
            return DataLayer.CountActiveBookings(userId);
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

        public List<LibraryRoomBooking> GetTop3UpcomingBookings(int userId)
        {
            try
            {
                return dataLayer.GetTop3UpcomingBookings(userId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving upcoming bookings: " + ex.Message);
            }
        }

        public bool UpdateBookingCheckInStatus(int bookingId, bool isCheckedIn)
        {
            try
            {
                return DataLayer.UpdateBookingCheckInStatus(bookingId, isCheckedIn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating check-in status: " + ex.Message);
                return false;
            }
        }

        public int GetAvailableRoomsCount(int userId)
        {
            try
            {
                string userType = CurrentUser.UserType;
                return dataLayer.GetAvailableRoomsCountRightNow(userType);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public bool UpdateLibraryRoom(LibraryRoom room)
        {
            try
            {
                return DataLayer.UpdateLibraryRoom(room);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in Model.UpdateLibraryRoom: {ex.Message}");
                return false;
            }
        }

        public bool DeleteLibraryRoom(int roomId)
        {
            try
            {
                return DataLayer.DeleteLibraryRoom(roomId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in Model.DeleteLibraryRoom: {ex.Message}");
                return false;
            }
        }






        //Count for "Cancelled bookings" - TM
        public int CountCancelledBookingsForUser(int userId)
        {
            return DataLayer.CountCancelledBookingsForUser(userId);
        }

        //Count for "Completed bookings" - TM
        public int CountCompletedBookingsForUser(int userId)
        {
            return DataLayer.CountCompletedBookingsForUser(userId);
        }

        // Book Library Room (Student) -TM
        public bool AddNewLibraryBooking(LibraryRoomBooking booking)
        {
            DateTime now = DateTime.Now;
            // Booking must be in the future
            if (booking.date.Date < now.Date || (booking.date.Date == now.Date && booking.startTime.TimeOfDay < now.TimeOfDay))
            {
                MessageBox.Show("Can't make a booking for the past!", "Rules", MessageBoxButtons.OK);
                return false;
            }
            // Booking must be on a week day
            if (booking.date.DayOfWeek == DayOfWeek.Saturday || booking.date.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Can't make a booking for the weekend!", "Rules", MessageBoxButtons.OK);
                return false;
            }

            // Booking must be between class hours
            if (booking.startTime.TimeOfDay < Convert.ToDateTime("09:00:00").TimeOfDay || booking.endTime.TimeOfDay > Convert.ToDateTime("18:00:00").TimeOfDay)
            {
                MessageBox.Show("Can't make a booking for outside of class hours!", "Rules", MessageBoxButtons.OK);
                return false;
            }

            // Booking must be between 30 minutes to 2 hours long
            double duration = booking.endTime.TimeOfDay.TotalMinutes - booking.startTime.TimeOfDay.TotalMinutes;
            if (duration < 30 || duration > 120)
            {
                MessageBox.Show("Booking must be between 30 minutes and 2 hours long!", "Rules", MessageBoxButtons.OK);
                return false;
            }

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

        public List<LibraryRoomBooking> LibraryRoomBookingsList { get; set; } = new List<LibraryRoomBooking>();
        public List<LibraryRoomBooking> LibraryRoomBookingList { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        // View Your Library Room Bookings (Student) -TM
        public void populateLibraryRoomBookings(IUser student)
        {
            LibraryRoomBookingsList = DataLayer.getAllStudentLibraryBookings(student);
        }

        public void populateAllCurrentLibraryBookings()
        {
            populateLibraryBookings();
        }

        public void populateLibraryBookings()
        {
            LibraryRoomBookingsList = new List<LibraryRoomBooking>();

            foreach (IUser user in userList)
            {
                List<LibraryRoomBooking> bookingsForUser = DataLayer.getAllStudentLibraryBookings(user);
                if (bookingsForUser != null)
                    LibraryRoomBookingsList.AddRange(bookingsForUser);
            }
        }
        public bool UpdateLibraryRoomBooking(LibraryRoomBooking booking)
        {
            DateTime now = DateTime.Now;

           
            if (booking.date.Date < now.Date ||
               (booking.date.Date == now.Date && booking.startTime.TimeOfDay < now.TimeOfDay))
            {
                MessageBox.Show("Can't move a booking into the past!", "Rules",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

           
            if (booking.date.DayOfWeek == DayOfWeek.Saturday ||
                booking.date.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Can't make a booking for the weekend!", "Rules",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (booking.startTime.TimeOfDay < TimeSpan.FromHours(9) ||
                booking.endTime.TimeOfDay > TimeSpan.FromHours(18))
            {
                MessageBox.Show("Booking must be between 09:00 and 18:00!", "Rules",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            double duration = (booking.endTime - booking.startTime).TotalMinutes;
            if (duration < 30 || duration > 120)
            {
                MessageBox.Show("Booking must be between 30 minutes and 2 hours!", "Rules",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

        
            return DataLayer.UpdateLibraryRoomBooking(booking);
        }


        public bool CancelLibraryBooking(int bookingId)
        {
            return DataLayer.CancelLibraryBooking(bookingId);
        }

        public int AutoCancelNoShowBookings()
        {
            return DataLayer.AutoCancelNoShowBookings();
        }

        public bool AddLibraryRoom(string roomNumber, int capacity, string resources, int statusId, string statusName, string roomType)
        {
            try
            {
                if (roomNumber.Length == 0)
                    throw new Exception();

                int maxId = 0;
                foreach (LibraryRoom room in LibraryRoomList)
                {
                    if (room.roomID > maxId)
                        maxId = room.roomID;
                }

                LibraryRoom newLibraryRoom = LibraryRoomFactory.GetLibraryRoom(maxId + 1, roomNumber, capacity, resources, statusId, statusName, roomType);
                LibraryRoomList.Add(newLibraryRoom);
                DataLayer.addNewLibraryRoomToDB(newLibraryRoom);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
