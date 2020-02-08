using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reply.Domain.ReplyContext.Entities;
using Reply.Domain.ReplyContext.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reply.Tests.Entities
{
    [TestClass]
    public class InsuranceTest
    {

        [TestMethod]
        public void ShouldReturnTrueWhenIsValid()
        {

            var name = new Name("Matheus", "Rodrigues");
            var document = new Document("944.555.650-00");
            var insured = new Insured(18, name, document);

            var vehicle = new Vehicle("Fiat", "147", 1000);
            var insurance = new Insurance(insured, vehicle);


            Assert.AreEqual(0, insurance.Notifications.Count);
        }


        [TestMethod]
        public void ShouldReturnfalseWhenNotIsValid()
        {

            var name = new Name("M", "atheus");
            var document = new Document("222.555.650-00");
            var insured = new Insured(15, name, document);

            var vehicle = new Vehicle("F", "147", 1000);
            var insurance = new Insurance(insured, vehicle);


            Assert.IsTrue( insurance.Notifications.Count > 0);
        }
    }
}
