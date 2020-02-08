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
        [DataRow("944.545.650-00")]
        [DataRow("000.000.000-11")]
        public void ShouldReturnNotificationWhenDocumentIsNotValid(string cpf)
        {
            var document = new Document(cpf);            
            Assert.IsTrue(document.Invalid);
        }


        [TestMethod]
        [DataRow("944.555.650-00")]
        [DataRow("000.000.001-91")]
        public void ShouldReturnNotificationWhenDocumentIsValid(string cpf)
        {
            var document = new Document(cpf);
            Assert.IsTrue(document.Valid);
        }
    }
}
