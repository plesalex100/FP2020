using System;
/// <summary>
/// Distanta pana la Stormwind
/// </summary>
namespace _1_0610
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Introduceti distanta la care sunteti pe autostrada");
                int k = int.Parse(Console.ReadLine());

                if (k > 60) k -= 60;
                else k = 60 - k;

                Console.WriteLine($"Va aflati la {k} km de Stormwind");

            } catch(Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}

