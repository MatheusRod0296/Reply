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
        //Possibilidade de vários teste usando DataRow
        [TestMethod]
        [DataRow("", "123456789012345678901234567890123456789012345678901")]
        [DataRow("123456789012345678901234567890123456789012345678901", "")]
        [DataRow("", "")]
        [DataRow("123456789012345678901234567890123456789012345678901", "123456789012345678901234567890123456789012345678901")]
        [DataRow("Ronaldo", "")]
        [DataRow("", "Fenomeno")]
        public  void ShouldReturnFourNotificationWhenNameIsNotValid(string firstName, string lastName)
        {
            var name = new Name(firstName, lastName);
            // Não se utilizar mais de um Assert em teste, e um má prática, caso o objeto seja inválido
            // então está certo o teste, só testa todos os cenários
            Assert.AreEqual(true, name.Invalid);
        }

        [TestMethod]
        [DataRow("Matheus", "Rodrigues")]
        //Teste com o limite de carácter e o mínimo de carácter possível
        public void ShouldReturnnWithoutNotificationWhenNameIsValid(string firstName, string lastName)
        {
            var name = new Name(firstName, lastName);
            Assert.AreEqual(true, name.Valid);
        }
    }
}
