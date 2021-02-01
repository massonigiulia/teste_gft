using System;

namespace teste1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A = ");
            float A = float.Parse(Console.ReadLine()); 
            Console.Write("B = ");
            float B = float.Parse(Console.ReadLine());
            Console.Write("C = ");    
            float C = float.Parse(Console.ReadLine());
        
            double delta = (B * B) - 4 * A * C;

            double raizDelta = Math.Sqrt(delta);

            double divisao = 2 * A;

            var raiz1 = ((-(B)) + raizDelta) / divisao;
            var raiz2 = ((-(B)) - raizDelta) / divisao;
           
            if (divisao == 0)
            {
                Console.WriteLine("Impossível calcular");
            } 
            else if (double.IsNaN(raizDelta))
            {
                Console.WriteLine("Impossível calcular");
            }
            else 
            {
                Console.WriteLine($"X1 = {raiz1.ToString("N5")}");
                Console.WriteLine($"X2 = {raiz2.ToString("N5")}");
            }           
        }
    }
}
