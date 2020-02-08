using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reply.Domain.ReplyContext.Entities;
using Reply.Domain.ReplyContext.ValueObjects;

namespace Reply.Tests.Entities
{
    //TODO: Receber os parametros via metodos para testar mais possibilidade
    [TestClass]
    public class InsuredTest
    {
        private Name _name = new Name("Matheus", "Rodrigues");
        private Document _document = new Document("944.555.650-00");

        [TestMethod]
        public void ShouldReturnNotificationWhenAgeIsUnderthan18()
        {            
            var insured = new Insured(17, _name, _document);
            Assert.AreEqual(true, insured.Invalid);
        }


        [TestMethod]
        public void ShouldReturnNotificationWhenAgeIsOverthan120()
        {
            var insured = new Insured(121, _name, _document);
            Assert.AreEqual(true, insured.Invalid);
        }

        [TestMethod]
        public void ShouldReturnNotificationWhenIsValid()
        {        
            var insured = new Insured(18, _name, _document);
            Assert.AreEqual(true, insured.Valid);
        }
    }
}
