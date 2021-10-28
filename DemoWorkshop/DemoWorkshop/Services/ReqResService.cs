using DemoWorkshop.Library.Interfaces;
using DemoWorkshop.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

namespace DemoWorkshop.Services
{
    public class ReqResService : IReqResData
    {
        private readonly HttpClient httpClient;
        private CancellationTokenSource cancellationTokensource;

        public ReqResService(IHttpClientFactory httpClientFactory)
        {
            this.httpClient = httpClientFactory.CreateClient("reqres");
            cancellationTokensource = new CancellationTokenSource();
        }

        public void CancelRequest()
        {
            cancellationTokensource.Cancel();
        }

        public async Task<HttpStatusCode> CreaUtente(ReqResPost nuovoutente)
        {
            using var response = await httpClient.PostAsJsonAsync<ReqResPost>("api/users",
                nuovoutente);

            return response.StatusCode;
        }

        public async Task<ReqResData> EstraiDati()
        {
            var data = new ReqResData();
            using var response = await httpClient.GetAsync("api/users",
                HttpCompletionOption.ResponseHeadersRead,
                cancellationTokensource.Token);

            if (response.IsSuccessStatusCode)
            {
                data = await response.Content.ReadFromJsonAsync<ReqResData>();
            }
            return data;
        }
    }
}
