using AggregatorService.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregatorService.Application.Services
{
    public class ApiService() : IApiService
    {
        public Task<T> GetAsync<T>(string serviceName, string endpointPath, bool useDefaultQueryString = false, bool useAuthToken = true)
        {
            throw new NotImplementedException();
        }

        public Task<T> PatchAsync<T>(string serviceName, string endpointPath, object data = null)
        {
            throw new NotImplementedException();
        }

        public Task<T> PostAsync<T>(string serviceName, string endpointPath, object data = null)
        {
            throw new NotImplementedException();
        }
    }
}
