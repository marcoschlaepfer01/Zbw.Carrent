namespace Zbw.Carrent.RentalContractManagement.Domain
{
    public class RentalContract
    {
        public RentalContract(uint durationDays, decimal totalCost)
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
