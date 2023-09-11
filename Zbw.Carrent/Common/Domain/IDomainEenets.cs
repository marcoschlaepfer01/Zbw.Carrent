namespace Zbw.Carrent.Common.Domain
{
    public interface IDomainEenet
    {
        Guid EvetnId { get; }
        DateTimeOffset EvetnDate { get; }
    }
}
