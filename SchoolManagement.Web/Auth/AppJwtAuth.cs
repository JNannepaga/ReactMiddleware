using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Filters;
using System.Web.Http.Results;

namespace SchoolManagement.Web
{
    public class AppJwtAuth : AuthorizeAttribute, IAuthenticationFilter
    {
        public async Task AuthenticateAsync(HttpAuthenticationContext context, CancellationToken cancellationToken)
        {
            string authParams = string.Empty;
            HttpRequestMessage httpRequest = context.Request;
            AuthenticationHeaderValue authorization = httpRequest.Headers.Authorization;
            
            //if(authorization == null)
            //{
            //    context.ErrorResult = new AuthFailureResult(reasonPhrase: "Missing Authorization Headers", httpRequest);
            //}

            //if(authorization.Scheme != "Bearer")
            //{
            //    context.ErrorResult = new AuthFailureResult(reasonPhrase: "Invalid Authorization Schema", httpRequest);
            //}

            //if (string.IsNullOrEmpty(authorization.Parameter))
            //{
            //    context.ErrorResult = new AuthFailureResult(reasonPhrase: "Missing Token", httpRequest);
            //}

            context.ErrorResult = authorization == null ? new AuthFailureResult(reasonPhrase: "Missing Authorization Headers", httpRequest) :
                                  authorization.Scheme != "Bearer" ? new AuthFailureResult(reasonPhrase: "Invalid Authorization Schema", httpRequest) :
                                  string.IsNullOrEmpty(authorization.Parameter) ? new AuthFailureResult(reasonPhrase: "Missing Token", httpRequest) : null;

            if (context.ErrorResult != null)
                return;

            context.Principal = TokenManager.GetPrincipal(authorization?.Parameter);
        }

        public async Task ChallengeAsync(HttpAuthenticationChallengeContext context, CancellationToken cancellationToken)
        {
            var result = await context.Result.ExecuteAsync(cancellationToken);
            if(result.StatusCode == HttpStatusCode.Unauthorized)
            {
                result.Headers.WwwAuthenticate.Add(new AuthenticationHeaderValue(scheme: "Basic", parameter: "realm=localhost"));
            }

            context.Result = new ResponseMessageResult(result);
        }
    }
}