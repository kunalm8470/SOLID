namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer john = new(new ConsoleLogger());
            john.ToString();
        }
    }
}
