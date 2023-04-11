using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
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
        public static double Jagata(int arv1, int arv2)
        {
            double j = arv1 / arv2;
            j= Math.Round(j, 2);

            return j;
        }
            
        public static string Kalkulaator(int arv1, int arv2, char tehe)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            double j = Convert.ToDouble(table.Compute(arv1.ToString()+tehe.ToString()+arv2.ToString(), String.Empty));

            j=Math.Round(j, 0);
            string vastus = "";
            string nur = "nurr ";
            for (int i =0; i < Math.Abs(Convert.ToInt32(j)); i++)
            {
                vastus = vastus + nur;
            }
            return vastus;
        }



        public static string Stars(int n)
        {
            string var = "";
            for (int i = 0; i < n; i++)
            {
                var += "*";
            }
            return var;
             
        }



        public static string NStars(int n)
        {
            int[] stars = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0} arv", i + 1);
                stars[i] = Convert.ToInt32(Console.ReadLine());

            }
            foreach (int num in stars)
            {
                Console.Write(Stars(num));
                Console.WriteLine();
            }
        }
    }
}
