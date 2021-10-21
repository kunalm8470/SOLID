namespace DIP
{
    class Customer
    {
        // High level module is depending on abstraction (interface)
        // and not on concrete implementation
        private readonly ILogger _logger;
        public Customer(ILogger logger)
        {
            _logger = logger;
        }

        public override string ToString()
        {
            _logger.Log();
            return base.ToString();
        }
    }
}
