using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IRoom
    {
        int roomID { get; set; }
        string roomNumber { get; set; }
        int capacity { get; set; }
        string resources { get; set; }
        int roomStatusID { get; set; }
        String statusName { get; set; }
    }
}
