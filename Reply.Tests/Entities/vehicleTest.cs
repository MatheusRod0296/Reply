using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reply.Domain.ReplyContext.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reply.Tests.Entities
{
    [TestClass]
    public class vehicleTest
    {
        [TestMethod]
        public void ShouldReturnNotificationWhenMinimalItensIsNotValid()
        {
            var vehicle = new Vehicle("ab", "ab", "0");          

            Assert.AreEqual(true, vehicle.Invalid);
            Assert.AreEqual(3, vehicle.Notifications.Count);
        }

        [TestMethod]
        public void ShouldReturnNotificationWhenMaxItensIsNotValid()
        {
         
            var vehicle = new Vehicle("qwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopuiop",
                "qwertyuiopqwqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopertyuiopqwertyuiopqwertyuiopqwertyuiop",
                "99999999999999999.99M");         

            Assert.AreEqual(true, vehicle.Invalid);
            Assert.AreEqual(3, vehicle.Notifications.Count);
        }

        [TestMethod]
        public void ShouldReturnNotificationWhenValid()
        {

            var vehicle = new Vehicle("Gurgel", "Ipanema", "5000.00M");

            Assert.AreEqual(true, vehicle.Valid);
            Assert.AreEqual(0, vehicle.Notifications.Count);
        }
    }
}
