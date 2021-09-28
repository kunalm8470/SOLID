namespace OCP
{
    public class HydraulicStarter: IStarter
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public IgnitionResult Start()
        {
            return IgnitionResult.Success;
        }
    }
}
