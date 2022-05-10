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
    public class NodeMandatoryAccessControlModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NodeMandatoryAccessControlModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task GetNodeMandatoryAccessControlReport()
        {
            StringBuilder GetNodeMandatoryAccessControlReportServiceURL = new StringBuilder("/node/hardening-policy/mandatory-access-control/report");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetNodeMandatoryAccessControlReportServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetNodeMandatoryAccessControlReportServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMandatoryAccessControlPropertiesType> SetNodeMandatoryAccessControl(NSXTMandatoryAccessControlPropertiesType MandatoryAccessControlProperties)
        {
            if (MandatoryAccessControlProperties == null) { throw new System.ArgumentNullException("MandatoryAccessControlProperties cannot be null"); }
            StringBuilder SetNodeMandatoryAccessControlServiceURL = new StringBuilder("/node/hardening-policy/mandatory-access-control");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(MandatoryAccessControlProperties);
            request.Resource = SetNodeMandatoryAccessControlServiceURL.ToString();
            RestResponse<NSXTMandatoryAccessControlPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMandatoryAccessControlPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + SetNodeMandatoryAccessControlServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMandatoryAccessControlPropertiesType> GetNodeMandatoryAccessControl()
        {
            StringBuilder GetNodeMandatoryAccessControlServiceURL = new StringBuilder("/node/hardening-policy/mandatory-access-control");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetNodeMandatoryAccessControlServiceURL.ToString();
            RestResponse<NSXTMandatoryAccessControlPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMandatoryAccessControlPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetNodeMandatoryAccessControlServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
