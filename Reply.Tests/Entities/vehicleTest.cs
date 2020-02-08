using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reply.Domain.ReplyContext.Entities;

namespace Reply.Tests.Entities
{
    //TODO: Receber os parametros via metodos para testar mais possibilidade
    [TestClass]
    public class vehicleTest
    {
        [TestMethod]
        public void ShouldReturnNotificationWhenMinimalItensIsNotValid()
        {
            var vehicle = new Vehicle("ab", "ab", 0);          
            Assert.AreEqual(true, vehicle.Invalid);
        }

        [TestMethod]
        public void ShouldReturnNotificationWhenMaxItensIsNotValid()
        {
            
            var vehicle = new Vehicle("qwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopuiop",
                "qwertyuiopqwqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopertyuiopqwertyuiopqwertyuiopqwertyuiop",
                99999999999999999);         

            Assert.AreEqual(true, vehicle.Invalid);
        }

        [TestMethod]
        public void ShouldReturnNotificationWhenValid()
        {
            var vehicle = new Vehicle("Gurgel", "Ipanema", 5000);
            Assert.AreEqual(true, vehicle.Valid);
        }
    }
}
