using Microsoft.Identity.Client;
using Uttaraonline.DBConfig;
using Uttaraonline.Interfaces;
using Uttaraonline.Models;

namespace Uttaraonline.Repository
{
    public class ClientRepository : IClient
    {
        public DBContextProduction _dBContextProduction;
        public ClientRepository(DBContextProduction dBContextProduction) 
        {
            _dBContextProduction = dBContextProduction;
        }
        public IQueryable<object> GetClientsInformation()
        {


            var result = from clt in _dBContextProduction.tbl_ClientMasters
                         select new
                         {
                              ClientId =clt.Id,
                              ClientName=clt.ClientName,
                              Description=clt.Description,
                              ClientBuiisnessEmail=clt.ClientBuiisnessEmail,
                              PrimaryContactName=clt.PrimaryContactName,
                              PrimaryContactEmail=clt.PrimaryContactEmail,
                              PrimaryContactCountry=clt.PrimarContactCountry,
                              PrimaryContactState=clt.PrimarContactState,
                              PrimaryContactCity=clt.PrimarContactCity,
                              PrimaryContactAddress=clt.PrimarContactAddress,
                              Username=clt.Username,
                              CreatedOn=clt.CreatedOn,
                              LastLogin=clt.LastLogin,
                              AccountStatus=clt.AccountStatus
                         };
            return result;
        }
    }
}
