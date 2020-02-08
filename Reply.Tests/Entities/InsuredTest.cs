using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reply.Domain.ReplyContext.Entities;
using Reply.Domain.ReplyContext.ValueObjects;

namespace Reply.Tests.Entities
{
    [TestClass]
    public class InsuredTest
    {
        private Name _name = new Name("Matheus", "Rodrigues");
        private Document _document = new Document("944.555.650-00");

        [TestMethod]
        [DataRow(17)]
        [DataRow(121)]
        public void ShouldReturnTrueWhenNotIsValid(int Age)
        {

            var insured = new Insured(Age, _name, _document);

            Assert.IsTrue(insured.Invalid);
        }


        [TestMethod]
        [DataRow(120)]
        [DataRow(18)]
        public void ShouldReturnTrueWhenIsValid(int age)
        {

            var insured = new Insured(age, _name, _document);

            Assert.IsTrue(insured.Valid);

        }


    }
}
