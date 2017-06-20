using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBookingDotNetCore.Models
{
    public enum RoomType
    {
        Single, Double, Twin, King
    }


    public class Room
    {
        public int RoomID { get; set; }

        public RoomType RoomType { get; set; }
    }
}
