using System;
using Test.Product.WebApi.Models;

namespace Test.Product.WebApi.Services
{
    public class SiteService
    {
        private static Guid _instanceId = Guid.NewGuid();
        
        public SiteModel GetById(string id)
        {
            return new SiteModel
            {
                Id = id,
                Name = $"Random-{DateTime.Now}",
                InstanceId = _instanceId.ToString()
            };
        }
    }
}
