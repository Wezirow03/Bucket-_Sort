using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    interface I1 { int Get(); }
    interface I2 { int Get(); }
    class A : I1, I2
    {
        public virtual int Get() { return 1; }
    }
    class B : A, I1
    {
        public int Get() { return 2; }
    }
    public class Program
    {
        public static void Main()
        {
            var o = (I1)(A)new B();
            Console.WriteLine(o.Get());
                
        }
    }
}
