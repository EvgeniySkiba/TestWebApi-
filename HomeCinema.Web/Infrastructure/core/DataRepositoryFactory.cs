using HomeCinema.Data.Repositories;
using HomeCinema.Entities;
using HomeCinema.Web.Infrastructure.HttpRequestMessage;

namespace HomeCinema.Web.Infrastructure.core
{
    public interface IDataRepositoryFactory
    {
        IEntityBaseRepository<T> GetDataRepository<T>(System.Net.Http.HttpRequestMessage request) where T : class, IEntityBase, new();
    }

    public class DataRepositoryFactory//: IDataRepositoryFactory
    {
        public IEntityBaseRepository<T> GetDataRepository<T>(System.Net.Http.HttpRequestMessage request) where T : class, IEntityBase, new()
        {
            return request.GetDataRepository<T>();
        }
    }


}