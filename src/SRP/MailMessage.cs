using System;

namespace SRP
{
    // Bad way
    /*
	public class MailMessage : IMessage
	{
		public bool Send()
		{
			try
			{
				return true;
			}
			catch (Exception ex)
			{
				//Error Logging
				System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
				return false;
			}
		}
	}
	*/

    public class MailMessage : IMessage
    {
        private readonly ILogger _logger;
        public MailMessage(ILogger logger)
        {
            _logger = logger;
        }

        public bool Send()
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                //Error Logging
                _logger.Error(ex.Message, ex);
                return false;
            }
        }
    }
}
