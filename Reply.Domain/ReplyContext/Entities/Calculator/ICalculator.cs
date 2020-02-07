namespace Reply.Domain.ReplyContext.Entities.Calculator
{
    /// <summary>
    /// Interface with methods and values
    /// necessary for a calculation
    /// </summary>
    public interface ICalculator
    {
        decimal Value { get; }       

        decimal Calculate();
    }
}
