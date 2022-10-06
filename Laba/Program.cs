using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba
{
    public class Logic
    {
        public static string Num(int a, int b, int c)
        {

            int p = 0;
            if ((a < b & b < c) || (b < a) & (a < c))
            {
                p = a * b;

            }
            if ((c < a & a < b) || (a < c & c < b))
            {
                p = a * c;

            }
            if ((c < b & b < a) || (b < c & c < a))
            {
                p = c * b;

            }
            string message = "Произведение двух наименьших чисел равно " + p;
            return message;


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три различных числа: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            var message = Logic.Num(a, b, c);
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
