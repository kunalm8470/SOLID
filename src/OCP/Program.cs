namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderProcessor processor = new(new OrderValidator(),
               new InMemoryOrderStore(),
               new OrderNotifier()
            );

            processor.Process();
        }
    }
}
