using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp
{
    public class StartClass
    {
        public static void Main(string[] args)
        {
            /* string paev = "";
             Random rnd= new Random();
             for (int i = 0;i < 10; i++)
             {
                 int nr = rnd.Next(1, 7);
                 Console.WriteLine(nr);

                 switch (nr)
                 {
                     case 1: paev = "Esmaspäev"; break;
                     case 2: paev = "Teisipäev"; break;
                     case 3: paev = "Kolmapäev"; break;
                     case 4: paev = "Neljapäev"; break;
                     case 5: paev = "Reede"; break;
                     case 6: paev = "Laupäev"; break;
                     case 7: paev = "Pühapäev"; break;
                     default:
                         paev = "Tundmatu päev";
                         break;
                 }
                 Console.WriteLine(paev);
             }
             int j = 0;
             while (j< 10)
             {
                 Console.WriteLine(paev);
                 j++;
             }
             Console.WriteLine(j);
             do
             {
                 Console.WriteLine(paev);
                 j--;

             } while (j!=0);
             Console.WriteLine(j);

             int[] arvud = new int[10];
             for (int i = 0; i < arvud.Length; i++)
             {
                 arvud[i]= rnd.Next(-100,100);
             }
             foreach (int arv in arvud)
             {
                 Console.WriteLine(arv);
             }*/



            /*Console.WriteLine("Tere tulemast!\n Mis on sinu nimi?");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Tere " + eesnimi);
            Console.WriteLine("Arv1: ");
            
            int arv1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Arv2: ");
            int arv2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Tehe: ");
            char tehe = char.Parse(Console.ReadLine());

            if (tehe == '+')
            {
                Console.WriteLine("Arvude {0} ja {1} summa võrdub {2}", arv1, arv2, arv1 + arv2);
            }
            else if (tehe =='-')
            {
                Console.WriteLine("Arvude {0} ja {1} summa võrdub {2}", arv1, arv2, arv1 - arv2);
            }
            
            Console.WriteLine("Kui vana sa oled?");
            int vanus= int.Parse(Console.ReadLine());
            if (vanus <=6)
            {
                Console.WriteLine("tasuta");
            }
            else if (vanus <=15) 
            {
                Console.WriteLine("lastepilet");
            }
            else if (vanus<=65)
            {
                Console.WriteLine("täispilet");
            }
            else if (vanus <=100)
            {
                Console.WriteLine("sooduspilet");
            }
            else
            {
                Console.WriteLine("viga andmetega");
            }

            Console.WriteLine("Mis on sinu nimi?");
            string a = Console.ReadLine();
            Console.WriteLine("Mis on sinu nimi?");
            string b = Console.ReadLine();

            if (eesnimi=="M" && eesnimi=="A")
            Console.WriteLine("{0} ja {1} te istute täna koos ", a, b);*/


            //Random random = new Random();
            //int N = random.Next(1, 101);
            //int M = random.Next(1, 101);
            //int[] ints= new int[N, M];






            //int[] numbers = new int[5];


            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"Sisesta number {i + 1}: ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //int sum = 0;
            //foreach (int number in numbers)
            //{
            //    sum += number;
            //}

            //double arth = (double)sum / numbers.Length;

            //int korrutis = 1;
            //foreach (int number in numbers)
            //{
            //    korrutis *= number;
            //}

            //Console.WriteLine($"Summa: {sum}");
            //Console.WriteLine($"Aritmeetiline : {arth}");
            //Console.WriteLine($"Korrutis: {korrutis}");

            //string name = "Python";
            //Alamprog.Tere(name);
            //int a = 12;
            //int b = 13;
            //int vastus=Alamprog.Korruta(a, b);
            //Console.WriteLine(vastus);

            double arithm = Alamprog.Arith(2);
            Console.WriteLine(arithm);


        }

    }
}
