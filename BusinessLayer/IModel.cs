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
    }
}
