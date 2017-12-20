using NUnit.Framework;

namespace MystemSharp.UnitTests
{
    [TestFixture]
    public class LemmaTests
    {
        [Test]
        public void Text_NativeCall_ShouldNotBeEmpty()
        {
            // Arrange
            var analyses = new Analyses("слово");
            
            // Act
            var lemma = analyses[0];
            var text = lemma.Text;

            // Assert
            Assert.That(text, Is.Not.Null.Or.Empty);
        }

        [Test]
        public void Form_NativeCall_ShouldNotBeEmpty()
        {
            // Arrange
            var analyses = new Analyses("слово");
            
            // Act
            var lemma = analyses[0];
            var form = lemma.Form;

            // Assert
            Assert.That(form, Is.Not.Null.Or.Empty);
        }
        
        [Test]
        public void Quality_NativeCall_ShouldReturnQualityWithDictionaryFlag()
        {
            // Arrange
            var analyses = new Analyses("слово");
            
            // Act
            var lemma = analyses[0];
            var quality = lemma.Quality;

            // Assert
            Assert.That(quality.HasFlag(Quality.Dictionary));
        }

        [Test]
        public void StemGram_NativeCall_ShouldReturnNonEmptyString()
        {
            // Arrange
            var analyses = new Analyses("слово");
            
            // Act
            var lemma = analyses[0];
            var stemGram = lemma.StemGram;

            // Assert
            Assert.That(stemGram, Is.Not.Null.Or.Empty);
        }

        [Test]
        public void FlexGram_NativeCall_DoesNotThrowException()
        {
            // Arrange
            var analyses = new Analyses("слово");
            
            // Act
            var lemma = analyses[0];

            // Assert
            Assert.DoesNotThrow(() =>
            {
                var _ = lemma.FlexGram;
            });
        }

        [Test]
        public void FlexLength_NativeCall_DoesNotThrowException()
        {
            // Arrange
            var analyses = new Analyses("слово");
            
            // Act
            var lemma = analyses[0];

            // Assert
            Assert.DoesNotThrow(() => { var _ = lemma.FlexLength; });
        }

        [Test]
        public void RuleId_NativeCall_DoesNotThrowException()
        {
            // Arranga
            var analyses = new Analyses("слово");
            
            // Act
            var lemma = analyses[0];

            // Assert
            Assert.DoesNotThrow(() => { var _ = lemma.RuleId; });
        }
    }
}