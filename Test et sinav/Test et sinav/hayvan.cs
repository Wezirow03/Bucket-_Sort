using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Test_et_sinav;

namespace Test_et_sinav
{
    internal class hayvan
  {
        public virtual void speak() { }
        
    }
}

 class dog : hayvan
{
    public override void speak()
    {
        Console.WriteLine("Dog barks");
    }

}

class cat : hayvan
{
    public override void speak()
    {
        Console.WriteLine("Cat meows");
    }

}


