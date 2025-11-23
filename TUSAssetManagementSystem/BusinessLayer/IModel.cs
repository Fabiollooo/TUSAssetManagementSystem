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
        List<LibraryRoom> LibraryRoomList { get; set; }
        void populateLibraryRooms();
        void populateLibraryRooms(DateTime date, DateTime startTime, DateTime endTime);

        //Count for "Active bookings" - FG
        int CountActiveBookingsForUser(int userId);
        //Count for "Hours Booked" - FG
        int GetHoursBookedThisMonth(int userId);
        //Count for "No of Upcoming bookings" - FG
        int GetUpcomingBookingsCount(int userId);

        //Upcoming bookings - FG
        List<LibraryRoomBooking> GetTop3UpcomingBookings(int userId);

        bool UpdateBookingCheckInStatus(int bookingId, bool isCheckedIn);
        int GetAvailableRoomsCount(int userId);
        bool UpdateLibraryRoom(LibraryRoom room);
        bool DeleteLibraryRoom(int roomId);

        //Count for "Total bookings" - TM
        int CountTotalBookings(int? userId);
        //Count for "Cancelled bookings" - TM
        int CountCancelledBookingsForUser(int userId);
        //Count for "Completed bookings" - TM
        int CountCompletedBookingsForUser(int userId);


        //Book Library Room (Student) -TM
        bool AddNewLibraryBooking(LibraryRoomBooking booking);
        // View Your Library Room Bookings (Student) -TM
        List<LibraryRoomBooking> LibraryRoomBookingsList { get; set; }
        void populateLibraryRoomBookings(IUser student);

        bool AddLibraryRoom(string roomNumber, int capacity, string resources, int statusId, string statusName, string roomType);
    }
}
