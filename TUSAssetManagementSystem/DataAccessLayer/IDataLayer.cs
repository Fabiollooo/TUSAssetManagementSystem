using BusinessEntities;
using System;
using System.Collections;
using System.Collections.Generic;
namespace DataAccessLayer
{
    public interface IDataLayer
    {

        void addNewUserToDB(BusinessEntities.IUser theUser);
        bool deleteUserFromDB(BusinessEntities.IUser user);
        bool editUserInDB(BusinessEntities.IUser user);
        void closeConnection();
        List<IUser> getAllUsers();
        System.Data.SqlClient.SqlConnection getConnection();
        void openConnection();
        List<IOrder> getAllOrders();
        List<IProductLine> getProductLinesForOrder(int OrderCode);

        bool editProductLineInDB(BusinessEntities.IProductLine productLine);

        //Available Rooms (Student) -FG
        List<ILibraryRoom> getAllLibraryRooms();
        List<ILibraryRoom> getLibraryRoomsAvailable(DateTime date, DateTime startTime, DateTime endTime);
        int CountActiveBookingsForUser(int userId);
        int GetHoursBookedThisMonth(int userId);
        int GetUpcomingBookingsCount(int userId);

        // Book Library Room (Student) -TM
        void addNewBookingToDB(LibraryRoomBooking booking);
    }
}
