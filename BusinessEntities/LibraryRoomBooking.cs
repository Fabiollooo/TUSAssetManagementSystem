using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class LibraryRoomBooking : BusinessEntities.IBooking
    {
        #region Instance Properties
        private int userId;
        private int libraryRoomId;
        private DateTime date;
        private DateTime startTime;
        private DateTime endTime;
        private bool cancelled;

        #endregion

        #region Instance Properties
        public int UserId
        {
            get
            {
                return userId; ;
            }
            set
            {
                userId = value;
            }
        }

        public int LibraryRoomId
        {
            get
            {
                return libraryRoomId;
            }
            set
            {
                libraryRoomId = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        public DateTime StartTime
        {
            get
            {
                return startTime;
            }
            set
            {
                startTime = value;
            }
        }
        public DateTime EndTime
        {
            get
            {
                return endTime;
            }
            set
            {
                endTime = value;
            }
        }
        public bool Cancelled
        {
            get
            {
                return cancelled;
            }
            set
            {
                cancelled = value;
            }
        }

        #endregion
        #region Constructors
        public LibraryRoomBooking()
        {
            this.userId = 0;
            this.libraryRoomId = 0;
            this.date = new DateTime();
            this.startTime = new DateTime();
            this.endTime = new DateTime();
            this.cancelled = false;
        }

        public LibraryRoomBooking(int userId, int libraryRoomId, DateTime date, DateTime startTime, DateTime endTime, bool cancelled)
        {
            this.userId = userId;
            this.libraryRoomId = libraryRoomId;
            this.date = date;
            this.startTime = startTime;
            this.endTime = endTime;
            this.cancelled = cancelled;
        }

        #endregion


    }
}

