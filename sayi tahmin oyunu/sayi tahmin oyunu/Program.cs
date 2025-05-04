using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayi_tahmin_oyunu
{
    internal class Program
    {
        static void Main(string[] args)
        { Random random = new Random();
            int hedef_sayi = random.Next(1,101);
            int tahmin = 0;
            int deneme = 10;
            while (true)
            {
                Console.WriteLine("Sayiyi tahmin etmeyi deneyin"); 
                int al = int.Parse(Console.ReadLine());
                if (al != hedef_sayi)
                { Console.WriteLine("Yanlis sayi");
                    tahmin = tahmin + 1;
                    deneme = deneme - 1;
                    if (al < hedef_sayi)
                    { Console.WriteLine("Tahmininiz hedef sayidan kucuk"); }
                    else if (al > hedef_sayi)
                    { Console.WriteLine("Tahmininiz hedef sayidan buyuk"); }
                    else
                    { 
                    Console.WriteLine("Dogru cevap buldunuz.Tebrik ederim");
                        Console.WriteLine($"Tahmininiz {tahmin} ");
                        Console.WriteLine($"Tahmininiz {deneme} ");

                        break;
                    }
                }

                    
                
                
            }
        }
    }
}
