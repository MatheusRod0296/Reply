namespace Reply.Domain.ReplyContext.Entities.Calculator
{
    /// <summary>
    /// Calculator class responsabile
    /// for calculate Commercial Prize
    /// </summary>
    public class CommercialPrize : ICalculator
    {
        private decimal _purePrize;
        private decimal _profit;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="purePrize">Value matching a pure Prize</param>
        /// <param name="profit">value matching a profit</param>
        public CommercialPrize(decimal purePrize, decimal profit)
        {
            _purePrize = purePrize;
            _profit = profit;
        }

        public decimal Value => Calculate();     

        public decimal Calculate()
        {
            return _purePrize + (_purePrize * _profit);
        }


    }
}
