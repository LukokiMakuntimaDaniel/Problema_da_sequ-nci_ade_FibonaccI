using System;

namespace Problema_da_sequênci_ade_FibonaccI
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c  = a + b;
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("" + a);
            }else if(n>=2)
            {
                Console.WriteLine("" + a);
                Console.WriteLine("" + b);
                for (int cont = 3; cont <= n; cont++)
                {
                    Console.WriteLine("" + c);
                    a = b;
                    b = c;
                    c = a + b;
                    
                   
                }
            }
            
        }
    }
}
