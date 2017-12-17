using NUnit.Framework;

namespace MystemSharp.UnitTests
{
    [TestFixture]
    public class FormsTests
    {
        [Test]
        public void Count_NativeCall_DoesNotThrowException()
        {
            // Arrange
            var analyses = new Analyses("слово");
            
            // Act
            var lemma = analyses[0];
            var forms = lemma.Forms;

            // Assert
            Assert.DoesNotThrow(() => { var _ = forms.Count; } );
        }

        [Test]
        public void Index_NativeCall_DoesNotThrowException()
        {
            // Arrange
            var analyses = new Analyses("слово");
            var lemma = analyses[0];
            var forms = lemma.Forms;

            // Act

            // Assert
            Assert.DoesNotThrow(() => { var _ = forms[0]; });
        }
    }
}