using Uttaraonline.DBConfig;
using Uttaraonline.LoggerInterface;
using Uttaraonline.Models;

namespace Uttaraonline.Repository
{
    public class loggerRepository : LoggerInterface.IEventLogger
    {
        
        private readonly DBContextProduction _dBContextProduction;

        public loggerRepository(DBContextProduction dBContextProduction)
        {
            _dBContextProduction=dBContextProduction;
        }
        public void LogInformation(string message, string trackingCode, string Entity)
        {
            tbl_Logger tbl_Logger = new tbl_Logger()
            {
                Message=message,
                Excepction="NA",
                Level="Information",
                TrackingCode=trackingCode,
                EntityName=Entity,

            };

            _dBContextProduction.tbl_logger.Add(tbl_Logger);
            var i = _dBContextProduction.SaveChanges();
        }

        public void LogExcepction(string message, string User, string Entity)
        {
            throw new NotImplementedException();
        }
    }
}
