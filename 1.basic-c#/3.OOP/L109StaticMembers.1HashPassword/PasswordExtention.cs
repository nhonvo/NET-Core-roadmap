using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace L109StaticMembers._1HashPassword
{
    public static class PasswordExtention
    {
        const int keySize = 64;
        const int iterations = 350000;
        static readonly HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA512;
        /// <summary>
        /// this keyword is specially symbol you can call the static function by 
        /// variable
        /// </summary>
        /// <param name="password"></param>
        /// <param name="salt"></param>
        /// <returns></returns>
        public static string HashPasword(this string password, byte[] salt)
        {

            var hash = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(password),
                salt,
                iterations,
                hashAlgorithm,
                keySize);

            return Convert.ToHexString(hash);
        }
        public static byte[] CreateSalt() => RandomNumberGenerator.GetBytes(keySize);

    }
}
