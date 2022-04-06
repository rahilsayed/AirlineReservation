using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirlineReservationSystem.Entities
{

    [Table("Flights")]
    public class Flight
    {
        //FlightId 
        [Key]
        [Column(TypeName = "int")]
        public int FlightID { get; set; }

        // Date when the Flight was added to the fleet
        [Required]
        [Column(TypeName = "Date")]
        public DateTime LaunchDate { get; set; }

        //SOurce Airport
        [Required]
        [StringLength(10)]
        [Column(TypeName = "varchar")]
        public string Origin { get; set; }


        //destination airport
        [Required]
        [StringLength(10)]
        [Column(TypeName = "varchar")]
        public string Destination { get; set; }


        //departure time of flight from source
        [Required]
        [Column(TypeName = "Date")]
        public DateTime DeptTime { get; set; }

        //arrival time of flight at destination
        [Required]
        [Column(TypeName = "Date")]
        public DateTime ArrivalTime { get; set; }

        //no of seats passenger wants to book
        [Required]
        [Column(TypeName = "int")]
        public int NoOfSeats { get; set; }

        //cost of a trip
        [Required]
        [Column(TypeName = "decimal")]
        public float Fare { get; set; }

    }
}
