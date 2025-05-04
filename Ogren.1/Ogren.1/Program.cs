using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ogren._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] num =  GiveMeNumber();
           int [] new_nums = FindNumber(num);
           WriteArray(new_nums);
        }
        //Kullanicidan alinan dizinin icindeki cidt sayilari cift olmayan indeksli yerlere yerlesdirmek
        // 1.Kullanicidan sayi dizisini al
        // 2.Icindeki cift sayilari bul
        // 3.Cift olmayan indekslere yerlesdir
        public static int[] GiveMeNumber()
        {
            Console.WriteLine(" Lutfen sayilari bosluklarla yaziniz ");
            string add = Console.ReadLine();
            string[] del = add.Split(' ');
            int[] numbers = new int[del.Length];
 
            for (int i = 0; i < del.Length; i++)
            {
                if (int.TryParse(del[i], out int number))
                { numbers[i] = number; }
                else
                {
                    Console.WriteLine("Lutfen sayi girdiginizden emin olun ve bosluk birakarak yaziniz");

                }
            }
            return numbers;
            


        }
        public static int[] FindNumber(int[] nums)
        {
            if (nums == null || nums.Length == 0) return nums;
            List <int> minindex = new List<int>();
           List  <int> maxindex= new List<int>();
            int index0 = 0;
            int index1 = 1;
            for (int i = 1; i <= nums.Length - 1; i+=2)
            {
                if (nums[i] % 2 == 0)  minindex.Add( nums[i]);
                else maxindex.Add(nums[i]);
                
            }
          for (int i=0; index0 == nums[i] ;i++)
            {
               nums[i] = maxindex[i];
                index0 +=2;
            }
            for (int i = 1; index1 == nums[i]; i++)
            {
                nums[i] = minindex[i];
                index1 += 2;
            }

            return nums;
            
        }
        static void WriteArray (int[] arr)
        { 
            foreach (int item in arr)
            {
                Console.Write( item);
                Console.Write( " ");
            }
        }
    }
}
