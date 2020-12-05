using System;

namespace Conditionals_If
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 8;
            if (number==7)
            {
                Console.WriteLine("Number is 7 ");
            }
            else if (number==8)
            {
                Console.WriteLine("Number is 8");
            }
            else
            {
                Console.WriteLine("Number is not 7 or 8");
            }
            //Ternary Operatorü ile kullanım
           //Console.WriteLine(number == 7 ? "Sayı 7 dir" : "Sayı 7 değildir");

            Console.ReadKey();
        }
    }
}
