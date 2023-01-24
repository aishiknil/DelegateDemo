using System;
namespace App
{
    delegate void MyDel(int x, int y);
    public class Program

    {
        public static void Add(int x, int y)
        {
            Console.WriteLine($"Addition = {x+y}");
        }
        public static void Mult(int x, int y)
        {
            System.Console.WriteLine($"Multiplication = {x * y}");
        }
        static void Main(string[] args)
        {
            MyDel del = new MyDel(Add);
            del += Mult;
            del(10,20);
        }
    }
}