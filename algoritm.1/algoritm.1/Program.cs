using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritm._1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
           
            bool IsPrime(int x)
            {
                if (x % 2 == 0) return false;
                for (int i = 5; i < x/2 + 1 ; i+=2)
                {
                    if (x % 2 == 0)
                    { return false; }
                }
                return true;
            }
            //(x-2)*1=x-2 operatsiya
            // O(n)-x
            //O(n)-1/2x
            //O(Vn)(Math.sqrt(x) || i*i<x 
        }
        
    }
}
