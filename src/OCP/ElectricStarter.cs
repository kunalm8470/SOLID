namespace OCP
{
    public class ElectricStarter : IStarter
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public IgnitionResult Start()
        {
            return IgnitionResult.Success;
        }
    }
}
