using System.Collections.Generic;
using EmployeeSeatBookingApplication.Models;

namespace EmployeeSeatBookingApplication.Controllers
{
    public class BookingController
    {
        private List<Booking> bookings = new List<Booking>();

        public void AddBooking(Booking booking)
        {
            bookings.Add(booking);
        }

        public List<Booking> GetAllBookings()
        {
            return bookings;
        }
    }
}
