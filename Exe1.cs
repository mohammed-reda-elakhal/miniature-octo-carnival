using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            int nb = 0;
            do
            {
                Console.WriteLine("entrez un nombre");

            } while (!int.TryParse(Console.ReadLine(), out nb));

            if (premier(nb))
            {
                Console.WriteLine("votre nombre est premier");
            }
            else
            {
                Console.WriteLine("votre nombre pas premier");
            }
        }
        public static bool premier(int a)
        {
            if (a < 2)
            {
                return true;
            }
            else
            {
                for (int i = 2; i < a; i++)
                {
                    if (a % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
