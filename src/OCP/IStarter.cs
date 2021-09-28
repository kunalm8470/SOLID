namespace OCP
{
    public interface IStarter
    {
        string Brand { get; set; }
        string Model { get; set; }
        IgnitionResult Start();
    }

    public enum IgnitionResult
    {
        Success,
        Failure
    }
}
