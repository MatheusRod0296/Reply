using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reply.Domain.ReplyContext.Entities.Calculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reply.Tests.Entities.Calculator
{
    [TestClass]
    public class RiskPrizeTest
    {
        

        [TestMethod]
        public void ShouldReturnTheCorrectValueOfCalculator()
        {

            var result = new RiskPrize(100, 10000);


            Assert.AreEqual(10000, result.Value);
        }
    }
}
