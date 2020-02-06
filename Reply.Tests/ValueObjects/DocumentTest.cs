using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reply.Domain.ReplyContext.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reply.Tests.ValueObjects
{
    [TestClass]
    public class DocumentTest
    {
        [TestMethod]
        public void ShouldReturnNotificationWhenDocumentIsNotValid()
        {
            var document = new Document("12345678911");            

            Assert.AreEqual(true, document.Invalid);
            Assert.IsTrue( document.Notifications.Count > 0);
        }


        [TestMethod]
        public void ShouldReturnNotificationWhenDocumentIsValid()
        {
            var document = new Document("944.555.650-00");

            Assert.AreEqual(true, document.Valid);
            Assert.AreEqual( 0, document.Notifications.Count);
        }
    }
}
