namespace CarRentalManagement.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        public string? DrivingLicense { get; set; }
        public string? CardNumber { get; set; }
        public string? CVV { get; set; }
        public string? EmailAddress { get; set; }
        public string? Name { get; set; }
        public List<Booking>? Bookings { get; set; }
    }

}