using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IBooking
    {
        int userID { get; set; }
        IRoom room { get; set; }
        DateTime date { get; set; }
        DateTime startTime { get; set; }
        DateTime endTime { get; set; }
        bool cancelled { get; set; }
    }
}
