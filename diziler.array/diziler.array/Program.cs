using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler.array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 1, 2, 2, 3, 4, 5, 6, 9, 8, 7 };
        
            //sayilar = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(sayilar[i]);
            }
        }
    }
}
