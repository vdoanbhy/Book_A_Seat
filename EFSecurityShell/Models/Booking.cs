using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Book_A_Seat.Models
{
    public enum SpecialMeals
    {
        Vegetarian,
        Vegan,
        Seafood,
        [Display(Name = "Gluten Free")]
        GlutenFree,
        Diabetic
    }
    public class Booking
    {
        public int BookingID { get; set; }
        public int CustomerID { get; set; }
        public int FlightID { get; set; }
        [Display(Name = "Special Meals")]
        public SpecialMeals? SpecialMeals { get; set; }
        [Display(Name = "Seat Number")]
        public int SeatNumber { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Flight Flight { get; set; }
    }
}