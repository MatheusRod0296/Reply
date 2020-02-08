using Reply.Domain.ReplyContext.Entities.Calculator;
using Reply.Shared.Entities;

namespace Reply.Domain.ReplyContext.Entities
{
    /// <summary>
    /// Main class of context.
    /// Stored all values about a insurance
    /// </summary>
    public class Insurance : Entity
    {
        const decimal _safetyMargin = 0.03M;
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
        public ICalculator PurePrize { get => new PurePrize(RiskPrize.Value, _safetyMargin); }
        public ICalculator CommercialPrize { get => new CommercialPrize(PurePrize.Value, profit); }

  

    }


}
