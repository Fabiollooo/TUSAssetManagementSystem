using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class LibraryRoom : IRoom
    {
        public int roomID { get; set; }
        public string roomNumber { get; set; }
        public int capacity { get; set; }
        public string resources { get; set; }
        public int roomStatusID { get; set; }
        public String statusName { get; set; }
        public string roomType { get; set; }


        public LibraryRoom()
        {
            roomID = 0;
            roomNumber = "";
            capacity = 0;
            resources = "";
            roomStatusID = 0;
            statusName = "Unknown";
        }

        public LibraryRoom(int roomID, string roomNumber, int capacity, string resources, int roomStatusID, string statusName, string roomType)
        {
            this.roomID = roomID;
            this.roomNumber = roomNumber;
            this.capacity = capacity;
            this.resources = resources;
            this.roomStatusID = roomStatusID;
            this.statusName = statusName;
            this.roomType = roomType;
        }

        public LibraryRoom(int libraryRoomID,
                       string roomNumber,
                       int capacity,
                       string resources,
                       int roomStatusID,
                       string statusName)
        : this(libraryRoomID, roomNumber, capacity, resources, roomStatusID, statusName, "Unknown")
        {
        }
    }
}

