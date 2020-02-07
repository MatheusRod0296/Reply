namespace Reply.Domain.ReplyContext.Entities.Calculator
{
    /// <summary>
    /// Calculator class responsabile
    /// for calculate PurePrize
    /// </summary>
    public class PurePrize : ICalculator
    {
        private decimal _riskPrize;
        private decimal _margemSegurity;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="riskPrize">Valor correnpondente ao premio de risco</param>
        /// <param name="margemSegurity">valor correspondente a margemde segurança</param>
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
