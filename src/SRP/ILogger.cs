using System;

namespace SRP
{
    public interface ILogger
    {
        public void Info(string info);
        public void Debug(string info);
        public void Error(string message, Exception ex);
    }
}
