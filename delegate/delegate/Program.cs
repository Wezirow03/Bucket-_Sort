using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{
    internal class Program
    {
        public delegate int NoParam(int a , int b);
            
        static void Main(string[] args)
        {
            NoParam NoPrm = Plus;
            NoPrm(12,14);
        }
        private static int Plus ( int a , int b)
        { return a + b;  }
    }
}
