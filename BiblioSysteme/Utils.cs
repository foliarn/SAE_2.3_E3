using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace BiblioSysteme
{
    public class Utils
    {
        // Caractères hexadécimaux valides (0-9, A-F, a-f)
        private static readonly Regex HexPattern = new Regex(@"^[0-9A-Fa-f\s]*$", RegexOptions.Compiled);

        /// <summary>
        /// Valide si une chaîne hexadécimale contient uniquement des caractères hexadécimaux valides et des espaces.
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        public static bool IsValidHexString(string hexString)
        {
            if (string.IsNullOrEmpty(hexString))
            {
                return false;
            }
            // Vérifier si la chaîne ne contient que des caractères hexadécimaux valides
            return HexPattern.IsMatch(hexString);
        }

        /// <summary>
        /// Nettoie une chaine de caractères en supprimant les espaces et en normalisant la casse.
        /// </summary>
        /// <param name="input">La chaîne hexadécimale à nettoyer.</param>
        /// <returns>Chaîne hexadécimale nettoyée</returns>
        public static string CleanHexString(string hexString)
        {
            if (string.IsNullOrEmpty(hexString))
            {
                return string.Empty;
            }
            // Supprimer les espaces et normaliser la casse
            return hexString.Replace(" ", string.Empty).ToUpperInvariant();
        }

        /// <summary>
        /// Convertit une chaîne hexadécimale en tableau d'octets.
        /// </summary>
        /// <param name="hexString">Chaîne hexadécimale (avec ou sans espaces)</param>
        /// <returns>Tableau d'octets</returns>
        /// <exception cref="ArgumentException">Si la chaîne n'est pas un hexadécimal valide</exception>
        /// <exception cref="FormatException">Si la chaîne a une longueur impair</exception>"
        
        public static byte[] HexStringToByte(string hexString)
        {

            if (string.IsNullOrEmpty(hexString))
            {
                throw new ArgumentException("La chaîne ne peut pas être vide ou nulle.");
            }

            if (!IsValidHexString(hexString))
            {
                throw new ArgumentException("La chaîne n'est pas un hexadécimal valide.");
            }

            string cleanedHex = CleanHexString(hexString);

            if (cleanedHex.Length % 2 != 0)
            {
                throw new FormatException("La chaîne hexadécimale doit avoir une longueur paire.");
            }
            // Initialiser le tableau d'octets avec la moitié de la longueur de la chaîne nettoyée
            byte[] tabOctet = new byte[cleanedHex.Length / 2];

            // Convertir chaque paire de caractères hexadécimaux en un octet
            for (int i = 0; i < cleanedHex.Length; i += 2)
            {
                string hexOctet = cleanedHex.Substring(i, 2);
                tabOctet[i / 2] = byte.Parse(hexOctet, NumberStyles.HexNumber);
            }
            return tabOctet;
        }
    }
}
