using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Wprowadź długośc przyprostokątnej A.");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Wprowadź długość przyprostokątnej B.");
            b = double.Parse(Console.ReadLine());

            c = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b, 2));

            Console.WriteLine($"Długość przeciwprostokątnej {c}.");
        }
    }
}
