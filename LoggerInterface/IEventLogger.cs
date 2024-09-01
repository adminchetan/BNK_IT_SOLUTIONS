namespace Uttaraonline.LoggerInterface
{
    public interface IEventLogger
    {
        void LogInformation(string message,string TrackingCode,string Entity);
        void LogExcepction(string message,string TrackingCode, string Entity);
    }
}
