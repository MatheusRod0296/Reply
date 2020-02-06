using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Reply.Domain.ReplyContext.ValueObjects;


namespace Reply.Tests.ValueObjects
{
    [TestClass]
    public class NameTest
    {
        [TestMethod]
        public  void ShouldReturnFourNotificationWhenNameIsNotValid()
        {
            var name = new Name("", "123456789012345678901234567890123456789012345678901");
            var name1 = new Name("123456789012345678901234567890123456789012345678901", "");

            name.AddNotifications(name1);
            
            Assert.AreEqual(true, name.Invalid);
            Assert.AreEqual(4, name.Notifications.Count);
        }

        [TestMethod]
        public void ShouldReturnnWithoutNotificationWhenNameIsValid()
        {
            var name = new Name("Matheus", "Rodrigues");

            Assert.AreEqual(true, name.Valid);
            Assert.AreEqual(0, name.Notifications.Count);
        }
    }
}
