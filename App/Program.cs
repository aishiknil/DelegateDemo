using System;
namespace App
{
    delegate int MyDel(int x, int y);
    public class Program

    {
        public static int Add(int x, int y)
        {
            return (x + y);
        }
        public static int Mult(int x, int y)
        {
            return (x * y);
        }
        static void Main(string[] args)
        {
            MyDel del = new MyDel(Add);

        }
    }
}