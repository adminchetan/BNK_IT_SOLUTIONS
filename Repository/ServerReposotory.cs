using Uttaraonline.DBConfig;
using Uttaraonline.Interfaces;

namespace Uttaraonline.Repository
{
    public class ServerReposotory : IServer
    {
        private readonly DBContextProduction _dBContextProduction;

        public ServerReposotory(DBContextProduction dBContextProduction)
        {
            _dBContextProduction = dBContextProduction;
        }
        public IQueryable<object> GetDomainDetails(int query)
        {
            var result = from domain in  _dBContextProduction.tbl_ClientDomainsDetails
                         join client in _dBContextProduction.tbl_ClientMasters on domain.ClientId equals client.Id
                         select new
                         {
                             ClintName=client.ClientName,
                             ClientPrimaryContact=client.PrimaryContactName,
                             domainIp = domain.ServerIP,
                             domeinRegistration=domain.RegistrationDate,
                             domainValidity=domain.Validity,
                             domainExpiary=domain.ExpiaryDate,
                             domainName=domain.DomainName,
                             domainDetails=domain.DomainDetails
                         };

            return result;
        }   
        
        public IQueryable<object> getCompleteHostingDetailsOfUser(int query)
        {
            var result = from client in _dBContextProduction.tbl_ClientMasters
                         join server in _dBContextProduction.tbl_ClientHostingDetails on client.Id equals server.ClientId
                         join domain in _dBContextProduction.tbl_ClientDomainsDetails on client.Id equals domain.ClientId
                         join hosting in _dBContextProduction.tbl_HostingDetails on server.HostingDetails equals hosting.Id
                         select new
                         {

                             ClintName = client.ClientName,
                             ClientPrimaryContact = client.PrimaryContactName,
                             
                             serverId = server.HostingId,
                             serverIp = server.ServerIP,
                             serverRegistration = server.RegistrationDate,
                             serverValidity = server.Validity,
                             severExpiary = server.ExpiaryDate,
                             serverHostingName = server.HostingName,
                             serverHostingDetails = server.HostingDetails,

                             domainIp = domain.ServerIP,
                             domeinRegistration = domain.RegistrationDate,
                             domainValidity = domain.Validity,
                             domainExpiary = domain.ExpiaryDate,
                             domainName = domain.DomainName,
                             domainDetails = domain.DomainDetails,

                             HostingName =hosting.Name,
                             HostingMonthlyBandwidth =hosting.MonthlyBandwidth,
                             HostingStorage =hosting.Storage,
                             HostingEmailAllowed =hosting.EmailAccount,
                             HostingType =hosting.EmailAccount,
                             HostingBackup =hosting.Backup,
                             HostingAccessToCpannel =hosting.AccessToCpannel,
                             HostingAccessToFTP =hosting.AccessToFTP,
                             HostingOutlet =hosting.Outlet,
                             HostingWholesale =hosting.Wholesale,
                             HostingCGST =hosting.CGST,
                             HostingSGST =hosting.SGST,
                             HostingMSRP =hosting.MSRP,
                             HostingDescription =hosting.Description

                         };

            return result;
        }

        public IQueryable<object> GetBasicServerDetailsOfUser(int query)
        {
            var result = from server in _dBContextProduction.tbl_ClientHostingDetails
                         join client in _dBContextProduction.tbl_ClientMasters on server.ClientId equals client.Id
                         select new
                         {
                             ClintName = client.ClientName,
                             ClientPrimaryContact = client.PrimaryContactName,
                             serverId = server.HostingId,
                             serverIp = server.ServerIP,
                             serverRegistration = server.RegistrationDate,
                             serverValidity = server.Validity,
                             severExpiary = server.ExpiaryDate,
                             serverHostingName = server.HostingName,
                             serverHostingDetails = server.HostingDetails
                         };

            return result;
        }

        public IQueryable<object> getCompleteDomainDetailsOfUser(int query)
        {
            var result = from  clientdomain in _dBContextProduction.tbl_ClientDomainsDetails
                         join masterdomain in _dBContextProduction.tbl_DomainsDetails on clientdomain.DomainDetails equals masterdomain.Id
                         join client in _dBContextProduction.tbl_ClientMasters on clientdomain.ClientId equals client.Id
                         select new
                         {
                             ClintName = client.ClientName,
                             ClientPrimaryContact = client.PrimaryContactName,
                             name = masterdomain.Name,
                             type = masterdomain.Type,
                             nameserver1 = masterdomain.nameServer1,
                             nameserver2 = masterdomain.nameServer2,
                             nameserver3 = masterdomain.nameServer3,
                             nameserver4 = masterdomain.nameServer4,
                             msrp= masterdomain.MSRP

                         };

            return result;
        }

    
    }
}
