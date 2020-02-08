using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reply.Domain.ReplyContext.Entities.Calculator;

namespace Reply.Tests.Entities.Calculator
{
    [TestClass]
    public class RiskRateTest
    {

        [TestMethod]
        public void ShouldReturnTheCorrectValueOfCalculator()
        {

            var result = new RiskRate();


            Assert.AreEqual(2.5M, result.Value);
        }
    }
}
