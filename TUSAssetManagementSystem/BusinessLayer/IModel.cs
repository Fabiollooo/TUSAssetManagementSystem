using System;
using BusinessEntities;
using System.Collections.Generic;
namespace BusinessLayer
{
    public interface IModel
    {
        bool addNewUser(string name, string password, string userType);
        BusinessEntities.IUser CurrentUser { get; set; }
        DataAccessLayer.IDataLayer DataLayer { get; set; }
        bool deleteUser(IUser user);
        bool editUser(BusinessEntities.IUser user);
        string getUserTypeForCurrentuser();
        bool login(string name, string password);
        List<IProductLine> ProductLineList { get; set; }
        void tearDown();
        List<IUser> UserList { get; }
        List<IOrder> OrderList { get; set; }

        void populateOrders();
        bool updateProductLine(IProductLine productLine);


       //View Available Rooms (Student) -FG
        List<ILibraryRoom> LibraryRoomList { get; set; }
        void populateLibraryRooms();
        void populateLibraryRooms(DateTime date, DateTime startTime, DateTime endTime);

        //Count for "Active bookings" - FG
        int CountActiveBookingsForUser(int userId);
        //Count for "Hours Booked" - FG
        int GetHoursBookedThisMonth(int userId);
        //Count for "No of Upcoming bookings" - FG
        int GetUpcomingBookingsCount(int userId);



       // Book Library Room (Student) -TM
        bool AddNewLibraryBooking(LibraryRoomBooking booking);


    }
}
