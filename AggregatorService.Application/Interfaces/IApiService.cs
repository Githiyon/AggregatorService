using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregatorService.Application.Interfaces
{
    public interface IApiService
    {
        #region GET/POST/PUT/DELETE
        /// <summary>
        /// Get Http Client request
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serviceName"></param>
        /// <param name="endpointPath"></param>
        /// <param name="useDefaultQueryString"></param>
        /// <param name="useAuthToken"></param>
        /// <returns></returns>
        Task<T> GetAsync<T>(string serviceName, string endpointPath, bool useDefaultQueryString = false, bool useAuthToken = true);
        /// <summary>
        /// Post Http client request
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serviceName"></param>
        /// <param name="endpointPath"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        Task<T> PostAsync<T>(string serviceName, string endpointPath, object data = null);
        /// <summary>
        /// Patch Http client request
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serviceName"></param>
        /// <param name="endpointPath"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        Task<T> PatchAsync<T>(string serviceName, string endpointPath, object data = null);
        #endregion
    }
}
