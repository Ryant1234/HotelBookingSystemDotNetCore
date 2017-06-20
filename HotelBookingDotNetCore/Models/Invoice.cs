using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBookingDotNetCore.Models
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public int CustomerID { get; set; }
        public int BookingID { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime? DatePaid { get; set; }

        public double MiniBarCharge { get; set; }
        public double RoomPrice { get; set; }
        public double TotalPrice { get; set; }

        public Booking Booking { get; set; }
        public Guest Guest { get; set; }



    }
}
