namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = "Testing";
            
            // Implements IPrinterTasks, IFaxTasks and IPrintDuplexTasks
            LaserJetPrinter printer = new();
            printer.Print(content);
            printer.Scan(content);
            printer.Fax(content);
            printer.PrintDuplex(content);

            // Only implements IPrinterTasks
            LiquidInkjetPrinter printer2 = new();
            printer2.Print(content);
            printer.Scan(content);
        }
    }
}
