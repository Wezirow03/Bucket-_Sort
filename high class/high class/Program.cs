using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace high_class
{
    internal class Program
    {
        public delegate int NoParam( int a , int b);

        static void Main(string[] args)
        {
            NoParam NoPrm = Plus;
            NoPrm += Winner;
            foreach (NoParam method in NoPrm.GetInvocationList()) {
                int result = method(20, 2);
                Console.WriteLine(result); }
        }
        //private static void Plus()
        //{ Console.WriteLine("Neden basarili olmadiii"); }
        //private static void Winner()
        //{ Console.WriteLine("Yanilmisim basarili olduuuuu"); }
        private static int Plus (int a , int b)
        { return a + b; }
        private static int Winner (int a , int b) { return a /b; }
    }
}
