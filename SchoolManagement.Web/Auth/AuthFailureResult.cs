using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace SchoolManagement.Web
{
    public class AuthFailureResult : IHttpActionResult
    {
        public AuthFailureResult(string reasonPhrase, HttpRequestMessage httpRequest)
        {
            this.ReasonPhrase = reasonPhrase;
            this.Request = httpRequest;
        }

        public string ReasonPhrase { get; private set; }
        public HttpRequestMessage Request { get; private set; }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            HttpResponseMessage httpResponse = new HttpResponseMessage(HttpStatusCode.Unauthorized)
            {
                ReasonPhrase = this.ReasonPhrase,
                RequestMessage = Request
            };

            return Task.FromResult(httpResponse);
        }
    }
}