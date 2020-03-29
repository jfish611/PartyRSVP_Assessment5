using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HolidayPartyRSVP.Models
{
    public class DishOptions
    {
        private string name;
        private int phoneNumber;
        private string dishName;
        private string dishDescription;
        private string dietaryNeeds;

        [DisplayName("Name:")]
        [Required]
        public string Name { get => name; set => name = value; }
        [DisplayName("Phone Number:")]
        [Required]
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        [DisplayName("Name of dish:")]
        [Required]
        public string DishName { get => dishName; set => dishName = value; }

        [DisplayName("Description")]
        public string DishDescription { get => dishDescription; set => dishDescription = value; }

        [DisplayName("Dietary Needs")]
        public string DietaryNeeds { get => dietaryNeeds; set => dietaryNeeds = value; }
    }


}
