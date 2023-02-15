using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmeringsuppvärmning
{
    internal class App
    {
        public string GetTwoOfSameString(int tal)
        {
            if (tal == 1)
                return "ettor";
            else if (tal == 2)
                return "tvåor";
            else if (tal == 3)
                return "treor";
            else if (tal == 4)
                return "fyror";
            else if (tal == 5)
                return "femmor";
            else if (tal == 6)
                return "sexor";
            return null;
        }
        public void Run()
        {
            var random = new Random();
            while (true)
            {
                var tal1 = random.Next(1, 7);
                var tal2 = random.Next(1, 7);
               
                if (tal1 == tal2)
                {
                    var twoOfSame = GetTwoOfSameString(tal1);
                    Console.WriteLine($"Du fick två {twoOfSame}");
                }
                else
                {
                    var first = GetOneOf(tal1);
                    var second = GetOneOf(tal1);
                    Console.WriteLine($"Du fick en {first} och en {second}");
                }

                Console.Write("Vill du fortsätta? J/N:");
                var s = Console.ReadLine();
                if (s == "N")
                    break;
            }

        }

        public string GetOneOf(int tal1)
        {
            switch (tal1)
            {
                case 1:
                    return "etta";
                case 2:
                    return "tvåa";
                case 3:
                    return "trea";
                case 4:
                    return "fyra";
                case 5:
                    return "femma";
                case 6:
                    return "sexa";
                default:
                    return null;

            }
        }
    }
}
