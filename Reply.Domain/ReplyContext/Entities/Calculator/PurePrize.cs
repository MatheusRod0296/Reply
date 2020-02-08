namespace Reply.Domain.ReplyContext.Entities.Calculator
{
    /// <summary>
    /// Calculator class responsabile
    /// for calculate PurePrize
    /// </summary>
    public class PurePrize : ICalculator
    {
        private decimal _riskPrize;
        private decimal _safetyMargin;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="riskPrize">Value matching Risk Prize</param>
        /// <param name="SafetyMargin">value matching  safety margin</param>
        public PurePrize(decimal riskPrize, decimal safetyMargin)
        {
            _riskPrize = riskPrize;
            _safetyMargin = safetyMargin;
        }

        public decimal Value => Calculate();

        public decimal Calculate()
        {
            return _riskPrize * (1 + _safetyMargin);
        }
    }
}
