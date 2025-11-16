using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class LibraryRoom : ILibraryRoom
    {
        public int LibraryRoomID { get; set; }
        public string RoomNumber { get; set; }
        public int Capacity { get; set; }
        public string Resources { get; set; }
        public int RoomStatusID { get; set; }
        public String StatusName { get; set; }
    }

}
