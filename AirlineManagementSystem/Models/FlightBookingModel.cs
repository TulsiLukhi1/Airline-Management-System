using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirlineManagementSystem.Models
{
    [Table("Tbl_FlightBooking")]
    public class FlightBookingModel
    {
        [Key]
        public int Bid { get; set; }

        [Required(ErrorMessage = "Name Required")]
        [Display(Name = "Customer Name")]
        public string bCusName { get; set; }


        [Required(ErrorMessage = "Address Required")]
        [Display(Name = "Customer Address")]
        public string bCusAddress { get; set; }

        [Required]
        [Display(Name = "Customer Email")]
        public string bCusEmail { get; set; }


        [Display(Name = "No of Seats")]
        [Required]
        public string bCusSeats { get; set; }


        [Display(Name = "Phone Number")]
        [Required]
        public string bCusPhoneNum { get; set; }

        [Required, Display(Name = "CNIC")]
        public string bCusCnic { get; set; }

        //one to many relation between TicketReserve model and flightbooking model
        public int ResId { get; set; }
        public virtual FlightDetailsModel fligthDetailsModel { get; set; }


    }
}
