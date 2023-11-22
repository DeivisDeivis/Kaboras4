using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Laborasss_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const string cfd = "Duomenys.txt";
            string tekstas;

            int kiekisDidRaides = 0;
            int kiekisMazRaides= 0;
            string[] words = tekstas.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                if (word.Length > 1) 
                {
                    char firstChar = word[0];
                    char lastChar = word[word.Length - 1];

                    if (char.IsLetter(firstChar) && char.IsLetter(lastChar))
                    {
                        if (char.ToLower(firstChar) > char.ToLower(lastChar))
                        {
                            kiekisDidRaides++;
                        }
                        else if (char.ToLower(firstChar) < char.ToLower(lastChar))
                        {
                            kiekisMazRaides++;
                        }
                    }
                }
            }
            Console.WriteLine($"Words with the first letter larger than the last: {largerFirstLetterCount}");
            Console.WriteLine($"Words with the first letter smaller than the last: {smallerFirstLetterCount}");

            // Determine which type is more frequent
            if (largerFirstLetterCount > smallerFirstLetterCount)
            {
                Console.WriteLine("Words with the first letter larger than the last are more frequent.");
            }
            else if (smallerFirstLetterCount > largerFirstLetterCount)
            {
                Console.WriteLine("Words with the first letter smaller than the last are more frequent.");
            }
            else
            {
                Console.WriteLine("Both types of words are equally frequent.");
            }

        }
    }
}
