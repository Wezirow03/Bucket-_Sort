using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Atm
{
    internal class Program
    {
        static void Main(string[] args)
        { Console.WriteLine("Lutfen isminizi giriniz");
            Console.WriteLine(" ");
            string isim=Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Lutfen parola belirleyiniz");
            Console.WriteLine(" ");
            string parola =Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Lutfen hesabiniza para yatirin");
            Console.WriteLine(" ");
            int bakiye = int.Parse(Console.ReadLine());
           
           
                int hak = 3;
                while (true)
                {
                    Console.WriteLine("Lutfen isminizi giriniz:");
                    Console.WriteLine(" ");
                    string isim1 = Console.ReadLine();
                    Console.WriteLine(" ");
                    Console.WriteLine("Lutfen paarolanizi giriniz");
                    Console.WriteLine(" ");
                    string parola1 = Console.ReadLine();
                 

                    if (isim == isim1 && parola == parola1)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Kartiniza basariyla giris yapilmistir");
                        Console.WriteLine(" ");
                        break;
                       
                    }


                    else
                    {
                        hak--;
                        Console.WriteLine("Hatali deneme!!!");
                        Console.WriteLine(" ");
                    }

                    if (hak == 0)
                    {
                        Console.WriteLine("Cok fazla hatali deneme yapilmistir");
                        Console.WriteLine(" ");
                        Console.WriteLine("Kartiniz bloke olmustur");
                        Console.WriteLine(" ");
                        return;
                    }
                }
                while (true)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Yapmak istediginiz islemi seciniz");
                    Console.WriteLine("1-Para cekmek");
                    Console.WriteLine("2-Para yatirmak");
                    Console.WriteLine("3-Var olan bakiyeyi gor");
                    Console.WriteLine("4-cikis yap");
                    Console.WriteLine(" ");
                    int secim = int.Parse(Console.ReadLine());
                    if (secim == 1)
                    {
                        Console.WriteLine("Cekmek istediginiz para tutarini seciniz");
                        Console.WriteLine(" ");
                        int cek = int.Parse(Console.ReadLine());
                        bakiye = bakiye - cek;
                        Console.WriteLine("Kalan bakiyeniz:" + bakiye);
                        if (bakiye < cek)
                        {
                            Console.WriteLine("Hesabinizda bu kadar para yok");
                            Console.WriteLine(" ");
                        }

                    }
                    else if (secim == 2)
                    {
                        Console.WriteLine(" Yatirmak istediginiz para tutarini yaziniz");
                        Console.WriteLine(" ");
                        int yatir = int.Parse(Console.ReadLine());
                        bakiye= bakiye+yatir;
                        Console.WriteLine("Bakiyeniz:" + bakiye);
                        Console.WriteLine(" ");

                    }
                    else if (secim == 3)
                    {
                        Console.WriteLine("Sizin bakiyeniz:" + bakiye);
                        Console.WriteLine(" ");
                    }
                    else if (secim == 4)
                    {
                        Console.WriteLine("Basariyla cikis yapildi");
                        Console.WriteLine(" ");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Hatali secim");
                        Console.WriteLine(" ");
                    }

                }

        }
    }
}
