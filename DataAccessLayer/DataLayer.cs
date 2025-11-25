using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessEntities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataAccessLayer
{
    public class DataLayer : IDataLayer
    {
        #region Instance Attributes
        private SqlConnection con;   // DB Connection
        DataSet ds;                 //Declare the DataSet object
        SqlDataAdapter da;          //Declare the DataAdapter object
        int totUsers;
        int totLibraryRooms;
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
            con.ConnectionString = "Data Source=tcp:MY-V-U-ITSQL05.tusstudent.ad.tus.ie\\INSTBL11,60161;Initial Catalog=ProductTracker;User ID=K00295782;Password=11$QLSD3-2025;";


             //con.ConnectionString = "Server=tcp:producttrackerserver.database.windows.net,1433;Initial Catalog=ProductTracker;Persist Security Info=False;User ID=adminUser;Password=P@ssword123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
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
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "UsersData");

                DataRow findRow = ds.Tables["UsersData"].Rows.Find(user.UserID);
                if (findRow != null)
                {
                    
                    findRow[0] = user.Name;
                    findRow[1] = user.Password;
                    findRow[2] = user.UserType;   
                }

                da.Update(ds, "UsersData");      
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (con.State == ConnectionState.Open)
                    con.Close();
                return false;
            }
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

        public bool editProductLineInDB(IProductLine productLine)
        {
            try
            {
                ds = new DataSet();
                string sql = "SELECT * From ProductLines";
                da = new SqlDataAdapter(sql, getConnection());
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                cb = new SqlCommandBuilder(da);  //Generates
                da.Fill(ds, "ProductLinesData");
                object[] compK = new object[2] { productLine.ProductLineCode.ToString(), productLine.OrderCode }; // using a composite primiary key
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


        //All rooms (Student) -FG
        public List<LibraryRoom> getAllLibraryRooms()
        {
            List<LibraryRoom> rooms = new List<LibraryRoom>();
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            try
            {
                string sql = "SELECT lr.*, rs.StatusName FROM LibraryRooms AS lr, RoomStatus AS rs WHERE lr.RoomStatusID = rs.RoomStatusID";
                da = new SqlDataAdapter(sql, con);
                da.Fill(ds, "LibraryRoomsData");
                foreach (DataRow dRow in ds.Tables["LibraryRoomsData"].Rows)
                {
                    LibraryRoom room = new LibraryRoom(
                    Convert.ToInt32(dRow["LibraryRoomID"]),
                    dRow["RoomNumber"].ToString(),
                    Convert.ToInt32(dRow["Capacity"]),
                    dRow["Resources"].ToString(),
                    Convert.ToInt32(dRow["RoomStatusID"]),
                    dRow["StatusName"].ToString(),
                    dRow["RoomType"].ToString()
                     );

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
        public int CountTotalBookings(int? userId)
        {
            string defaultSql = "SELECT COUNT(*) FROM LibraryRoomBookings";
            SqlCommand cmd = new SqlCommand(defaultSql, con);

            if (userId != null)
            {
                cmd.CommandText += " WHERE UserID = @UserID";
                cmd.Parameters.AddWithValue("@UserID", userId);
            }
            return (int)cmd.ExecuteScalar();
        }
        public int CountActiveBookings(int? userId)
        {
            string defaultSql = "SELECT COUNT(*) FROM LibraryRoomBookings WHERE Cancelled = 0 AND Date >= GETDATE()";
            SqlCommand cmd = new SqlCommand(defaultSql, con);

            if (userId != null)
            {
                cmd.CommandText += " AND UserID = @UserID";
                cmd.Parameters.AddWithValue("@UserID", userId);
            }
            return (int)cmd.ExecuteScalar();
        }
        public int CountActiveBookingsForUser(int userId)
        {
            string sql = "SELECT COUNT(*) FROM LibraryRoomBookings WHERE UserID = @UserID AND Cancelled = 0";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@UserID", userId);
            return (int)cmd.ExecuteScalar();
        }
        public int CountCancelledBookingsForUser(int userId)
        {
            string sql = "SELECT COUNT(*) FROM LibraryRoomBookings WHERE UserID = @UserID AND Cancelled = 1";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@UserID", userId);
            return (int)cmd.ExecuteScalar();
        }
        public int CountCompletedBookingsForUser(int userId)
        {
            string sql = "SELECT COUNT(*) FROM LibraryRoomBookings WHERE UserID = @UserID AND Cancelled = 0 AND Date < GETDATE()";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@UserID", userId);
            return (int)cmd.ExecuteScalar();
        }
        public int GetHoursBookedThisMonth(int userId)
        {
            string sql = "SELECT SUM(DATEDIFF(HOUR, StartTime, EndTime)) FROM LibraryRoomBookings WHERE UserID = @UserID AND MONTH(Date) = MONTH(GETDATE()) AND Cancelled = 0";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@UserID", userId);
            object result = cmd.ExecuteScalar();
            return result == DBNull.Value ? 0 : Convert.ToInt32(result);
        }

        public int GetUpcomingBookingsCount(int userId)
        {
            string sql = "SELECT COUNT(*) FROM LibraryRoomBookings WHERE UserID = @UserID AND Date BETWEEN GETDATE() AND DATEADD(day, 7, GETDATE()) AND Cancelled = 0";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@UserID", userId);
            return (int)cmd.ExecuteScalar();
        }

        public int GetAvailableRoomsCountRightNow(string userType)
        {
            string sql = @"SELECT COUNT(*) FROM LibraryRooms WHERE LibraryRoomID NOT IN (SELECT LibraryRoomID FROM LibraryRoomBookings WHERE Date = CAST(@CurrentTime AS date) AND CONVERT(time, @CurrentTime) BETWEEN StartTime AND EndTime AND Cancelled = 0) AND RoomStatusID = 2 AND (RoomType = @UserType OR RoomType = 'Both')";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@CurrentTime", DateTime.Now);
            cmd.Parameters.AddWithValue("@UserType", userType);

            try
            {
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }




        //Upcoming Bookings - FG
        public List<LibraryRoomBooking> GetTop3UpcomingBookings(int userId)
        {
            List<LibraryRoomBooking> bookings = new List<LibraryRoomBooking>();

            try
            {
                string query = @"SELECT TOP 3 lrb.BookingID, lrb.LibraryRoomID, lrb.StartTime, lrb.EndTime, lrb.Date, 
                                lr.RoomNumber, lrb.CheckedIn, lrb.Cancelled 
                        FROM LibraryRoomBookings lrb
                        INNER JOIN LibraryRooms lr ON lrb.LibraryRoomID = lr.LibraryRoomID
                        WHERE lrb.UserID = @UserID 
                        AND lrb.Date >= CAST(GETDATE() AS DATE)
                        AND lrb.Cancelled = 0
                        ORDER BY lrb.StartTime ASC";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserID", userId);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int libraryRoomId = Convert.ToInt32(reader["LibraryRoomID"]);
                    string roomNumber = reader["RoomNumber"].ToString();
                    DateTime date = (DateTime)reader["Date"];
                    TimeSpan startTimeSpan = (TimeSpan)reader["StartTime"];
                    TimeSpan endTimeSpan = (TimeSpan)reader["EndTime"];
                    bool cancelled = Convert.ToBoolean(reader["Cancelled"]);

                    DateTime startTime = date.Date + startTimeSpan;
                    DateTime endTime = date.Date + endTimeSpan;

                    LibraryRoom room = new LibraryRoom(libraryRoomId, roomNumber, 0, "", 2, "Available", "");

                    LibraryRoomBooking booking = new LibraryRoomBooking(
                        Convert.ToInt32(reader["BookingID"]),
                        userId,
                        room,
                        date,
                        startTime,
                        endTime,
                        cancelled
                    )
                    {
                        checkedIn = Convert.ToBoolean(reader["CheckedIn"])
                    };
                    bookings.Add(booking);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in GetTop3UpcomingBookings: " + ex.Message);
            }

            return bookings;
        }

        //Admin Update Room - FG
        public bool UpdateLibraryRoom(LibraryRoom room)
        {
            string sql = @"UPDATE LibraryRooms 
                   SET RoomNumber = @RoomNumber, 
                   Capacity = @Capacity, 
                   Resources = @Resources, 
                   RoomStatusID = @statusID
                   WHERE LibraryRoomID = @LibraryRoomID";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@RoomNumber", room.roomNumber);
            cmd.Parameters.AddWithValue("@Capacity", room.capacity);
            cmd.Parameters.AddWithValue("@Resources", room.resources);
            cmd.Parameters.AddWithValue("@LibraryRoomID", room.roomID);
            cmd.Parameters.AddWithValue("@statusID", room.roomStatusID);

            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UpdateLibraryRoom: {ex.Message}");
                return false;
            }
        }


        //Admin Delete Room -FG
        public bool DeleteLibraryRoom(int roomId)
        {
            string sql = "DELETE FROM LibraryRooms WHERE LibraryRoomID = @RoomID";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@RoomID", roomId);

            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in DeleteLibraryRoom: {ex.Message}");
                return false;
            }
        }




        //Display rooms - TM
        public List<LibraryRoom> getLibraryRoomsAvailable(DateTime date, DateTime startTime, DateTime endTime)
        {
            List<LibraryRoom> rooms = new List<LibraryRoom>();
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
                    LibraryRoom room = new LibraryRoom(
                    Convert.ToInt32(dRow["LibraryRoomID"]),
                    dRow["RoomNumber"].ToString(),
                    Convert.ToInt32(dRow["Capacity"]),
                    dRow["Resources"].ToString(),
                    Convert.ToInt32(dRow["RoomStatusID"]),
                    dRow["StatusName"].ToString(),
                    dRow["RoomType"].ToString()
                     );

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
                dRow["UserID"] = booking.userID;
                dRow["LibraryRoomID"] = booking.room.roomID;
                dRow["Date"] = booking.date.Date;
                dRow["StartTime"] = new TimeSpan(booking.startTime.TimeOfDay.Hours, booking.startTime.TimeOfDay.Minutes, 0);
                dRow["EndTime"] = new TimeSpan(booking.endTime.TimeOfDay.Hours, booking.endTime.TimeOfDay.Minutes, 0);
                dRow["Cancelled"] = booking.cancelled;

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


        // -FG
        public List<LibraryRoomBooking> getAllStudentLibraryBookings(IUser student)
        {
            List<LibraryRoomBooking> bookings = new List<LibraryRoomBooking>();
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            try
            {
                string sqlTodayString = "CONVERT(date, '" + DateTime.Today.ToString("yyyy-MM-dd") + "')";
                string sqlNowString = "CONVERT(time, '" + DateTime.Now.ToString("HH:mm") + "')";
                string sql = "SELECT lrb.*, lr.*, rs.StatusName FROM LibraryRoomBookings AS lrb, LibraryRooms AS lr, RoomStatus AS rs " +
                    "WHERE (lrb.Date > " + sqlTodayString + " OR (lrb.Date = " + sqlTodayString + " AND lrb.EndTime >= " + sqlNowString + ")) " +
                    "AND lrb.LibraryRoomID = lr.LibraryRoomID AND lr.RoomStatusID = rs.RoomStatusID AND lrb.UserID = " + student.UserID + " ORDER BY lrb.Date";
                da = new SqlDataAdapter(sql, con);
                da.Fill(ds, "LibraryRoomBookingsData");
                foreach (DataRow dRow in ds.Tables["LibraryRoomBookingsData"].Rows)
                {
                    LibraryRoom room = new LibraryRoom(
                    Convert.ToInt32(dRow["LibraryRoomID"]),
                    dRow["RoomNumber"].ToString(),
                    Convert.ToInt32(dRow["Capacity"]),
                    dRow["Resources"].ToString(),
                    Convert.ToInt32(dRow["RoomStatusID"]),
                    dRow["StatusName"].ToString(),
                    dRow["RoomType"].ToString()
                     );

                    DateTime date = (DateTime)dRow["Date"];
                    TimeSpan startTimeSpan = (TimeSpan)dRow["StartTime"];
                    TimeSpan endTimeSpan = (TimeSpan)dRow["EndTime"];
                    bool cancelled = Convert.ToBoolean(dRow["Cancelled"]);

                    DateTime startTime = date.Date + startTimeSpan;
                    DateTime endTime = date.Date + endTimeSpan;

                    LibraryRoomBooking booking = new LibraryRoomBooking(
                        Convert.ToInt32(dRow["BookingID"]),
                        Convert.ToInt32(dRow["UserID"]),
                        room,
                        date,
                        startTime,
                        endTime,
                        cancelled
                    )
                    {
                        checkedIn = Convert.ToBoolean(dRow["CheckedIn"])
                    };
                    bookings.Add(booking);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in getAllStudentLibraryBookings: " + ex.Message);
                if (con.State == ConnectionState.Open) con.Close();
            }
            return bookings;
        }

        //Update booking check in status - FG
        public bool UpdateBookingCheckInStatus(int bookingId, bool isCheckedIn)
        {
            try
            {
                string query = "UPDATE LibraryRoomBookings SET CheckedIn = @CheckedIn WHERE BookingID = @BookingID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CheckedIn", isCheckedIn);
                cmd.Parameters.AddWithValue("@BookingID", bookingId);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating check-in status: " + ex.Message);
                return false;
            }
        }

        public void addNewLibraryRoomToDB(LibraryRoom newLibraryRoom)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * From LibraryRooms";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Fill(ds, "LibraryRoomsData");
                totLibraryRooms = ds.Tables["LibraryRoomsData"].Rows.Count;
                DataRow dRow = ds.Tables["LibraryRoomsData"].NewRow();
                dRow[0] = newLibraryRoom.roomID;
                dRow[1] = newLibraryRoom.roomNumber;
                dRow[2] = newLibraryRoom.capacity;
                dRow[3] = newLibraryRoom.resources;
                dRow[4] = newLibraryRoom.roomStatusID;
                dRow[5] = newLibraryRoom.roomType;


                ds.Tables["LibraryRoomsData"].Rows.Add(dRow);
                da.Update(ds, "LibraryRoomsData");
            }
            catch (Exception)
            {
                if (con.State.ToString() == "Open")
                    con.Close();
                Application.Exit();
            }
        }

        public List<LibraryRoomBooking> GetAllLibraryBookings()
        {
            List<LibraryRoomBooking> bookings = new List<LibraryRoomBooking>();
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                string sql = @"
              SELECT  lrb.BookingID,
            lrb.UserID,
            lrb.LibraryRoomID,
            lrb.Date,
            lrb.StartTime,
            lrb.EndTime,
            lrb.Cancelled,
            lrb.CheckedIn,
            lr.RoomNumber,
            lr.Capacity,
            lr.Resources,
            lr.RoomStatusID,
            rs.StatusName
           FROM LibraryRoomBookings AS lrb
            JOIN LibraryRooms AS lr ON lrb.LibraryRoomID = lr.LibraryRoomID
          JOIN RoomStatus AS rs ON lr.RoomStatusID = rs.RoomStatusID
      ";


                da = new SqlDataAdapter(sql, con);
                da.Fill(ds, "LibraryRoomBookingsData");

                foreach (DataRow dRow in ds.Tables["LibraryRoomBookingsData"].Rows)
                {
                    LibraryRoom room = new LibraryRoom(
                        Convert.ToInt32(dRow["LibraryRoomID"]),
                        dRow["RoomNumber"].ToString(),
                        Convert.ToInt32(dRow["Capacity"]),
                        dRow["Resources"].ToString(),
                        Convert.ToInt32(dRow["RoomStatusID"]),
                        dRow["StatusName"].ToString()
                    );

                    DateTime date = (DateTime)dRow["Date"];
                    TimeSpan startSpan = (TimeSpan)dRow["StartTime"];
                    TimeSpan endSpan = (TimeSpan)dRow["EndTime"];

                    DateTime startTime = date.Date + startSpan;
                    DateTime endTime = date.Date + endSpan;

                    bool cancelled = dRow["Cancelled"] != DBNull.Value && (bool)dRow["Cancelled"];
                    bool checkedIn = dRow["CheckedIn"] != DBNull.Value && (bool)dRow["CheckedIn"];

                    LibraryRoomBooking booking = new LibraryRoomBooking(
                        Convert.ToInt32(dRow["BookingID"]),
                        Convert.ToInt32(dRow["UserID"]),
                        room,
                        date,
                        startTime,
                        endTime,
                        cancelled
                    )
                    {
                        checkedIn = checkedIn
                    };

                    bookings.Add(booking);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving library bookings: " + ex.Message);
            }

            return bookings;
        }

        public bool UpdateLibraryRoomBooking(LibraryRoomBooking booking)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                string sql = @"
            UPDATE LibraryRoomBookings
            SET LibraryRoomID = @RoomID,
                Date         = @Date,
                StartTime    = @StartTime,
                EndTime      = @EndTime
            WHERE BookingID  = @BookingID";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@RoomID", booking.room.roomID);
                    cmd.Parameters.AddWithValue("@Date", booking.date.Date);
                    cmd.Parameters.AddWithValue("@StartTime",
                        new TimeSpan(booking.startTime.Hour, booking.startTime.Minute, 0));
                    cmd.Parameters.AddWithValue("@EndTime",
                        new TimeSpan(booking.endTime.Hour, booking.endTime.Minute, 0));
                    cmd.Parameters.AddWithValue("@BookingID", booking.bookingID);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating booking: " + ex.Message);
                return false;
            }
        }



        public bool CancelLibraryBooking(int bookingId)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                string sql = "UPDATE LibraryRoomBookings SET Cancelled = 1 WHERE BookingID = @BookingID";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@BookingID", bookingId);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cancelling library booking: " + ex.Message);
                return false;
            }
        }

        public int AutoCancelNoShowBookings()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                string sql = @"
            UPDATE LibraryRoomBookings
            SET Cancelled = 1
            WHERE Cancelled = 0
              AND (CheckedIn = 0 OR CheckedIn IS NULL)
              AND DATEADD(hour,
                          DATEPART(hour, EndTime),
                          DATEADD(minute, DATEPART(minute, EndTime), CAST(Date AS datetime)))
                  < GETDATE();";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error auto - cancelling no - show bookings:" + "" + ex.Message);
                return 0;
            }
           
        }
    }
}
