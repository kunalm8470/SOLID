namespace SRP
{
    // Disabling 1 class per file for better readability
    public class OrderProcessor
    {
        private readonly OrderValidator _validator;
        private readonly OrderStore _persistor;
        private readonly OrderNotifier _notifier;

        public OrderProcessor(OrderValidator validator,
            OrderStore persistor,
            OrderNotifier notifier
        )
        {
            _validator = validator;
            _persistor = persistor;
            _notifier = notifier;
        }

        public void Process()
        {
            _validator.Validate();
            _persistor.Persist();
            _notifier.Notify();
        }
    }

    public class OrderValidator
    {
        public void Validate()
        {
            // Implementation goes here
        }
    }


    public class OrderStore
    {
        public void Persist()
        {
            // Implementation goes here
        }
    }

    public class OrderNotifier
    {
        public void Notify()
        {
            // Implementation goes here
        }
    }
}
