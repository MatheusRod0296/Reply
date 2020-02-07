using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reply.Domain.ReplyContext.Entities.Calculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reply.Tests.Entities.Calculator
{
    [TestClass]
    public class CommercialPrizeTest
    {
        [TestMethod]
        public void ShouldReturnTheCorrectValueOfCalculator()
        {

            var result = new CommercialPrize(10 , 10);
          

            Assert.AreEqual(110, result.Value);           
        }
    }
}
