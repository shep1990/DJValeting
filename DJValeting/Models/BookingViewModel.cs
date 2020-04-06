using DJValeting.Domain.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DJValeting.Models
{
    public class BookingViewModel
    {
        public String Name { get; set; }

        public DateTime BookingDate { get; set; }

        public FlexibilityEnum Flexibility { get; set; }

        public CarSizeEnum VehicleSize { get; set; }

        public string ContactNumber { get; set; }

        public string EmailAddress { get; set; }
    }
}
