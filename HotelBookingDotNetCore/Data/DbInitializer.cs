using HotelBookingDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBookingDotNetCore.Data
{
    public static class DbInitializer
    {
        public static void Initialize(HotelContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Guests.

            if (context.Guests.Any())
            {
                return;
            }
            var guests = new Guest[]
            {
                new Guest {FirstName="John", LastName="Smith", Address="123 Fake St", PhoneNumber="555-9274", PostCode="3000", Suburb="Melbourne", State="Victoria", Country="Australia" },

                new Guest {FirstName="Homer", LastName="Simpson", Address="742 Evergreen Terrace", PhoneNumber="555-7294", PostCode="3434", Suburb="Springfield", State="Victoria", Country="Australia" },

                  new Guest {FirstName="Peter", LastName="Parker", Address="123 Main St", PhoneNumber="545-5328", PostCode="3000", Suburb="Melbourne", State="Victoria", Country="Australia" },

                   new Guest {FirstName="Diana", LastName="Bourke", Address="495 High St", PhoneNumber="415-0912", PostCode="3101", Suburb="Kew", State="Victoria", Country="Australia" },

                    new Guest {FirstName="Stephen", LastName="Bill", Address="472 Main St", PhoneNumber="535-7274", PostCode="3015", Suburb="Newport", State="Victoria", Country="Australia" },

                     new Guest {FirstName="John", LastName="Cook", Address="1235 Victoria St", PhoneNumber="555-8555", PostCode="3067", Suburb="Abbotsford", State="Victoria", Country="Australia" }
            };
            foreach (Guest g in guests)
            {
                context.Guests.Add(g);
            }
            context.SaveChanges();

            var bookings = new Booking[]
            {
                new Booking { BookingID=1, RoomID=1, GuestID=1, BookingFrom= DateTime.ParseExact("15/06/2017", "dd/MM/YYYY", null) , BookingTo = DateTime.ParseExact("20/06/2017", "dd/MM/YYYY", null), CheckInTime = DateTime.ParseExact("15/06/2015 12:00:00", "dd/MM/yyyy HH:mm:ss",null), CheckOutTime = DateTime.ParseExact("20/06/2015 12:00:00", "dd/MM/yyyy HH:mm:ss",null) },

                new Booking { BookingID=2, RoomID=2, GuestID=2, BookingFrom= DateTime.ParseExact("15/06/2017", "dd/MM/YYYY", null) , BookingTo = DateTime.ParseExact("20/06/2017", "dd/MM/YYYY", null), CheckInTime = DateTime.ParseExact("15/06/2015 12:00:00", "dd/MM/yyyy HH:mm:ss",null), CheckOutTime = DateTime.ParseExact("20/06/2015 12:00:00", "dd/MM/yyyy HH:mm:ss",null) },

                new Booking { BookingID=3, RoomID=3, GuestID=3, BookingFrom= DateTime.ParseExact("15/06/2017", "dd/MM/YYYY", null) , BookingTo = DateTime.ParseExact("20/06/2017", "dd/MM/YYYY", null), CheckInTime = DateTime.ParseExact("15/06/2015 12:00:00", "dd/MM/yyyy HH:mm:ss",null), CheckOutTime = DateTime.ParseExact("20/06/2015 12:00:00", "dd/MM/yyyy HH:mm:ss",null) },
                };

            foreach (Booking b in bookings)
            {
                context.Bookings.Add(b);
            }
            context.SaveChanges();


            var rooms = new Room[]
            {
                new Room{RoomID=1, RoomType = RoomType.Single},
                new Room{RoomID=2, RoomType = RoomType.Double},
                 new Room{RoomID=3, RoomType = RoomType.Twin},
                  new Room{RoomID=4, RoomType = RoomType.King}
            };

            foreach (Room r in rooms)
            {
                context.Rooms.Add(r);
            }
            context.SaveChanges();

            var invoices = new Invoice[]
            {
                new Invoice{InvoiceID = 1, CustomerID=1, BookingID=1, DateCreated = DateTime.ParseExact("15/06/2015 12:00:00", "dd/MM/yyyy HH:mm:ss",null), DatePaid = DateTime.ParseExact("20/06/2015 12:00:00", "dd/MM/yyyy HH:mm:ss",null), MiniBarCharge= 10.00, RoomPrice= 50.00, TotalPrice= 60.00 },

                 new Invoice{InvoiceID = 2, CustomerID=2, BookingID=2, DateCreated = DateTime.ParseExact("15/06/2015 12:00:00", "dd/MM/yyyy HH:mm:ss",null), DatePaid = DateTime.ParseExact("20/06/2015 12:00:00", "dd/MM/yyyy HH:mm:ss",null), MiniBarCharge= 10.00, RoomPrice= 50.00, TotalPrice= 60.00 },

                  new Invoice{InvoiceID = 3, CustomerID=3, BookingID=3, DateCreated = DateTime.ParseExact("15/06/2015 12:00:00", "dd/MM/yyyy HH:mm:ss",null), DatePaid = DateTime.ParseExact("20/06/2015 12:00:00", "dd/MM/yyyy HH:mm:ss",null), MiniBarCharge= 10.00, RoomPrice= 50.00, TotalPrice= 60.00 },


            };

            foreach(Invoice i in invoices)
            {
                context.Invoices.Add(i);
            }

            context.SaveChanges();

            }
         
        }
    }
}
