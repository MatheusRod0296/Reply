using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reply.Domain.ReplyContext.Entities.Calculator;

namespace Reply.Tests.Entities.Calculator
{
    [TestClass]
    public class CommercialPrizeTest
    {
        /// <summary>
        /// Test Calculate Comerical Prize
        /// </summary>
        /// <param name="purePrize"></param>
        /// <param name="profit"></param>
        [TestMethod]
       
        public void ShouldReturnTheCorrectValueOfCalculator()
        {            
            var result = new CommercialPrize(10, 10);
          

            Assert.AreEqual(110, result.Value);           
        }
    }
}
