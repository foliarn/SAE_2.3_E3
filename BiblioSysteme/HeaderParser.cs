using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSysteme
{
    /// <summary>
    /// Parse et valide les headers hexadécimaux collés par l'utilisateur.
    /// </summary>
    public static class HeaderParser
    {
        /// <summary>
        /// Longueur minimale d'un header IP en octets.
        /// </summary>
        public const int MIN_HEADER_LENGTH = 20;

        /// <summary>
        /// Position standard du champ "Checksum" dans un header IP.
        /// </summary>
        public const int CHECKSUM_POSITION = 10;

        /// <summary>
        /// Parse une chane hexadécimale en header valide.
        /// </summary>
        /// <param name="hexChaine">Chaîne hexadécimale collée par l'utilisateur</param>
        /// <returns>Tableau d'octets représentant le header</returns>
        /// <exception cref="ArgumentException">Si la chaîne n'est pas un hexadécimal valide ou si la longueur est inférieure à 20 octets</exception>
        /// <exception cref="FormatException">Si le format hexadécimal est incorrect</exception>"
        public static byte[] ParseHeader(string hexChaine)
        {
            if (string.IsNullOrWhiteSpace(hexChaine))
            {
                throw new ArgumentException("La chaîne hexadécimale ne peut pas être vide ou nulle.", nameof(hexChaine));
            }

            if (!Utils.IsValidHexString(hexChaine))
                throw new FormatException("Le header contient des caractères non hexadécimaux.");

            // Convertir en octets
            byte[] headerOctets;
            try
            {
                headerOctets = Utils.HexStringToByte(hexChaine);
            }
            catch (Exception ex)
            {
                throw new FormatException($"Erreur lors de la conversion : {ex.Message}",ex);
            }

            return headerOctets;
        }

        /// <summary>
        /// Parse et valide un header IP spécifiquement
        /// </summary>
        /// <param name="hexChaine">Chaîne hexadécimale du header IP</param>
        /// <returns>Tableau d'octets du header IP valide</returns>
        /// <exception cref="ArgumentException">Si le header IP est invalide</exception>
        public static byte[] ParseIPHeader(string hexChaine)
        {

            // Nettoyer la chaîne hexadécimale (supprimer les espaces et normaliser la casse)
            byte[] headerOctets = ParseHeader(hexChaine);

            // Vérifier la longueur minimale pour un header IP
            if (headerOctets.Length < MIN_HEADER_LENGTH)
                throw new ArgumentException($"Header IP trop court. Longueur minimale : {MIN_HEADER_LENGTH} octets, reçu : {headerOctets.Length} octets.");

            // Vérifier que c'est bien un header IPv4 (2 premiers bits doivent être 4)
            if ((headerOctets[0] >> 4) != 4)
                throw new ArgumentException("Ce n'est pas un header IPv4 valide (version incorrecte).");

            // Vérifier la longueur du header selon le champ IHL (Internet Header Length)
            int ihl = headerOctets[0] & 0x0F; // 4 bits de poids faible
            int expectedLength = ihl * 4;    // IHL est en mots de 32 bits (4 octets)

            if (expectedLength < MIN_HEADER_LENGTH)
                throw new ArgumentException($"Longueur de header IP invalide selon IHL : {expectedLength} octets (minimum {MIN_HEADER_LENGTH}).");

            if (headerOctets.Length < expectedLength)
                throw new ArgumentException($"Header IP incomplet. Attendu : {expectedLength} octets, reçu : {headerOctets.Length} octets selon IHL.");

            // Si le header fourni est plus long que nécessaire, le remettre à la bonne taille
            if (headerOctets.Length > expectedLength)
            {
                byte[] miniHeader = new byte[expectedLength];
                Array.Copy(headerOctets, miniHeader, expectedLength);
                return miniHeader;
            }

            return headerOctets;
        }
    }
}
