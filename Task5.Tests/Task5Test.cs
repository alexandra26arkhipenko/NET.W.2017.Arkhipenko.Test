using System;
using Moq;
using NUnit.Framework;
using Task5.Solution;

namespace Task5.Tests
{
    [TestFixture]
    public class Task5Test
    {
        [Test]
        public void BoldTextCallVisitor_VisitMethod()
        {
            var converterMock = new Mock<IConverter>();
            var boldText = new BoldText { Text = "Some bold text" };

            boldText.Converter(converterMock.Object);
            converterMock.Verify(converter => converter.ConvertBoldText(It.Is<string>(text => string.Equals(text, boldText.Text, StringComparison.Ordinal))), Times.Once);
        }

        [Test]
        public void HyperlinkCallVisitor_VisitMethod()
        {
            var converterMock = new Mock<IConverter>();
            var hyperlink = new Hyperlink { Text = "google.com", Url = "https://www.google.by/" };

            hyperlink.Converter(converterMock.Object);
            converterMock.Verify(converter => converter.ConvertHyperlink(It.Is<string>(text => string.Equals(text, hyperlink.Text, StringComparison.Ordinal)),
                It.Is<string>(url=> string.Equals(url, hyperlink.Url, StringComparison.Ordinal))), Times.Once);

        }
        [Test]
        public void PlainTextCallVisitor_VisitMethod()
        {
            var visitorMock = new Mock<IConverter>();
            var plainText = new PlainText { Text = "Some plain text" };

            plainText.Converter(visitorMock.Object);

            visitorMock.Verify(visitor => visitor.ConvertPlainText(It.Is<string>(text => string.Equals(text, plainText.Text, StringComparison.Ordinal))), Times.Once);
        }
    }
}
