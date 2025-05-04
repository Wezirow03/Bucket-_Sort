using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritm._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        public static int Fibb (int n)
        { if (n == 0 || n == 1) return 1;
            int[] arr = new int[100];
            arr[0] = 1;
            arr[1] = 1;
        for(int i = 2;i<arr.Length;i++)             //fibonacci 
            { arr[i] = arr[i - 1] + arr[i-2]; }
            return arr[n - 1];
        }
    }
}
