using FluentValidator;

namespace Reply.Domain.ReplyContext.Entities.Calculator
{
    public class RiskRate : ICalculator
    {
        public decimal Value { get => Calculate(); }
        public Notifiable Notifiable { get ; set ; }

        public decimal Calculate()
        {         
            return 2.5M;
        }
    }
}
