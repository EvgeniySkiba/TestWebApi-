using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Dependencies;
using HomeCinema.Services.Abstract;
using HomeCinema.Data.Repositories;
using HomeCinema.Entities;

namespace HomeCinema.Web.Infrastructure.HttpRequestMessage
{
    public static class RequestMessageExtensions
    {
        internal static IMembershipService GetMembershipService(this System.Net.Http.HttpRequestMessage request)
        {
            return request.GetService<IMembershipService>();
        }

        private static TService GetService<TService>(this System.Net.Http.HttpRequestMessage request)
        {
            IDependencyScope dependencyScope = request.GetDependencyScope();
            TService service = (TService)dependencyScope.GetService(typeof(TService));

            return service;
        }

        internal static IEntityBaseRepository<T> GetDataRepository<T>(this System.Net.Http.HttpRequestMessage request) where T : class, IEntityBase, new()
        {
            return request.GetService<IEntityBaseRepository<T>>();

        }
    }
}