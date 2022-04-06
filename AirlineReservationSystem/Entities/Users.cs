using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AirlineReservationSystem.Entities
{
    //User Class to store the login details of admins
    [Table("Users")]
    public class User
    {
        [Key] // for initialising as PK
        [Column(TypeName = "int")]
        public int Id { get; set; } //properties for ID

        //Username for admin login
        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string Username { get; set; }


        //passowrd for admin login
        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string Password { get; set; }

    }
}