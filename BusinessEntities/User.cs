using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class User : BusinessEntities.IUser
    {
        #region Instance Properties
        private string name;
        private string password;
        private string userType;
        private int userID;

        #endregion

        #region Instance Properties
        public string Name
        {
            get
            {
                return name; ;
            }
            set
            {
                name = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public string UserType
        {
            get
            {
                return userType;
            }
            set
            {
                userType = value;
            }
        }
       public int UserID
        {
            get
            {
                return userID;
            }
            set
            {
                userID = value;
            }
        }

        #endregion
        #region Constructors
        public User()
        {
            throw new System.NotImplementedException();
        }

        public User(string name, string password, string userType, int userID)
        {
            this.name = name;
            this.password = password;
            this.userType = userType;
            this.userID = userID;
        }

        #endregion

      
    }
}
