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
        [Required]
        public String Name { get; set; }
        [Required]
        public DateTime BookingDate { get; set; }
        [Required]
        public FlexibilityEnum Flexibility { get; set; }
        [Required]
        public CarSizeEnum VehicleSize { get; set; }
        [Required]
        public string ContactNumber { get; set; }
        [Required]
        public string EmailAddress { get; set; }
    }
}
