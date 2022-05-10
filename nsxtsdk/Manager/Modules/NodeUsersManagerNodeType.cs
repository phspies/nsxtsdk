using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Newtonsoft.Json;
using System.Net;
using nsxtsdk;
using nsxtsdk.Models;
using nsxtsdk.ManagerModels;

namespace nsxtapi.ManagerModules
{
    public class NodeUsersManagerNodeType
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NodeUsersManagerNodeType(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task ResetNodeUserPasswordResetPassword(string Userid, NSXTNodeUserPasswordPropertyType NodeUserPasswordProperty)
        {
            if (Userid == null) { throw new System.ArgumentNullException("Userid cannot be null"); }
            if (NodeUserPasswordProperty == null) { throw new System.ArgumentNullException("NodeUserPasswordProperty cannot be null"); }
            StringBuilder ResetNodeUserPasswordResetPasswordServiceURL = new StringBuilder("/node/users/{userid}?action=reset_password");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ResetNodeUserPasswordResetPasswordServiceURL.Replace("{userid}", System.Uri.EscapeDataString(Helpers.ConvertToString(Userid, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(NodeUserPasswordProperty);
            request.Resource = ResetNodeUserPasswordResetPasswordServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ResetNodeUserPasswordResetPasswordServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeUserPropertiesType> ActivateNodeUserActivate(string Userid, NSXTNodeUserPasswordPropertyType NodeUserPasswordProperty)
        {
            if (Userid == null) { throw new System.ArgumentNullException("Userid cannot be null"); }
            if (NodeUserPasswordProperty == null) { throw new System.ArgumentNullException("NodeUserPasswordProperty cannot be null"); }
            StringBuilder ActivateNodeUserActivateServiceURL = new StringBuilder("/node/users/{userid}?action=activate");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ActivateNodeUserActivateServiceURL.Replace("{userid}", System.Uri.EscapeDataString(Helpers.ConvertToString(Userid, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(NodeUserPasswordProperty);
            request.Resource = ActivateNodeUserActivateServiceURL.ToString();
            RestResponse<NSXTNodeUserPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeUserPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ActivateNodeUserActivateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeUserPropertiesType> DeactivateNodeUserDeactivate(string Userid)
        {
            if (Userid == null) { throw new System.ArgumentNullException("Userid cannot be null"); }
            StringBuilder DeactivateNodeUserDeactivateServiceURL = new StringBuilder("/node/users/{userid}?action=deactivate");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            DeactivateNodeUserDeactivateServiceURL.Replace("{userid}", System.Uri.EscapeDataString(Helpers.ConvertToString(Userid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeactivateNodeUserDeactivateServiceURL.ToString();
            RestResponse<NSXTNodeUserPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeUserPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + DeactivateNodeUserDeactivateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task ResetNodeUserOwnPasswordResetOwnPassword(NSXTResetNodeUserOwnPasswordPropertiesType ResetNodeUserOwnPasswordProperties)
        {
            if (ResetNodeUserOwnPasswordProperties == null) { throw new System.ArgumentNullException("ResetNodeUserOwnPasswordProperties cannot be null"); }
            StringBuilder ResetNodeUserOwnPasswordResetOwnPasswordServiceURL = new StringBuilder("/node/users?action=reset_own_password");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(ResetNodeUserOwnPasswordProperties);
            request.Resource = ResetNodeUserOwnPasswordResetOwnPasswordServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ResetNodeUserOwnPasswordResetOwnPasswordServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
