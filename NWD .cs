using System;

namespace ConsoleApp28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, n, roznica;
            Console.WriteLine("Podaj wartośc m:");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj wartośc n");
            n = Convert.ToInt32(Console.ReadLine()); 
            do
            {
                if (m > n)
                {
                    roznica = m - n;
                    m = roznica; 
                }
                else
                {
                    roznica = n-m;
                    if (n > m)
                    {
                        n = roznica;
                    }
                }
            }while(roznica!= 0);
            Console.WriteLine("Największym wspólnym dzielnikiem jest wartośc zmiennej " + n);
            Console.ReadKey();
        }
    }
}
