using HotelBookingDotNetCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace HotelBookingDotNetCore.Data
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        {
        }
            public DbSet<Booking> Bookings { get; set; }
            public DbSet<Guest> Guests { get; set; }
            public DbSet<Invoice> Invoices { get; set; }
            public DbSet<Room> Rooms { get; set; }

    }

    }

