namespace OCP
{
    // Disabling 1 class per file for better readability
    public class OrderProcessor
    {
        private readonly OrderValidator _validator;
        private readonly InMemoryOrderStore _persistor;
        private readonly OrderNotifier _notifier;

        public OrderProcessor(OrderValidator validator,
            InMemoryOrderStore persistor,
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


    public interface IOrderStore
    {
        public void Persist();
    }

    /*
     * Classes are closed to modification
     * but open for extension.
    */
    public class InMemoryOrderStore : IOrderStore
    {
        /*
         * BAD
         * 
         * public void PersistMongo()
         * {
         * 
         * }
         * 
         * public void PersistRedis()
         * {
         * 
         * }
        */

        public void Persist()
        {
            // Implementation goes here
        }
    }

    public class RedisOrderStore : IOrderStore
    {
        public void Persist()
        {
            // Implementation goes here
        }
    }

    public class MongoOrderStore : IOrderStore
    {
        public void Persist()
        {
            // Implementation goes here
        }
    }

    public class SqlServerOrderStore : IOrderStore
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
