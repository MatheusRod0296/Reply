using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reply.Domain.ReplyContext.Entities;
using Reply.Domain.ReplyContext.ValueObjects;

namespace Reply.Tests.Entities
{
    [TestClass]
    public class InsuranceTest
    {

        [TestMethod]
        [DataRow("Matheus", "Rodrigues", "944.555.650-00",18, "Fiat", "147",  "1000.00" )]
        public void ShouldReturnTrueWhenIsValid(string firstName, string lastName, string cpf, int age, string brand, string model, string value)
        {
            decimal.TryParse(value, out decimal _value);
            var name = new Name(firstName, lastName);
            var document = new Document(cpf);
            var insured = new Insured(age, name, document);

            var vehicle = new Vehicle(brand, model, _value);
            var insurance = new Insurance(insured, vehicle);


            Assert.IsTrue(insurance.Valid);
        }


        [TestMethod]
        [DataRow("M", "atheus", "222.555.650-00", 15, "F", "147", "1000")]
        public void ShouldReturnTrueWhenNotIsValid(string firstName, string lastName, string cpf, int age, string brand, string model, string value)
        {
            decimal.TryParse(value, out decimal _value);
            var name = new Name(firstName, lastName);
            var document = new Document(cpf);
            var insured = new Insured(15, name, document);

            var vehicle = new Vehicle(brand, model, _value);
            var insurance = new Insurance(insured, vehicle);


            Assert.IsTrue(insurance.Invalid );
        }
    }
}
