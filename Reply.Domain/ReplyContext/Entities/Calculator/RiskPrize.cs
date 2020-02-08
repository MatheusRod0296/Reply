namespace Reply.Domain.ReplyContext.Entities.Calculator
{
    /// <summary>
    /// Calculator class responsabile
    /// for calculate RiskPrize
    /// </summary>
    public class RiskPrize : ICalculator
    {
        private decimal _riskrate;
        private decimal _veichleValue;        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="riskrate">Value of Risk Rate</param>
        /// <param name="veichleValue">Value of Vehicle</param>
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
