using Reply.Domain.ReplyContext.Entities.Calculator;
using Reply.Shared.Entities;

namespace Reply.Domain.ReplyContext.Entities
{
    public class Insurance : Entity
    {
        const decimal margemSegurity = 0.03M;
        const decimal profit = 0.05M;

        public Insurance(Insured insured, Vehicle vehicle)
        {
            Insured = insured;
            Vehicle = vehicle;

            AddNotifications(Insured, Vehicle); 
            
        }

        public Insured Insured { get; private set; }

        public Vehicle Vehicle { get; private set; }

        public ICalculator RiskRate { get => new RiskRate(); }
        public ICalculator RiskPrize { get => new RiskPrize(RiskRate.Value, Vehicle.Value); }
        public ICalculator PurePrize { get => new PurePrize(RiskPrize.Value, margemSegurity); }
        public ICalculator CommercialPrize { get => new CommercialPrize(PurePrize.Value, profit); }

    }


}
