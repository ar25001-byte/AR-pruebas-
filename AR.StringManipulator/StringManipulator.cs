using System;

namespace AR.StringManipulator
{
    public class StringManipulator
    {
        /// <summary>
        /// Invierte una cadena de texto.
        /// </summary>
        /// <param name="input">Cadena de entrada a invertir.</param>
        /// <returns>Cadena de texto invertida.</returns>
        public string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input ?? string.Empty;
            }

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        /// <summary>
        /// Remueve todos los espacios en blanco de una cadena de texto.
        /// </summary>
        /// <param name="input">Cadena de entrada con posibles espacios.</param>
        /// <returns>Cadena de texto sin espacios en blanco.</returns>
        public string RemoveSpaces(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input ?? string.Empty;
            }

            return input.Replace(" ", string.Empty);
        }
    }
}
