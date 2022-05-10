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
    public class IDSProfile
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public IDSProfile(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTIDSProfileType> GetIdsprofile(string IdsProfileId)
        {
            if (IdsProfileId == null) { throw new System.ArgumentNullException("IdsProfileId cannot be null"); }
            StringBuilder GetIdsprofileServiceURL = new StringBuilder("/intrusion-services/profiles/{ids-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetIdsprofileServiceURL.Replace("{ids-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IdsProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetIdsprofileServiceURL.ToString();
            RestResponse<NSXTIDSProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIDSProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIdsprofileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
