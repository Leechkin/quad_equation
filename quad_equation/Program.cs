using System;

namespace quad_equation
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                double a, b, c;
                Console.Write("Insert a = ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Insert b = ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Insert c = ");
                c = Convert.ToDouble(Console.ReadLine());
                double x1, x2, dec;
                dec = b * b - (4 * a * c);
                if (dec < 0)
                {
                    Console.WriteLine("Dec < 0, the equation has no roots");
                    Console.ReadLine();
                }
                else
                {
                    if (dec == 0)
                    {
                        Console.WriteLine("Dec = 0, the equation has 1 root");
                        var x = (-1 * b) / (2 * a);
                       
                        Console.WriteLine($"x1,2 = {x}");
                    }
                    else
                    {
                        x1 = (-1 * b + (Math.Sqrt(dec))) / (2 * a);
                        x2 = (-1 * b - (Math.Sqrt(dec))) / (2 * a);
                        Console.WriteLine($"x1 = {x1}, x2 = {x2}");
                    }
                }
               
                   
                    Console.Write("Make the calculation again? enter 'y' or 'n': ");
                    ConsoleKeyInfo answer = Console.ReadKey();
                    if (answer.KeyChar == 'n') break;
                    Console.ReadLine();
               
                    
                } 
        }
    }
}
