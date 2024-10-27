using System;

namespace EmployeeSeatBookingApplication.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int EmployeeId { get; set; }
        public int SeatId { get; set; }
        public DateTime Date { get; set; }
    }
}
