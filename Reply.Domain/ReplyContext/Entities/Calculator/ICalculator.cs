namespace Reply.Domain.ReplyContext.Entities.Calculator
{
    public interface ICalculator
    {
        decimal Value { get; }       

       decimal Calculate();
    }
}
