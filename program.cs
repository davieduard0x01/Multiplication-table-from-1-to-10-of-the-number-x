using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------- BEM VINDO A TABUADA -------------- ");
            Console.WriteLine("Digite um número ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + num * i);


            }
            Console.WriteLine("--------------////////////////////////-------------- ");
            Console.ReadKey();
        }
    }
}
