using System;


namespace methodkullanim
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = RedValue();
            PrintTriangle(height);
              
        }
        static int RedValue()
        {
            int.TryParse(Console.ReadLine(), out int number);
            return number;
        }
                static public void yaz(string isim)
                {
                    Console.WriteLine("Selam " + isim);

                }
        Console.WriteLine("Isminizi giriniz");
            string a = Console.ReadLine();
        yaz(a);


    }
}
