using gitdemo;
using System;

namespace GitDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Its a git demoooooooooooooooooooooooooo");
            Console.WriteLine("Iam gonna use another class");

            ChildClass childClass = new ChildClass();
            childClass.DoSomeShit();
        }
    }
}