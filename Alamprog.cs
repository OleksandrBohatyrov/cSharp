using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace cSharp
{
    public class Alamprog
    {


        public static int Korruta(int arv1, int arv2)
        {
            return arv1 + arv2;
        }

        public static void Tere(string name)
        {
            Console.WriteLine("Tere {0}", name);
        }


        public static double Arith(int k)
        {
            //Console.WriteLine("Sisesta uus number: ");
            //arv1 = Convert.ToInt32(Console.ReadLine());
            //arv2 = Convert.ToInt32(Console.ReadLine());
            //int sum= arv1+ arv2;
            //double arth = (double)sum / numbers.Length;

            int[] numbers = new int[k];


            for (int i = 0; i < k; i++)
            {
                Console.WriteLine($"Sisesta number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            double arth = (double)sum / numbers.Length;

            return arth;
        }
    }
}
