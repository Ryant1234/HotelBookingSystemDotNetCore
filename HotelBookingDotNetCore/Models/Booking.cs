using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBookingDotNetCore.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        public int RoomID { get; set; }
        public int GuestID { get; set; }

        public DateTime BookingFrom { get; set; }
        public DateTime BookingTo { get; set; }

        public DateTime CheckInTime { get; set; }
        public DateTime CheckOutTime { get; set; }

        public Room Room { get; set; }
        public Guest Guest { get; set; }


    }
}
