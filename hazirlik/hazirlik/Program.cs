using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace hazirlik
{
    internal class Program
    {

        static void Main(string[] args)
        {


        }



    }
    /*  class Bird      Solid -- S
      {
          public static void ISwiming()
          {
              Console.WriteLine( "I can swim ");
          }
          public static void IFlying()
          {
              Console.WriteLine("I can fly");
          }

      }*/

    /* class Hero  Solid--O
     {

        public  int hp;
        public     string name;
         public    int power;
          public   string itold;



     }
     class NewHero
     {
         public static void AllHero()
         {
             Hero hero = new Hero();
             hero.hp = 100;
             hero.name = "Warrior"


         }  */
   /* class Bird          Solid -- o and Inheriatance and Polimorfizm
    {
        public virtual void Fly()
        {
            Console.WriteLine("I can fly");
        }
      /*  public virtual void Swim()
        {
            Console.WriteLine("I can swim");
        }*/
   /* }
    class Eagle : Bird
    {
        public override void Fly ()
        {
            Console.WriteLine("I am Eagle.I can Fly");
        }
       /* public override void Swim()
        {
            Console.WriteLine("I can not swim");
        }*/

    //}
   /* class Penguen : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("I am Penguen.I can not Fly");
        }
        public override void Swim()
        {
            Console.WriteLine("I can swim");
        }*/

   // }


    /*  public interface Ifly  Solid -- I and Interface
      {
           void Fly();


      }
      public interface Iswim
      {
          void Swim();
      }*/

    public interface SendMessage
    {
      abstract void SendMessage(string message);
    }
   public class Email : SendMessage
    {
      public void SendMessage(string message)
        {
            Console.WriteLine("Sending Email...");
        }
    }
    public class Sms : SendMessage
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Sending Sms...");
        }
    }

}

   





