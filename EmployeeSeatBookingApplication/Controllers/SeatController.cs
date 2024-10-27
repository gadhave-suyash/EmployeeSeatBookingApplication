using System.Collections.Generic;
using EmployeeSeatBookingApplication.Models;

namespace EmployeeSeatBookingApplication.Controllers
{
    public class SeatController
    {
        private List<Seat> seats = new List<Seat>();

        public SeatController()
        {
            for (int i = 1; i <= 25; i++)
            {
                seats.Add(new Seat { SeatId = i, Location = $"Seat {i}" });
            }
        }

        public List<Seat> GetAllSeats()
        {
            return seats;
        }
    }
}
