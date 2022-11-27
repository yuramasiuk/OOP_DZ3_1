using System;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter Conv = new Converter(36.92, 38.40);
            while(true)
            { 
            Console.WriteLine("Choose the operation:\n 1 - EUR to UAH\n 2 - USD to UAH\n 3 - UAH to EUR\n 4 - UAH to USD");
            int act = Convert.ToInt32(Console.ReadLine());
                switch (act)
                {
                    case 1:
                        Console.WriteLine("Enter EUR: ");
                        double eur = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(Conv.EURtoUAH(eur));
                        break;
                    case 2:
                        Console.WriteLine("Enter USD: ");
                        double usd = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(Conv.USDtoUAH(usd));
                        break;
                    case 3:
                        {
                            Console.WriteLine("Enter UAH: ");
                            double uah = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(Conv.UAHtoEUR(uah));
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter UAH: ");
                            double uah = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(Conv.UAHtoUSD(uah));
                            break;
                        }
                }
                Console.WriteLine("If you want to continie, put 1. If not - put 0.");
                int cont = Convert.ToInt32(Console.ReadLine());
                if (cont == 0) break;

            }
        }
    }
}
