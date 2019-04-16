using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Adinizi daxil edin:");
            //string number = Console.ReadLine();
            //Console.Write("Yasinizi daxil edin:");
            //string input1 = Console.ReadLine();
            //Console.WriteLine("Salam sizin adiniz {0} -dur.Yaş {1}", input, input1);
            //char a = 'a';
            //Console.Write("Adinizi daxil edin:");
            //string a = Console.ReadLine();

            //while (a.ToUpper()!= "Admin")
            //{
            //    Console.Write("Duzgun ad yazin :");
            //    a = Console.ReadLine();

            //}
            //Console.Write("Dogum ilinizi daxil edin:");
            //string b = Console.ReadLine();
            //int c = Convert.ToInt32(b);
            //Console.WriteLine("Salam sizin adiniz {0} -dur.Yaş {1}", a, 2019 - c);

            while (1 == 1)
            {

            Console.Write("Balinizi daxil edin :");
             string a = Console.ReadLine();
             int c = Convert.ToInt32(a);
           
                if (c <=51)
                {
                    Console.WriteLine("kesildiz");
                }
                else if (c >= 51 && c<=90)

                {
                    Console.WriteLine("Siz kecidi kecdiniz");

                }
                else if(c>90)
                {
                    Console.WriteLine("elaci");

                }
               
            }
        }
    }
}
