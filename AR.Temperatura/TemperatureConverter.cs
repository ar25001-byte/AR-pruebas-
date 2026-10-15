namespace AR.Temperatura
{
    public class TemperatureConverter
    {
        /// <summary>
        /// Convierte grados Celsius a Fahrenheit.
        /// Fórmula: (celsius * 9 / 5) + 32
        /// </summary>
        /// <param name="celsius">Temperatura en grados Celsius.</param>
        /// <returns>Temperatura convertida en grados Fahrenheit.</returns>
        public double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9.0 / 5.0) + 32.0;
        }

        /// <summary>
        /// Convierte grados Fahrenheit a Celsius.
        /// Fórmula: (fahrenheit - 32) * 5 / 9
        /// </summary>
        /// <param name="fahrenheit">Temperatura en grados Fahrenheit.</param>
        /// <returns>Temperatura convertida en grados Celsius.</returns>
        public double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32.0) * 5.0 / 9.0;
        }
    }
}
