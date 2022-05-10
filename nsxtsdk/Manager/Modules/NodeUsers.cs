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
    public class NodeUsers
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NodeUsers(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTNodeUserPropertiesType> UpdateNodeUser(string Userid, NSXTNodeUserPropertiesType NodeUserProperties)
        {
            if (Userid == null) { throw new System.ArgumentNullException("Userid cannot be null"); }
            if (NodeUserProperties == null) { throw new System.ArgumentNullException("NodeUserProperties cannot be null"); }
            StringBuilder UpdateNodeUserServiceURL = new StringBuilder("/node/users/{userid}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateNodeUserServiceURL.Replace("{userid}", System.Uri.EscapeDataString(Helpers.ConvertToString(Userid, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(NodeUserProperties);
            request.Resource = UpdateNodeUserServiceURL.ToString();
            RestResponse<NSXTNodeUserPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeUserPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateNodeUserServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeUserPropertiesType> ReadNodeUser(string Userid)
        {
            if (Userid == null) { throw new System.ArgumentNullException("Userid cannot be null"); }
            StringBuilder ReadNodeUserServiceURL = new StringBuilder("/node/users/{userid}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadNodeUserServiceURL.Replace("{userid}", System.Uri.EscapeDataString(Helpers.ConvertToString(Userid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadNodeUserServiceURL.ToString();
            RestResponse<NSXTNodeUserPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeUserPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadNodeUserServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteNodeUserSshKeyRemoveSshKey(string Userid, NSXTSshKeyBasePropertiesType SshKeyBaseProperties)
        {
            if (Userid == null) { throw new System.ArgumentNullException("Userid cannot be null"); }
            if (SshKeyBaseProperties == null) { throw new System.ArgumentNullException("SshKeyBaseProperties cannot be null"); }
            StringBuilder DeleteNodeUserSshKeyRemoveSshKeyServiceURL = new StringBuilder("/node/users/{userid}/ssh-keys?action=remove_ssh_key");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            DeleteNodeUserSshKeyRemoveSshKeyServiceURL.Replace("{userid}", System.Uri.EscapeDataString(Helpers.ConvertToString(Userid, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SshKeyBaseProperties);
            request.Resource = DeleteNodeUserSshKeyRemoveSshKeyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + DeleteNodeUserSshKeyRemoveSshKeyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task AddNodeUserSshKeyAddSshKey(string Userid, NSXTSshKeyPropertiesType SshKeyProperties)
        {
            if (Userid == null) { throw new System.ArgumentNullException("Userid cannot be null"); }
            if (SshKeyProperties == null) { throw new System.ArgumentNullException("SshKeyProperties cannot be null"); }
            StringBuilder AddNodeUserSshKeyAddSshKeyServiceURL = new StringBuilder("/node/users/{userid}/ssh-keys?action=add_ssh_key");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            AddNodeUserSshKeyAddSshKeyServiceURL.Replace("{userid}", System.Uri.EscapeDataString(Helpers.ConvertToString(Userid, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SshKeyProperties);
            request.Resource = AddNodeUserSshKeyAddSshKeyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddNodeUserSshKeyAddSshKeyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeUserPropertiesListResultType> ListNodeUsers()
        {
            StringBuilder ListNodeUsersServiceURL = new StringBuilder("/node/users");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListNodeUsersServiceURL.ToString();
            RestResponse<NSXTNodeUserPropertiesListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeUserPropertiesListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListNodeUsersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSshKeyPropertiesListResultType> ListNodeUserSshKeys(string Userid)
        {
            if (Userid == null) { throw new System.ArgumentNullException("Userid cannot be null"); }
            StringBuilder ListNodeUserSshKeysServiceURL = new StringBuilder("/node/users/{userid}/ssh-keys");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListNodeUserSshKeysServiceURL.Replace("{userid}", System.Uri.EscapeDataString(Helpers.ConvertToString(Userid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ListNodeUserSshKeysServiceURL.ToString();
            RestResponse<NSXTSshKeyPropertiesListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSshKeyPropertiesListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListNodeUserSshKeysServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
