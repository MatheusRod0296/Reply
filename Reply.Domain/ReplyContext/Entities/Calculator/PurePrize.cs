namespace Reply.Domain.ReplyContext.Entities.Calculator
{
    public class PurePrize : ICalculator
    {
        private decimal _riskPrize;
        private decimal _margemSegurity;
        public PurePrize(decimal riskPrize, decimal margemSegurity)
        {
            _riskPrize = riskPrize;
            _margemSegurity = margemSegurity;
        }

        public decimal Value => Calculate();

        public decimal Calculate()
        {
            return _riskPrize * (1 + _margemSegurity);
        }
    }
}
