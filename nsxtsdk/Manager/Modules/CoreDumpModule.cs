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
    public class CoreDumpModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public CoreDumpModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task CopyCoreDumpToRemoteFileCopyToRemoteFile(string FileName, NSXTCopyToRemoteFilePropertiesType CopyToRemoteFileProperties)
        {
            if (FileName == null) { throw new System.ArgumentNullException("FileName cannot be null"); }
            if (CopyToRemoteFileProperties == null) { throw new System.ArgumentNullException("CopyToRemoteFileProperties cannot be null"); }
            StringBuilder CopyCoreDumpToRemoteFileCopyToRemoteFileServiceURL = new StringBuilder("/node/core-dumps/{file-name}?action=copy_to_remote_file");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CopyCoreDumpToRemoteFileCopyToRemoteFileServiceURL.Replace("{file-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(FileName, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(CopyToRemoteFileProperties);
            request.Resource = CopyCoreDumpToRemoteFileCopyToRemoteFileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CopyCoreDumpToRemoteFileCopyToRemoteFileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFilePropertiesListResultType> ListCoreDumps()
        {
            StringBuilder ListCoreDumpsServiceURL = new StringBuilder("/node/core-dumps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListCoreDumpsServiceURL.ToString();
            RestResponse<NSXTFilePropertiesListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFilePropertiesListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListCoreDumpsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
