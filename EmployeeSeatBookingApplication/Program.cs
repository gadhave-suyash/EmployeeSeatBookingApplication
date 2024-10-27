using EmployeeSeatBookingApplication.Controllers;
using EmployeeSeatBookingApplication.Models;
using System;

namespace EmployeeSeatBookingApplication
{
    class Program
    {
        static EmployeeController employeeController = new EmployeeController();
        static SeatController seatController = new SeatController();
        static BookingController bookingController = new BookingController();

        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Office Seat Booking System");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. View All Employees");
                Console.WriteLine("3. View All Seats");
                Console.WriteLine("4. Book Seat");
                Console.WriteLine("5. View All Bookings");
                Console.WriteLine("6. Exit");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddEmployee();
                        break;
                    case "2":
                        ViewAllEmployees();
                        break;
                    case "3":
                        ViewAllSeats();
                        break;
                    case "4":
                        BookSeat();
                        break;
                    case "5":
                        ViewAllBookings();
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddEmployee()
        {
            Employee employee = new Employee();
            Console.Write("Enter Employee ID: ");
            employee.EmployeeId = int.Parse(Console.ReadLine());
            Console.Write("Enter Name: ");
            employee.Name = Console.ReadLine();
            Console.Write("Enter Department: ");
            employee.Department = Console.ReadLine();

            employeeController.AddEmployee(employee);
            Console.WriteLine("Employee added successfully.\n");
        }

        static void ViewAllEmployees()
        {
            var employees = employeeController.GetAllEmployees();
            Console.WriteLine("Employees:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"ID: {employee.EmployeeId}, Name: {employee.Name}, Department: {employee.Department}");
            }
            Console.WriteLine();
        }

        static void ViewAllSeats()
        {
            var seats = seatController.GetAllSeats();
            Console.WriteLine("Seats:");
            foreach (var seat in seats)
            {
                Console.WriteLine($"ID: {seat.SeatId}, Location: {seat.Location}");
            }
            Console.WriteLine();
        }

        static void BookSeat()
        {
            Booking booking = new Booking();
            Console.Write("Enter Booking ID: ");
            booking.BookingId = int.Parse(Console.ReadLine());
            Console.Write("Enter Employee ID: ");
            booking.EmployeeId = int.Parse(Console.ReadLine());
            Console.Write("Enter Seat ID: ");
            booking.SeatId = int.Parse(Console.ReadLine());
            Console.Write("Enter Date (yyyy-MM-dd): ");
            booking.Date = DateTime.Parse(Console.ReadLine());

            bookingController.AddBooking(booking);
            Console.WriteLine("Seat booked successfully.\n");
        }

        static void ViewAllBookings()
        {
            var bookings = bookingController.GetAllBookings();
            Console.WriteLine("Bookings:");
            foreach (var booking in bookings)
            {
                Console.WriteLine($"BookingID: {booking.BookingId}, EmployeeID: {booking.EmployeeId}, SeatID: {booking.SeatId}, Date: {booking.Date.ToShortDateString()}");
            }
            Console.WriteLine();
        }
    }
}
