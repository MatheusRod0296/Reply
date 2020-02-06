namespace Reply.Domain.ReplyContext.Entities.Calculator
{
    public class RiskPrize : ICalculator
    {
        private decimal _riskrate;
        private decimal _veichleValue;

        public RiskPrize(decimal riskrate, decimal veichleValue)
        {
            _riskrate = riskrate;
            _veichleValue = veichleValue;


        }

        public decimal Value => Calculate();    

        public decimal Calculate()
        {
            return (_riskrate / 100) * _veichleValue;
        }
    }
}
