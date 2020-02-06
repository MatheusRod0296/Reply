namespace Reply.Domain.ReplyContext.Entities.Calculator
{
    public class CommercialPrize : ICalculator
    {
        private decimal _purePrize;
        private decimal _profit;

        public CommercialPrize(decimal purePrize, decimal profit)
        {
            _purePrize = purePrize;
            _profit = profit;
        }

        public decimal Value => Calculate();

        public decimal Calculate()
        {
            return _purePrize * _profit;
        }
    }
}
