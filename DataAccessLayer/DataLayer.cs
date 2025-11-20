using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using BusinessEntities;
using System.Globalization;

namespace DataAccessLayer
{
    public class DataLayer : IDataLayer
    {
        #region Instance Attributes
        private SqlConnection con;   // DB Connection
        DataSet ds;                 //Declare the DataSet object
        SqlDataAdapter da;          //Declare the DataAdapter object
        int totUsers;
        SqlCommandBuilder cb;
        #endregion
        #region Static Attributes
        private static IDataLayer dataLayerSingletonInstance;  // DataLayer object is a singleton so only one instance allowed
        static readonly object padlock = new object(); // Need this for thread safety on the DataLayer singleton creation. ie in GetInstance () method
        #endregion
        #region Constructors
        public static IDataLayer GetInstance() // With Singleton pattern this method is used rather than constructor
        {
            lock (padlock) //   only one thread can entry this block of code
            {
                if (dataLayerSingletonInstance == null)
                {
                    dataLayerSingletonInstance = new DataLayer();
                }
                return dataLayerSingletonInstance;
            }
        }
        private DataLayer()  // The constructor is private as its a singleton and I only allow one instance which is created with the GetInstance() method
        {
            openConnection();
        }
        #endregion
        public void openConnection()
        {
            con = new SqlConnection();
            con.ConnectionString = "Server=tcp:producttrackerserver.database.windows.net,1433;Initial Catalog=ProductTracker;Persist Security Info=False;User ID=adminUser;Password=P@ssword123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            try
            {
                con.Open();
                //MessageBox.Show("Database Open");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                Environment.Exit(0); //Force the application to close
            }
        }

        public void closeConnection()
        {
            con.Close();
        }

        public SqlConnection getConnection()
        {
            return con;
        }

        public List<IUser> getAllUsers()
        {
          List<IUser> UserList = new List<IUser>();
            try
            {

                ds = new DataSet();
                string sql = "SELECT * From Users";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "UsersData");
                totUsers = ds.Tables["UsersData"].Rows.Count;
                for (int i = 0; i < totUsers; i++)
                {
                    DataRow dRow = ds.Tables["UsersData"].Rows[i];
                    IUser user = UserFactory.GetUser(dRow.ItemArray.GetValue(0).ToString(),  // Using a Factory to create the user entity object. ie seperating object creation from business logic
                                                        dRow.ItemArray.GetValue(1).ToString(),
                                                        dRow.ItemArray.GetValue(2).ToString(),
                                                       Convert.ToInt16((dRow.ItemArray.GetValue(3))));

                    UserList.Add(user);
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return UserList;
        }
        public void addNewUserToDB(IUser theUser)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From Users";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "UsersData");
                totUsers = ds.Tables["UsersData"].Rows.Count;
                DataRow dRow = ds.Tables["UsersData"].NewRow();
                dRow[0] = theUser.Name;
                dRow[1] = theUser.Password;
                dRow[2] = theUser.UserType;
                dRow[3] = theUser.UserID;

                ds.Tables["UsersData"].Rows.Add(dRow);
                da.Update(ds, "UsersData");
            }
            catch (System.Exception excep)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
        }
        public bool deleteUserFromDB(BusinessEntities.IUser user)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Users";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "UsersData");
                DataRow findRow = ds.Tables["UsersData"].Rows.Find(user.UserID);
                if (findRow != null)
                {
                    findRow.Delete(); //mark row as deleted
                }
                da.Update(ds, "UsersData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }


        public bool editUserInDB(IUser user)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Users";
                da = new SqlDataAdapter(sql, con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "UsersData");
                DataRow findRow = ds.Tables["UsersData"].Rows.Find(user.UserID);
                if (findRow != null)
                {
                    findRow[0] = user.Name;
                    findRow[1] = user.Password;
                }
                da.Update(ds, "UsersData"); //remove row from database table
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().ToString() == "Open")
                    closeConnection();
                Application.Exit();
            }
            return true;
        }


        public List<IOrder> getAllOrders()
        {
            List<IOrder> OrderList = new List<IOrder>();
            List<IProductLine> ProductLineList = new List<IProductLine>(); 
            DataSet ds;                 //Declare the DataSet object
            SqlDataAdapter da;   //Declare the DataAdapter object
            SqlCommandBuilder cb;
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From Orders";
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "OrdersData");
                int totNumOrders = ds.Tables["OrdersData"].Rows.Count;
                for (int i = 0; i < totNumOrders; i++)
                {
                    DataRow dRow = ds.Tables["OrdersData"].Rows[i];
                  
                    IOrder order = OrderFactory.GetOrder(Convert.ToInt16(dRow.ItemArray.GetValue(0).ToString()),
                                            Convert.ToInt16(dRow.ItemArray.GetValue(1).ToString()),
                                            Convert.ToInt16(dRow.ItemArray.GetValue(2).ToString()),
                                            Convert.ToBoolean(dRow.ItemArray.GetValue(3).ToString()),
                                            DateTime.Parse(dRow.ItemArray.GetValue(4).ToString()));
                    OrderList.Add(order);
               

                }
            }

            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }
            return OrderList;
        }

        public List<IProductLine> getProductLinesForOrder(int OrderCode)
        {
            List<IProductLine> ProductLineList = new List<IProductLine>();
            DataSet ds;                 //Declare the DataSet object
            SqlDataAdapter da;   //Declare the DataAdapter object
            SqlCommandBuilder cb;
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From ProductLines  where OrderCode = " + OrderCode.ToString();
                // We only want the product lines for this order, so thats all we will select into our DataSet
                da = new SqlDataAdapter(sql, con);
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "ProductLinesData");
                int totNumLines = ds.Tables["ProductLinesData"].Rows.Count;
                for (int i = 0; i < totNumLines; i++)
                {
                    DataRow dRow = ds.Tables["ProductLinesData"].Rows[i];
                    IProductLine productLine = ProductLineFactory.GetProductLine(Convert.ToInt16(dRow.ItemArray.GetValue(0).ToString()),
                                            Convert.ToInt16(dRow.ItemArray.GetValue(1).ToString()),
                                            dRow.ItemArray.GetValue(2).ToString(),
                                            Convert.ToInt16(dRow.ItemArray.GetValue(3).ToString()),
                                            Convert.ToInt16(dRow.ItemArray.GetValue(4).ToString()),
                                            Convert.ToBoolean(dRow.ItemArray.GetValue(5).ToString()));
                    ProductLineList.Add(productLine);
                    
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
                //Environment.Exit(0); //Force the application to close
            }

            return ProductLineList;
    }

        public bool  editProductLineInDB(IProductLine productLine)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From ProductLines";
                da = new SqlDataAdapter(sql, getConnection());
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "ProductLinesData");
                object[] compK = new object[2] { productLine.ProductLineCode.ToString(), productLine.OrderCode}; // using a composite primiary key
                DataRow findRow = ds.Tables["ProductLinesData"].Rows.Find(compK);
                if (findRow != null)
                {
                    findRow[4] = productLine.QtyPrepared.ToString();
                    findRow[5] = productLine.Complete;

                }
                da.Update(ds, "ProductLinesData"); //update row in database table
                return true;
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
                if (getConnection().State.ToString() == "Open")
                    getConnection().Close();
                Application.Exit();
                return false;
            }
        }


        //Available rooms (Student) -FG
        public List<ILibraryRoom> getAllLibraryRooms()
        {
            List<ILibraryRoom> rooms = new List<ILibraryRoom>();
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            try
            {
                string sql = "SELECT lr.*, rs.StatusName FROM LibraryRooms AS lr, RoomStatus AS rs WHERE lr.RoomStatusID = rs.RoomStatusID AND lr.RoomStatusID = 2";
                da = new SqlDataAdapter(sql, con);
                da.Fill(ds, "LibraryRoomsData");
                foreach (DataRow dRow in ds.Tables["LibraryRoomsData"].Rows)
                {
                    ILibraryRoom room = new LibraryRoom
                    {
                        LibraryRoomID = Convert.ToInt32(dRow["LibraryRoomID"]),
                        RoomNumber = dRow["RoomNumber"].ToString(),
                        Capacity = Convert.ToInt32(dRow["Capacity"]),
                        Resources = dRow["Resources"].ToString(),
                        RoomStatusID = Convert.ToInt32(dRow["RoomStatusID"]),
                        StatusName = dRow["StatusName"].ToString()
                    };
                    rooms.Add(room);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (con.State == ConnectionState.Open) con.Close();
            }
            return rooms;
        }

        public List<ILibraryRoom> getLibraryRoomsAvailable(DateTime date, DateTime startTime, DateTime endTime)
        {
            List<ILibraryRoom> rooms = new List<ILibraryRoom>();
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            String dateString = date.ToString("yyyy-MM-dd");
            String startTimeString = startTime.ToString("HH:mm:ss");
            String endTimeString = endTime.ToString("HH:mm:ss");
            try
            {
                string sql = "SELECT lr.*, rs.StatusName FROM (" +
                        "SELECT *, CONVERT(time, '" + startTimeString + "') AS StartTime, CONVERT(time, '" + endTimeString + "') AS EndTime FROM LibraryRooms" +
                    ") AS lr, RoomStatus AS rs WHERE NOT EXISTS (SELECT lrb.LibraryRoomID " + 
                        "FROM LibraryRoomBookings AS lrb " +
                        "WHERE lrb.LibraryRoomID = lr.LibraryRoomID " +
                            "AND CONVERT(date, '" + dateString + "') = lrb.Date " +
                            "AND (lr.StartTime > lrb.StartTime AND lr.StartTime < lrb.EndTime " +
                            "OR lr.EndTime > lrb.StartTime AND lr.EndTime < lrb.EndTime " +
                            "OR lrb.StartTime > lr.StartTime AND lrb.StartTime < lr.EndTime " +
                            "OR lrb.EndTime > lr.StartTime AND lrb.EndTime < lr.EndTime" +
                        ")) AND lr.RoomStatusID = 2 AND lr.RoomStatusID = rs.RoomStatusID";

                da = new SqlDataAdapter(sql, con);
                da.Fill(ds, "LibraryRoomsData");
                foreach (DataRow dRow in ds.Tables["LibraryRoomsData"].Rows)
                {
                    ILibraryRoom room = new LibraryRoom
                    {
                        LibraryRoomID = Convert.ToInt32(dRow["LibraryRoomID"]),
                        RoomNumber = dRow["RoomNumber"].ToString(),
                        Capacity = Convert.ToInt32(dRow["Capacity"]),
                        Resources = dRow["Resources"].ToString(),
                        RoomStatusID = Convert.ToInt32(dRow["RoomStatusID"]),
                        StatusName = dRow["StatusName"].ToString()
                    };
                    rooms.Add(room);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (con.State == ConnectionState.Open) con.Close();
            }
            return rooms;
        }
        public void addNewBookingToDB(LibraryRoomBooking booking)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From LibraryRoomBookings";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Fill(ds, "LibraryRoomBookingsData");
                DataRow dRow = ds.Tables["LibraryRoomBookingsData"].NewRow();
                dRow[0] = booking.UserId;
                dRow[1] = booking.LibraryRoomId;
                dRow[2] = booking.Date.Date;
                dRow[3] = new TimeSpan(booking.StartTime.TimeOfDay.Hours, booking.StartTime.TimeOfDay.Minutes, 0);
                dRow[4] = new TimeSpan(booking.EndTime.TimeOfDay.Hours, booking.EndTime.TimeOfDay.Minutes, 0);
                dRow[5] = booking.Cancelled;

                ds.Tables["LibraryRoomBookingsData"].Rows.Add(dRow);
                da.Update(ds, "LibraryRoomBookingsData");
            }
            catch (Exception _)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
            }
        }
    }
}
