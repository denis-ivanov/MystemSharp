using NUnit.Framework;

namespace MystemSharp.UnitTests
{
    [TestFixture]
    public class AnalysesTests
    {
        [Test]
        public void Ctor_NativeCall_DoesNotThrowException()
        {
            // Arrange
            
            // Act
            
            // Assert
            Assert.DoesNotThrow(() => new Analyses("слово"));
        }

        [Test]
        public void Count_NativeCall_ShouldReturnGreaterThanZero()
        {
            // Arrange
            var analyses = new Analyses("слово");
            
            // Act
            var count = analyses.Count;

            // Assert
            Assert.That(count, Is.GreaterThan(0));
        }
    }
}
