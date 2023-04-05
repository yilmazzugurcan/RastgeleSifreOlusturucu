using System;
using System.Linq;

namespace RastgeleSifreOlusturucu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 15) // 8 karakterli bir şifre oluşturmak için chars'ı 8 kere tekrarla
                          .Select(s => s[random.Next(s.Length)]) // chars'ın rastgele bir karakterini seç
                          .ToArray());

            Console.WriteLine("Rastgele şifre: " + result);

            var resultWithDigits = new string(
                Enumerable.Repeat(chars + "0123456789", 20) // 10 karakterli bir şifre oluşturmak için chars'ı 8 kere tekrarla ve rakamları da ekleyin
                          .Select(s => s[random.Next(s.Length)]) // chars ve rakamların rastgele bir karakterini seç
                          .ToArray());

            Console.WriteLine("Rastgele şifre (rakamlarla birlikte): " + resultWithDigits);
        }
    }
}
