using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvekŠpraljaJakovRandomNumber
{
    class Program
    {


        static void Main(string[] args)
        {
            RandomGenerator generator = new RandomGenerator();
            Console.WriteLine("--KOLIKO GODINA žIVOTA VAM JE OSTALO --");
            Console.WriteLine("Koliko godina imate: ");
            int i;
            i = Convert.ToInt32(Console.ReadLine());
            int t = 79;
            int p = t - i;
            Console.WriteLine("Ostalo vam je još: ");
            int rand1 = generator.RandomNumber(1, p);
            int rand2 = generator.RandomNumber(1, 364);
            int rand3 = generator.RandomNumber(1,59);
            Console.WriteLine($"{ rand1 } godina/e, { rand2 } dana i { rand3} minuta. Uživajte.");

            Console.ReadKey();
        }
        public class RandomGenerator
        {

            public int RandomNumber(int min, int max)
            {
                Random random = new Random();
                return random.Next(min, max);
            }
        }
    }
}

