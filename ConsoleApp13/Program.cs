using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            new God().MaxAge(new LionFactory());
            new God().MaxAge(new ElephantFactory());
        }
    }

}
