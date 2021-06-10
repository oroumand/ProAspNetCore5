using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Session14.HttpClientSamples.Models
{
    public class ValidateApiKeyExists : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(
                        HttpRequestMessage request,
                        CancellationToken cancellationToken)
        {
            if (!request.Headers.Contains("X-API-KEY"))
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent(
                        "You must supply an API key header called X-API-KEY")
                };
            }

            return await base.SendAsync(request, cancellationToken);
        }

    }

    public class AddApiKey : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(
                        HttpRequestMessage request,
                        CancellationToken cancellationToken)
        {
            if (!request.Headers.Contains("X-API-KEY"))
            {
                request.Headers.Add("X-API-KEY", "MyApiKey");
            }

            return await base.SendAsync(request, cancellationToken);
        }

    }
}
