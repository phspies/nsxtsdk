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
    public class SystemHealthAgent
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public SystemHealthAgent(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTSystemHealthAgentProfileType> UpdateSystemHealthAgentProfile(string ProfileId, NSXTSystemHealthAgentProfileType SystemHealthAgentProfile)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            if (SystemHealthAgentProfile == null) { throw new System.ArgumentNullException("SystemHealthAgentProfile cannot be null"); }
            StringBuilder UpdateSystemHealthAgentProfileServiceURL = new StringBuilder("/systemhealth/profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateSystemHealthAgentProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SystemHealthAgentProfile);
            request.Resource = UpdateSystemHealthAgentProfileServiceURL.ToString();
            RestResponse<NSXTSystemHealthAgentProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSystemHealthAgentProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateSystemHealthAgentProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSystemHealthAgentProfileType> ShowSystemHealthAgentProfile(string ProfileId)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            StringBuilder ShowSystemHealthAgentProfileServiceURL = new StringBuilder("/systemhealth/profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ShowSystemHealthAgentProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ShowSystemHealthAgentProfileServiceURL.ToString();
            RestResponse<NSXTSystemHealthAgentProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSystemHealthAgentProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ShowSystemHealthAgentProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteSystemHealthAgentProfile(string ProfileId)
        {
            if (ProfileId == null) { throw new System.ArgumentNullException("ProfileId cannot be null"); }
            StringBuilder DeleteSystemHealthAgentProfileServiceURL = new StringBuilder("/systemhealth/profiles/{profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteSystemHealthAgentProfileServiceURL.Replace("{profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteSystemHealthAgentProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteSystemHealthAgentProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSystemHealthAgentProfileType> CreateSystemHealthAgentProfile(NSXTSystemHealthAgentProfileType SystemHealthAgentProfile)
        {
            if (SystemHealthAgentProfile == null) { throw new System.ArgumentNullException("SystemHealthAgentProfile cannot be null"); }
            StringBuilder CreateSystemHealthAgentProfileServiceURL = new StringBuilder("/systemhealth/profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(SystemHealthAgentProfile);
            request.Resource = CreateSystemHealthAgentProfileServiceURL.ToString();
            RestResponse<NSXTSystemHealthAgentProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSystemHealthAgentProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateSystemHealthAgentProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSystemHealthAgentProfileListResultType> ListSystemHealthAgentProfiles()
        {
            StringBuilder ListSystemHealthAgentProfilesServiceURL = new StringBuilder("/systemhealth/profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListSystemHealthAgentProfilesServiceURL.ToString();
            RestResponse<NSXTSystemHealthAgentProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSystemHealthAgentProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListSystemHealthAgentProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
