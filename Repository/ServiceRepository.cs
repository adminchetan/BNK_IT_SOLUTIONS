using Uttaraonline.DBConfig;
using Uttaraonline.Interfaces;
using Uttaraonline.Models;

namespace Uttaraonline.Repository
{
    public class ServiceRepository : IServices
    {
   
        private readonly DBContextProduction _dBContextProduction;
        public ServiceRepository(DBContextProduction dBContextProduction)
        {
          
            _dBContextProduction= dBContextProduction;
        }
        public IQueryable<object> GetallServices()
        {

            var result = from sm in _dBContextProduction.tbl_ServiceMasters
                         join stm in _dBContextProduction.tbl_ServiceTypeMaster on sm.ServiceType equals stm.Id
                         select new
                         {
                             ServiceId=sm.Id,
                             ServiceName=sm.Name,
                             ServiceDescription=sm.Description,
                             ServiceType=stm.Name
                         };
            return result;
           
        }

        public List<object> GetAllServiceSubscribedByUser()
        {
            throw new NotImplementedException();
        }
    }
}
