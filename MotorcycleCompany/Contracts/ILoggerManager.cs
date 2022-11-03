namespace Contracts
{
    public interface IloggerManager
    {
        void logInfo(string message);
        void Logwarn(string message);
        void LogDebug(string message);
        void LogError(string message);

    }
}