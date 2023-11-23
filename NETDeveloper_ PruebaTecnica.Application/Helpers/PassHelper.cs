using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETDeveloper__PruebaTecnica.Application.Helpers
{
    using System;
    using System.Security.Cryptography;

    public class PassHelper
    {
        public static string HashPassword(string password)
        {
            // Genera una sal aleatoria
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            // Crea un derivado de la contraseña utilizando PBKDF2 con HMAC-SHA1
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            // Combina la sal y el hash en una sola matriz
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            // Convierte la matriz combinada a una cadena Base64
            string hashedPassword = Convert.ToBase64String(hashBytes);

            return hashedPassword;
        }

        public static bool VerifyPassword(string savedPasswordHash, string passwordToCheck)
        {
            // Convierte la cadena Base64 a una matriz de bytes
            byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);

            // Extrae la sal de la matriz
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            // Crea un derivado de la contraseña utilizando PBKDF2 con HMAC-SHA1 y la sal almacenada
            var pbkdf2 = new Rfc2898DeriveBytes(passwordToCheck, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            // Compara los hashes
            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i + 16] != hash[i])
                    return false;
            }

            return true;
        }
    }
}
