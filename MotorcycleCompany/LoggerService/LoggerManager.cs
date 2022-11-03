using Contracts;
using NLog;

namespace LoggerService
{
    public class LoggerManager : IloggerManager
    {
        private static ILogger _logger = LogManager.GetCurrentClassLogger();


        public LoggerManager
        {

        }


        public void LogDebug(string message)
        {
            throw new NotImplementedException();
        }

        public void LogError(string message)
        {
            throw new NotImplementedException();
        }

        public void logInfo(string message)
        {
            throw new NotImplementedException();
        }

        public void Logwarn(string message)
        {
            throw new NotImplementedException();
        }
    }
}