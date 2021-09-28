namespace OCP
{
    public class Engine
    {
        private readonly IStarter _starter;
        public Engine(IStarter starter)
        {
            _starter = starter;
        }

        public IgnitionResult Start()
        {
            return _starter.Start();
        }
    }
}
