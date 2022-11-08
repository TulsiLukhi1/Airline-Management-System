using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirlineManagementSystem.Models
{
    [Table("Tbl_FlightDetails")]
    public class FlightDetailsModel
    {
        [Key]
        public int ResID { get; set; }

        [Required(ErrorMessage = "Please enter From City field"), Display(Name = "From City:")]
        public string ResFrom { get; set; }

        [Required(ErrorMessage = "Please enter To City Field"), Display(Name = "To City")]
        public string ResTo { get; set; }

        [Required(ErrorMessage = "Departure Date is Required"), Display(Name = "Departure Date")]
        public string ResDepDate { get; set; }

        [Required(ErrorMessage = "Flight Time is Required"), Display(Name = "Flight Time")]
        public string ResTime { get; set; }

        [Required, Display(Name = "Plane No")]
        public int PlaneId { get; set; }
        public virtual AeroPlaneModel plane_tbls { get; set; }


        [Required, Display(Name = "Seat Available")]
        public int PlaneSeat { get; set; }

        [Required, Display(Name = "Price")]
        public float ResTicketPrice { get; set; }

        [Required, Display(Name = "Plane Type")]
        public string ResPlaneType { get; set; }

        public virtual ICollection<FlightBookingModel> tblFlightBookings { get; set; }
    }
}
