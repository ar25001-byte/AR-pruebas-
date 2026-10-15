using Xunit;

namespace AR.StringManipulator.UnitTestAppxUnit
{
    public class StringManipulatorTests
    {
        [Fact]
        public void ReverseString_StandardWord_ReturnsReversedWord()
        {
            // Arrange
            var manipulator = new StringManipulator();
            string input = "Hola";
            string expected = "aloH";

            // Act
            string actual = manipulator.ReverseString(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReverseString_PalindromeWord_ReturnsSameWord()
        {
            // Arrange
            var manipulator = new StringManipulator();
            string input = "radar";
            string expected = "radar";

            // Act
            string actual = manipulator.ReverseString(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RemoveSpaces_SentenceWithSpaces_ReturnsStringWithoutSpaces()
        {
            // Arrange
            var manipulator = new StringManipulator();
            string input = "Hola Mundo Desde CSharp";
            string expected = "HolaMundoDesdeCSharp";

            // Act
            string actual = manipulator.RemoveSpaces(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RemoveSpaces_StringWithMultipleConsecutiveSpaces_RemovesAllSpaces()
        {
            // Arrange
            var manipulator = new StringManipulator();
            string input = "  A   R   P r u e b a s  ";
            string expected = "ARPruebas";

            // Act
            string actual = manipulator.RemoveSpaces(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReverseString_StringWithAccentsAndSpecialCharacters_InvertsCorrectly()
        {
            // Arrange
            var manipulator = new StringManipulator();
            string input = "¡Hola, Señor!";
            string expected = "!roñeS ,aloH¡";

            // Act
            string actual = manipulator.ReverseString(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RemoveSpaces_StringWithoutSpaces_ReturnsOriginalString()
        {
            // Arrange
            var manipulator = new StringManipulator();
            string input = "SinEspacios";
            string expected = "SinEspacios";

            // Act
            string actual = manipulator.RemoveSpaces(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReverseString_NullOrEmptyInput_ReturnsEmptyString()
        {
            // Arrange
            var manipulator = new StringManipulator();

            // Act & Assert
            Assert.Equal(string.Empty, manipulator.ReverseString(string.Empty));
            Assert.Equal(string.Empty, manipulator.ReverseString(null!));
        }
    }
}
