using Cheesebaron.MvxPlugins.Connectivity;
using ModernHttpClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Core.Services
{
    public class NotConnectedException : Exception
    {
        public NotConnectedException(string message) :base(message)
        {
        }
    }
    public interface IWebAPIService
    {
        IConnectivity ConnectivityService { get; set; }
        Task<string> RequestAsync(string endpoint, string payload, HttpMethod method);
        Task<string> RequestAsyncAPI(string endpoint, string payload, HttpMethod method);
    }
    public class WebAPIService : IWebAPIService
    {
        public IConnectivity ConnectivityService
        {
            get;
            set;
        }

        public WebAPIService()
        {

        }

        public async Task<string> RequestAsyncAPI(string endpoint, string payload, HttpMethod method)
        {
            if (!ConnectivityService.IsConnected)
            {
                throw new NotConnectedException("Not Connected");
            }

            using(var apiClient = new EngineApiClient(new NativeMessageHandler()))
            {

            }

            return null;
        }

        public async Task<string> RequestAsync(string endpoint, string payload, HttpMethod method)
        {
            if (!ConnectivityService.IsConnected)
            {
                throw new NotConnectedException("Not Connected");
            }

            using (var httpClient = new HttpClient(new NativeMessageHandler()))
            {

            }

            return null;
        }
    }
}
