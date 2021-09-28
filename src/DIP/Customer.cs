namespace DIP
{
    class Customer
	{
		// High level module is depending on abstraction (interface)
		// and not on concrete implementation
		private readonly IDataProvider _dataProvider;
		public Customer(IDataProvider dataProvider)
		{
			_dataProvider = dataProvider;
		}

		public bool Validate() => true;

		public void Add()
		{
			if (Validate())
			{
				_dataProvider.Add();
			}
		}
	}
}
