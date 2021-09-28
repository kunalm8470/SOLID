namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            MailMessage msg = new(new FileLogger());
            msg.Send();
        }
    }
}
