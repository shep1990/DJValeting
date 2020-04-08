using DJValeting.Domain.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DJValeting.Models
{
    public class BookingViewModel
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please select a booking date")]
        public DateTime? BookingDate { get; set; }
        [Required(ErrorMessage = "Please select your flexibility")]
        public FlexibilityEnum? Flexibility { get; set; }
        [Required(ErrorMessage = "Please select your vehicle size")]
        public CarSizeEnum? VehicleSize { get; set; }
        [Required(ErrorMessage = "Please enter your contact number")]
        public string ContactNumber { get; set; }
        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmailAddress { get; set; }
    }
}
