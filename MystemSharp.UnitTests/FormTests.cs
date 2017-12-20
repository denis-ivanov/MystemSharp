using NUnit.Framework;

namespace MystemSharp.UnitTests
{
    [TestFixture]
    public class FormTests
    {
        [Test]
        public void Text_NativeCall_DoesNotThrowException()
        {
            // Arrange
            var analyses = new Analyses("слово");
            var lemma = analyses[0];
            var forms = lemma.Forms;
            var form = forms[0];

            // Act

            // Assert
            Assert.DoesNotThrow(() => { var _ = form.Text; });
        }
    }
}
