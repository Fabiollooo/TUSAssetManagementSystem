using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface ILibraryRoom
    {
        int LibraryRoomID { get; set; }
        string RoomNumber { get; set; }
        int Capacity { get; set; }
        string Resources { get; set; }
        int RoomStatusID { get; set; }
        String StatusName { get; set; }
    }
}
