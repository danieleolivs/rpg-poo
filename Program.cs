using System;
using RPG.src.Endges;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight Arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jenica", 35, "clean wizard");
            Ninja Ninja = new Ninja("Ninja", 30, "Kusarigama");
            Boss Boss = new Boss("Koopa Troopa", 50, "tartaruga");

            Console.WriteLine(Arus.Attack());
            Console.WriteLine(wizard.Attack(3));
            Console.WriteLine(Ninja.Attack(10));
            Console.WriteLine(Boss.Attack(13));
        }
    }
}
