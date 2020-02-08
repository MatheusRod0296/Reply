using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reply.Domain.ReplyContext.ValueObjects;

namespace Reply.Tests.ValueObjects
{
    [TestClass]
    public class DocumentTest
    {
        [TestMethod]
        [DataRow("944.545.650-00")]
        [DataRow("000.000.000-11")]
        public void ShouldReturnTrueWhenDocumentIsNotValid(string cpf)
        {
            var document = new Document(cpf);

            Assert.IsTrue(document.Invalid);
        }


        [TestMethod]
        [DataRow("944.555.650-00")]
        [DataRow("000.000.001-91")]
        public void ShouldRetunTrueWhenDocumentIsValid(string cpf)
        {
            var document = new Document(cpf);

            Assert.IsTrue(document.Valid);
        }
    }
}
