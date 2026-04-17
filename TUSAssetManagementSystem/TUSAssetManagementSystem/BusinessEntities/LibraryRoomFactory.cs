using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class LibraryRoomFactory 
    {
        private static LibraryRoom room = null;

        public static LibraryRoom GetLibraryRoom(int roomId, string roomNumber, int capacity, string resources, int statusId, string statusName, string roomType)
        {
            if (room != null)   
                return room;
            else
                return new LibraryRoom(roomId, roomNumber, capacity, resources, statusId, statusName, roomType);
        }
        public static void SetLibraryRoom(LibraryRoom newRoom)   
        {
            room = newRoom;
        }
    }

}


