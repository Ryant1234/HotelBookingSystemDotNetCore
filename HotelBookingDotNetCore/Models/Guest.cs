using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBookingDotNetCore.Models
{
    public class Guest
    {
        public int GuestID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string PostCode { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public ICollection<Invoice> Invoices { get; set; }
    }
}
