using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class LibraryRoomFactory // Only concern of factory is to create objects. 
    {
        private static LibraryRoom room = null;

        public static LibraryRoom GetLibraryRoom(int roomId, string roomNumber, int capacity, string resources, int statusId, string statusName, string roomType)
        {
            if (room != null)  // ie is Factory is primed with an object. 
                return room;
            else
                return new LibraryRoom(roomId, roomNumber, capacity, resources, statusId, statusName, roomType);
        }
        public static void SetLibraryRoom(LibraryRoom newRoom)   // This provides a seam in the factory where I can prime the factory with the user it will then cough up. (for test code) 
        {
            room = newRoom;
        }
    }

}


