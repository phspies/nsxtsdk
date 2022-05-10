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
    public class ClusterCertificate
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public ClusterCertificate(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTClusterCertificateIdType> SetClusterCertificateSetClusterCertificate(string CertificateId)
        {
            if (CertificateId == null) { throw new System.ArgumentNullException("CertificateId cannot be null"); }
            StringBuilder SetClusterCertificateSetClusterCertificateServiceURL = new StringBuilder("/cluster/api-certificate?action=set_cluster_certificate");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            if (CertificateId != null) { request.AddQueryParameter("certificate_id", CertificateId.ToString()); }
            request.Resource = SetClusterCertificateSetClusterCertificateServiceURL.ToString();
            RestResponse<NSXTClusterCertificateIdType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTClusterCertificateIdType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + SetClusterCertificateSetClusterCertificateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTClusterCertificateIdType> ClearClusterCertificateClearClusterCertificate(string CertificateId)
        {
            if (CertificateId == null) { throw new System.ArgumentNullException("CertificateId cannot be null"); }
            StringBuilder ClearClusterCertificateClearClusterCertificateServiceURL = new StringBuilder("/cluster/api-certificate?action=clear_cluster_certificate");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            if (CertificateId != null) { request.AddQueryParameter("certificate_id", CertificateId.ToString()); }
            request.Resource = ClearClusterCertificateClearClusterCertificateServiceURL.ToString();
            RestResponse<NSXTClusterCertificateIdType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTClusterCertificateIdType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ClearClusterCertificateClearClusterCertificateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTClusterCertificateIdType> GetClusterCertificateId()
        {
            StringBuilder GetClusterCertificateIdServiceURL = new StringBuilder("/cluster/api-certificate");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetClusterCertificateIdServiceURL.ToString();
            RestResponse<NSXTClusterCertificateIdType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTClusterCertificateIdType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetClusterCertificateIdServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
