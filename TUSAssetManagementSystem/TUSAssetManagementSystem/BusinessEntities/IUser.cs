using System;
namespace BusinessEntities
{
    public interface IUser
    {
        string Name { get; set; }
        string Password { get; set; }
        string UserType { get; set; }
        int UserID { get; set; }
    }
}
