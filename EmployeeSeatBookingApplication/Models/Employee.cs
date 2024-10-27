namespace EmployeeSeatBookingApplication.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int MinimumDaysInOffice { get; set; } = 3;
    }
}
