using System.ComponentModel.DataAnnotations;

namespace FlightManagementAPI.Models
{
    public class Flight
    {
        public Flight()
        {
            FlightNumber = "";
            DepartureLocation = "";
            ArrivalLocation = "";
            AircraftType = "";
        }
        public int Id { get; set; }

        [Required(ErrorMessage = "Flight number is required")]
        public string FlightNumber { get; set; }

        [Required(ErrorMessage = "Departure date is required")]
        [FutureDate(ErrorMessage = "Departure date must be in the future")]
        public DateTime DepartureDate { get; set; }

        [Required(ErrorMessage = "Departure location is required")]
        public string DepartureLocation { get; set; }

        [Required(ErrorMessage = "Arrival location is required")]
        public string ArrivalLocation { get; set; }

        public string AircraftType { get; set; }
    }

    // Walidator dla dat w przyszłości
    public class FutureDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime date = (DateTime)value;
            return date >= DateTime.Today;
        }
    }
}
