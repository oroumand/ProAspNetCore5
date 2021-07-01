using MediatR;
using Session16.ReceipeApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Session16.ReceipeApp.Web.Features.Receipes
{
    public class AddReceipeRequest : IRequest<int>
    {
        public AddReceipeRequest(Receipe receipe)
        {
            Receipe = receipe;
        }
        public string Path => "api/Receipes";
        public Receipe Receipe { get; }
    }

    public class AddReceipeRequestHandler : IRequestHandler<AddReceipeRequest, int>
    {
        private readonly HttpClient httpClient;

        public AddReceipeRequestHandler(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<int> Handle(AddReceipeRequest request, CancellationToken cancellationToken)
        {
            var httpResult = await httpClient.PostAsJsonAsync(request.Path, request.Receipe);
            if(httpResult.IsSuccessStatusCode)
            {
                var receipeId = await httpResult.Content.ReadFromJsonAsync<int>();
                return receipeId;
            }
            return -1;
        }
    }
}
