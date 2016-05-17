using Cheesebaron.MvxPlugins.Connectivity;
using ModernHttpClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
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
        IConnectivity Connectivity { get; set; }

        /// <summary>
        /// Método para deserializar 
        /// </summary>
        /// <typeparam name="R">Tipo del objeto a desserializar</typeparam>
        /// <param name="json">String a deserializar</param>
        /// <returns>Objeto del tipo seleccionado</returns>
        Task<R> DeserializeAsync<R>(string json);

        /// <summary>
        /// Método para serealizar
        /// </summary>
        /// <typeparam name="T">Tipo de objeto a serializar</typeparam>
        /// <param name="payload">Objeto a serializar</param>
        /// <returns>String con el objeto en json</returns>
        Task<string> SerializeAsync<T>(T payload);

        Task<string> RequestAsync(string endpoint, string payload, HttpMethod method, CancellationToken token);
        Task<string> RequestAPIAsync(string endpoint, string payload, HttpMethod method, CancellationToken token);
    }
    public class WebAPIService : IWebAPIService
    {
        public IConnectivity Connectivity
        {
            get;
            set;
        }

        public WebAPIService(IConnectivity connectivity)
        {
            Connectivity = connectivity;
        }

        public async Task<string> RequestAPIAsync(string endpoint, string payload, HttpMethod method, CancellationToken token)
        {
            if (token.IsCancellationRequested)
                return null;


            if (!Connectivity.IsConnected)
            {
                throw new NotConnectedException("Not Connected");
            }

            using(var apiClient = new EngineApiClient(new NativeMessageHandler()))
            {

            }

            return null;
        }

        public async Task<string> RequestAsync(string endpoint, string payload, HttpMethod method, CancellationToken token)
        {
            if (token.IsCancellationRequested)
                return null;


            if (!Connectivity.IsConnected)
            {
                throw new NotConnectedException("Not Connected");
            }

            using (var httpClient = new HttpClient(new NativeMessageHandler()))
            {

            }

            return null;
        }

        public async Task<R> DeserializeAsync<R>(string json)
        {
            return await
                Task.Run(
                    () => JsonConvert.DeserializeObject<R>(json))
                    .ConfigureAwait(false);
        }

        public async Task<string> SerializeAsync<T>(T payload)
        {
            return await
                Task.Run(
                    () => JsonConvert.SerializeObject(payload, Formatting.None, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore }))
                    .ConfigureAwait(false);
        }
    }
}
