using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class LibraryRoomBooking : IBooking
    {
        #region Instance Properties
        public int userID { get; set; }
        public IRoom room { get; set; }
        public DateTime date { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public bool cancelled { get; set; }
        #endregion

        #region Constructors
        public LibraryRoomBooking()
        {
            this.userID = 0;
            this.room = null;
            this.date = new DateTime();
            this.startTime = new DateTime();
            this.endTime = new DateTime();
            this.cancelled = false;
        }

        public LibraryRoomBooking(int userId, LibraryRoom room, DateTime date, DateTime startTime, DateTime endTime, bool cancelled)
        {
            this.userID = userId;
            this.room = room;
            this.date = date;
            this.startTime = startTime;
            this.endTime = endTime;
            this.cancelled = cancelled;
        }

        #endregion


    }
}

