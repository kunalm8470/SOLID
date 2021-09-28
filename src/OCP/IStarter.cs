namespace OCP
{
    public interface IStarter
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public IgnitionResult Start();
    }

    public enum IgnitionResult
    {
        Success,
        Failure
    }
}
