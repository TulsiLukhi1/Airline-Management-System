using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AirlineManagementSystem.Models
{
    [Table("Tbl_User")]
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage ="First Name is Required")]
        [MinLength(2, ErrorMessage = "Minimum 2 Character required"), MaxLength(30, ErrorMessage = "Maximum 30 Character Allowed")]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Last Name is Required")]
        [MinLength(2, ErrorMessage = "Minimum 2 Character required"), MaxLength(30, ErrorMessage = "Maximum 30 Character Allowed")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Email Id is Required")]
        [MinLength(2, ErrorMessage = "Minimum 2 Character required"), MaxLength(30, ErrorMessage = "Maximum 30 Character Allowed")]
        [Display(Name = "Email Id")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [MinLength(5, ErrorMessage = "Minimum 5 Character required"), MaxLength(10, ErrorMessage = "Maximum 10 Character Allowed")]
        public string Password { get; set; }


        [Display(Name ="Confirm Password")]
        [Compare("Password",ErrorMessage ="Password not matched")]
        [DataType(DataType.Password)]
        [MinLength(5, ErrorMessage = "Minimum 5 Character required"), MaxLength(10, ErrorMessage = "Maximum 10 Character Allowed")]
        public string CPassword { get; set; }


        [Required(ErrorMessage = "Age is required")]
        [Range(18,100,ErrorMessage ="Minimum 18 years required")]
        public int Age { get; set; }


        [Display(Name = "Phone No")]
        [StringLength(11)]
        [Required(ErrorMessage = "Phone No is required"), RegularExpression(@"^([0-9]{11})$", ErrorMessage = "Phone No is not valid")]
        public string PhoneNo { get; set; }



        [Display(Name = "NIC No")]
        [Required(ErrorMessage = "=NIC No is required"), RegularExpression(@"^([0-9]{13})$", ErrorMessage = "Phone No is not valid")]
        [StringLength(13)]
        public string NIC { get; set; }







    }
}
