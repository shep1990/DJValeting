using System;
using System.Collections.Generic;
using System.Text;

namespace DJValeting.Domain.Data.Entities
{
    public class DJValetingBookingEntity
    {
        public Guid Id { get; set; }

        public String Name { get; set; }

        public DateTime BookingDate { get; set; }

        public int Flexibility { get; set; }

        public int VehicleSize { get; set; }

        public string ContactNumber { get; set; }

        public string EmailAddress { get; set; }
    }
}
