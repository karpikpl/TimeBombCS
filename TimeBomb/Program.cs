using System;

namespace TimeBomb
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = new string[5];

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = Console.ReadLine();
            }

            var result = Solver.Solve(data);
            Console.WriteLine(result);
        }
    }
}
