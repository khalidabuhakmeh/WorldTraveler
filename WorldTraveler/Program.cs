using System;
using System.Globalization;

namespace WorldTraveler
{
    class Program
    {
        private static void Main(string[] args)
        {
            var cultures = new[] {"en", "es", "fr"};

            foreach (var culture in cultures)
            {
                Language.Culture = CultureInfo.GetCultureInfo(culture);
                Console.Write($"{Language.Culture.EnglishName} -" +
                              $" {Language.Culture.NativeName} says ");
                Console.Write($"{Language.HelloWorld}\n");
            }

            Console.WriteLine(Language.Woot);
        }
    }
}
