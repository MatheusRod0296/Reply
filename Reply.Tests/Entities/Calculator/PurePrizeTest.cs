using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reply.Domain.ReplyContext.Entities.Calculator;

namespace Reply.Tests.Entities.Calculator
{
    [TestClass]
    public class PurePrizeTest
    {
     
        [TestMethod]
       
        public void ShouldReturnTheCorrectValueOfCalculator()
        {

            var result = new PurePrize(10, 9);


            Assert.AreEqual(100, result.Value);
        }
    }
}
