namespace Uttaraonline.Interfaces
{
    public interface IServer
    {
        public IQueryable<object> getCompleteHostingDetailsOfUser(int query);
        public IQueryable<object> getCompleteDomainDetailsOfUser(int query);
        public IQueryable<object> GetDomainDetails(int query);


    }
}
