using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AR.Temperatura.UnitTestMSTest
{
    [TestClass]
    public class TemperatureConverterTests
    {
        [TestMethod]
        public void CelsiusToFahrenheit_ZeroCelsius_ReturnsThirtyTwoFahrenheit()
        {
            // Arrange
            var converter = new TemperatureConverter();
            double celsius = 0.0;
            double expected = 32.0;

            // Act
            double actual = converter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(expected, actual, 0.001, "0°C debe equivaler a 32°F");
        }

        [TestMethod]
        public void CelsiusToFahrenheit_BoilingPoint_ReturnsTwoHundredTwelveFahrenheit()
        {
            // Arrange
            var converter = new TemperatureConverter();
            double celsius = 100.0;
            double expected = 212.0;

            // Act
            double actual = converter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(expected, actual, 0.001, "100°C debe equivaler a 212°F");
        }

        [TestMethod]
        public void FahrenheitToCelsius_FreezingPoint_ReturnsZeroCelsius()
        {
            // Arrange
            var converter = new TemperatureConverter();
            double fahrenheit = 32.0;
            double expected = 0.0;

            // Act
            double actual = converter.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.AreEqual(expected, actual, 0.001, "32°F debe equivaler a 0°C");
        }

        [TestMethod]
        public void FahrenheitToCelsius_BoilingPoint_ReturnsOneHundredCelsius()
        {
            // Arrange
            var converter = new TemperatureConverter();
            double fahrenheit = 212.0;
            double expected = 100.0;

            // Act
            double actual = converter.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.AreEqual(expected, actual, 0.001, "212°F debe equivaler a 100°C");
        }

        [TestMethod]
        public void CelsiusAndFahrenheit_MinusFortyDegrees_ReturnsEqualValues()
        {
            // Arrange
            var converter = new TemperatureConverter();
            double input = -40.0;
            double expected = -40.0;

            // Act
            double fahrenheitResult = converter.CelsiusToFahrenheit(input);
            double celsiusResult = converter.FahrenheitToCelsius(input);

            // Assert
            Assert.AreEqual(expected, fahrenheitResult, 0.001, "-40°C debe ser -40°F");
            Assert.AreEqual(expected, celsiusResult, 0.001, "-40°F debe ser -40°C");
        }

        [TestMethod]
        public void CelsiusToFahrenheit_AbsoluteZero_ReturnsMinusFourHundredFiftyNinePointSixtySeven()
        {
            // Arrange
            var converter = new TemperatureConverter();
            double celsius = -273.15;
            double expected = -459.67;

            // Act
            double actual = converter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(expected, actual, 0.01, "-273.15°C debe equivaler a -459.67°F");
        }
    }
}
