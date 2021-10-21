namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderProcessor processor = new(new OrderValidator(),
                new OrderStore(),
                new OrderNotifier()
            );

            processor.Process();
        }
    }
}
