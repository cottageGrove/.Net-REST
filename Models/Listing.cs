using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class Listing
    {

        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter your name")] 
        public string Name { get; set; }

        public int Phone { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+",
        ErrorMessage = "Please enter a valid email address")]        public string Email { get; set; }

        [Required(ErrorMessage ="Please select your Role")] 
        public string Role { get; set; }

        [Required(ErrorMessage ="Please select the equipment you would like to borrow")] 
        public string Equipment { get; set; }

        public string RequestDetails { get; set; }


        [Required(ErrorMessage ="Please select the duration")] 
        public string Duration { get; set; }


    }
}