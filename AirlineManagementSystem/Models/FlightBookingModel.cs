using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AirlineManagementSystem.Models
{
    [Table("Tbl_FlightBooking")]
    public class FlightBookingModel
    {
        [Key]
        public int FBId { get; set;}

        [Required(ErrorMessage ="From City Required")]
        [Display(Name ="From City")]
        [StringLength(40,ErrorMessage ="Max 40 character allowed")]
        public string From { get; set; }


        [Required(ErrorMessage = "To City Required")]
        [Display(Name = "To City")]
        [StringLength(40, ErrorMessage = "Max 40 character allowed")]
        public string To { get; set; }

        [Display(Name ="Departure Date")]
        [DataType(DataType.Date)]
        public DateTime DDate { get; set; }


        [Display(Name = "Departure Time")]
        [StringLength(15)]
        [DataType(DataType.Date)]
        public string DTime { get; set; }

        //one to many relation between aeroplane model and flightbooking model
        public int PlaneId { get; set; }
        public virtual AeroPlaneModel PlaneInfo { get; set; }

        [Display(Name ="Seat Type")]
        [StringLength(25)]
        public string SeatType { get; set; }
    }
}
