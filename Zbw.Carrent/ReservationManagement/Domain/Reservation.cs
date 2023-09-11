namespace Zbw.Carrent.ReservationManagement.Domain
{
    public class Reservation
    {
        public Reservation(uint durationDays, decimal totalCost)
        {
            Id = Guid.NewGuid();
            DurationDays = durationDays;
            TotalCost = totalCost;
        }

        public Guid Id { get; set; }
        public uint DurationDays { get; set; }
        public decimal TotalCost { get; set; }
    }
}
