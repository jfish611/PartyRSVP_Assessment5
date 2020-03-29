using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HolidayPartyRSVP.Models
{
    public class Reserve
    {
        private string firstName;
        private string lastName;
        private string email;
        private string attending;
        private int additionalGuest;

        [DisplayName("First Name")]
        [Required]
        [MaxLength(10)]
        [MinLength(1)]
        public string FirstName { get => firstName; set => firstName = value; }
      
        [DisplayName("Last Name")]
        [Required]
        [MaxLength(10)]
        [MinLength(1)]
        public string LastName { get => lastName; set => lastName = value; }

        [DisplayName("First Name")]
        [Required]
        [EmailAddress]
        public string Email { get => email; set => email = value; }

        [DisplayName("Are you attending?")]
        [Required]
        public string Attending { get => attending; set => attending = value; }

        [DisplayName("Are you bringing an additional guest?")]
        public int AdditionalGuest { get => additionalGuest; set => additionalGuest = value; }
    }
}
