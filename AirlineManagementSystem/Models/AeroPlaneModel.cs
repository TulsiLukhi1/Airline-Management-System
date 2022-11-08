using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirlineManagementSystem.Models
{
    [Table("Tbl_AeroPlane")]
    public class AeroPlaneModel
    {
        [Key]
        public int PlaneId { get; set; }

        [Required(ErrorMessage = "Aero Name is Required")]
        [MinLength(3, ErrorMessage = "Minimum 3 Character required"), MaxLength(30, ErrorMessage = "Maximum 30 Character Allowed")]
        [Display(Name = "Aeroplane Name")]
        public string APlaneName { get; set; }


        [Required(ErrorMessage = "Capacity required")]
        [Display(Name = "Seating Capacity")]
        public int SeatingCapacity { set; get; }


        [Required(ErrorMessage = "Price required")]
        public int Price { set; get; }




    }
}
