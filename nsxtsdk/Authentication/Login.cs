using Newtonsoft.Json;
using nsxtsdk.Authentication;
using nsxtsdk.ManagerModels;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace nsxtsdk.Modules
{
    public class AuthenticationHelper
    {
        public static async Task<RestResponse<LoginResponseType>> LoginAsync(LoginRequestType credentials, RestClient sessionRestClient, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            StringBuilder GetLoginURL = new StringBuilder("/api/session/create");
            var request = new RestRequest
            {
                Method = Method.Post,
            };
            request.Resource = GetLoginURL.ToString();
            request.AddObject(credentials);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");

            RestResponse<LoginResponseType> response = await sessionRestClient.ExecuteTaskAsyncWithPolicy<LoginResponseType>(request, _cancellationToken, _timeout, _retry);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                var message = "Login operation to " + GetLoginURL.ToString() + " did not complete successfully";
                throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException);
            }
            return response;
        }
        public static async Task LogoutAsync(RestClient restClient, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            StringBuilder GetLogoutURL = new StringBuilder("/api/session/destroy");
            var request = new RestRequest
            {
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            request.Resource = GetLogoutURL.ToString();
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");

            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, _cancellationToken, _timeout, _retry);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                var message = "Login operation to " + GetLogoutURL.ToString() + " did not complete successfully";
                throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException);
            }
        }
    }
}
