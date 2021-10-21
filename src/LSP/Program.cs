using System;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird donald = new Duck();
            (donald as Duck).Swim();
        }
    }
}
