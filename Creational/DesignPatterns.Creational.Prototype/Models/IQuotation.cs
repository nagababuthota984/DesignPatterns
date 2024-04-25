namespace DesignPatterns.Creational.Prototype.Models
{
    public interface IQuotation : ICloneable
    {
        int Id { get; }
        string Code { get; }
        decimal AmountPayable { get; }
        DateTime ValidTill { get; }
    }

    public interface IQuoteService
    {
        IQuotation Create(int id, string code, decimal amountPayable, DateTime validTill);
    }
}
