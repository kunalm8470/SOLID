namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine e = new(new HydraulicStarter());
            e.Start();
        }
    }
}
