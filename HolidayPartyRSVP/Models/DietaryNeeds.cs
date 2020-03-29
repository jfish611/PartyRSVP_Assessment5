using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolidayPartyRSVP.Models
{
    public class DietaryNeeds
    {
        private static string[] dietaryNeedsOptions = { "Gluten Free", "Vegan","Kosher", "Hallal", "Lactose Intollerant"};

        public static string[] DietaryNeedsOptions { get => dietaryNeedsOptions; set => dietaryNeedsOptions = value; }
    }
}
