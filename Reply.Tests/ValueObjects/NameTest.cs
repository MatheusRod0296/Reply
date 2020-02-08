using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reply.Domain.ReplyContext.ValueObjects;


namespace Reply.Tests.ValueObjects
{
    [TestClass]
    public class NameTest
    {
        [TestMethod]
        [DataRow("", "123456789012345678901234567890123456789012345678901")]
        [DataRow("123456789012345678901234567890123456789012345678901", "")]
        [DataRow("", "")]
        [DataRow("123456789012345678901234567890123456789012345678901", "123456789012345678901234567890123456789012345678901")]
        [DataRow("Ronaldo", "")]
        [DataRow("", "Fenomeno")]
        public  void ShouldReturnTrueWhenNameIsNotValid(string firstName, string lastName)
        {
            var name = new Name(firstName, lastName);          

            name.AddNotifications(name);

            Assert.IsTrue(name.Invalid);
        }

        [TestMethod]
        [DataRow("Matheus", "Rodrigues")]
        [DataRow("Ana", "Del")]
        public void ShouldReturnTrueWhenNameIsValid(string firstName, string lastName)
        {
            var name = new Name(firstName, lastName);

            Assert.IsTrue(name.Valid);
            
        }
    }
}
