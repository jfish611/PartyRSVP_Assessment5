using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolidayPartyRSVP.Models
{
    public class AttendingMod
    {
        private static string[] attending = { "Yes", "No" };

        public static string[] Attending { get => attending; set => attending = value; }
    }
}
