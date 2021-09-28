namespace ISP
{
    // Big fat interface
    /*
        public interface IPrinterTasks
        {
            void Print(string content);
            void Scan(string content);
            void Fax(string content);
            void PrintDuplex(string content);
        }
    */

    public interface IPrinterTasks
    {
        void Print(string content);
        void Scan(string content);
    }
}
