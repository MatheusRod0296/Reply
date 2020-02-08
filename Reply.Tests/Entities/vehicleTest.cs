using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reply.Domain.ReplyContext.Entities;

namespace Reply.Tests.Entities
{
    [TestClass]
    public class vehicleTest
    {
        [TestMethod]
        [DataRow("ab", "ab", "0")]
        [DataRow("qwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopuiop",
                "qwertyuiopqwqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopertyuiopqwertyuiopqwertyuiopqwertyuiop",
                "99999999999999999.99")]
        public void ShouldReturnTrueWhenIsNotValid(string brand, string model, string value)
        {
            decimal.TryParse(value, out decimal _value);
            var vehicle = new Vehicle(brand, model, _value);          

            Assert.IsTrue( vehicle.Invalid);
          
        }       

        [TestMethod]
        [DataRow("Gurgel", "Ipanema", "10000")]
        public void ShouldReturnTrueWhenValid(string brand, string model, string value)
        {
            decimal.TryParse(value, out decimal _value);
            var vehicle = new Vehicle(brand, model, _value);

            Assert.IsTrue(vehicle.Valid);
        }
    }
}
