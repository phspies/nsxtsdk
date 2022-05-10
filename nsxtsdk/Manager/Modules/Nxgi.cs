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
    public class Nxgi
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public Nxgi(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTSolutionConfigType> UpdateSolutionConfig(string ServiceId, string SolutionConfigId, NSXTSolutionConfigType SolutionConfig)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SolutionConfigId == null) { throw new System.ArgumentNullException("SolutionConfigId cannot be null"); }
            if (SolutionConfig == null) { throw new System.ArgumentNullException("SolutionConfig cannot be null"); }
            StringBuilder UpdateSolutionConfigServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/solution-configs/{solution-config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateSolutionConfigServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateSolutionConfigServiceURL.Replace("{solution-config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SolutionConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SolutionConfig);
            request.Resource = UpdateSolutionConfigServiceURL.ToString();
            RestResponse<NSXTSolutionConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSolutionConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateSolutionConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSolutionConfigType> GetSolutionConfig(string ServiceId, string SolutionConfigId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SolutionConfigId == null) { throw new System.ArgumentNullException("SolutionConfigId cannot be null"); }
            StringBuilder GetSolutionConfigServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/solution-configs/{solution-config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetSolutionConfigServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetSolutionConfigServiceURL.Replace("{solution-config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SolutionConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetSolutionConfigServiceURL.ToString();
            RestResponse<NSXTSolutionConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSolutionConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetSolutionConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteSolutionConfig(string ServiceId, string SolutionConfigId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SolutionConfigId == null) { throw new System.ArgumentNullException("SolutionConfigId cannot be null"); }
            StringBuilder DeleteSolutionConfigServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/solution-configs/{solution-config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteSolutionConfigServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteSolutionConfigServiceURL.Replace("{solution-config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SolutionConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteSolutionConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteSolutionConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSolutionConfigType> CreateSolutionConfig(string ServiceId, NSXTSolutionConfigType SolutionConfig)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SolutionConfig == null) { throw new System.ArgumentNullException("SolutionConfig cannot be null"); }
            StringBuilder CreateSolutionConfigServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/solution-configs");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CreateSolutionConfigServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SolutionConfig);
            request.Resource = CreateSolutionConfigServiceURL.ToString();
            RestResponse<NSXTSolutionConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSolutionConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateSolutionConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSolutionConfigListResultType> ListSolutionConfigs(string ServiceId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder ListSolutionConfigsServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/solution-configs");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListSolutionConfigsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ListSolutionConfigsServiceURL.ToString();
            RestResponse<NSXTSolutionConfigListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSolutionConfigListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListSolutionConfigsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTExtendedSolutionConfigType> UpdateExtendedSolutionConfig(string ServiceId, string SolutionConfigId, NSXTExtendedSolutionConfigType ExtendedSolutionConfig)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SolutionConfigId == null) { throw new System.ArgumentNullException("SolutionConfigId cannot be null"); }
            if (ExtendedSolutionConfig == null) { throw new System.ArgumentNullException("ExtendedSolutionConfig cannot be null"); }
            StringBuilder UpdateExtendedSolutionConfigServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/solution-configs/{solution-config-id}/extended-solution-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateExtendedSolutionConfigServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateExtendedSolutionConfigServiceURL.Replace("{solution-config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SolutionConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ExtendedSolutionConfig);
            request.Resource = UpdateExtendedSolutionConfigServiceURL.ToString();
            RestResponse<NSXTExtendedSolutionConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTExtendedSolutionConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateExtendedSolutionConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTExtendedSolutionConfigType> CreateExtendedSolutionConfig(string ServiceId, string SolutionConfigId, NSXTExtendedSolutionConfigType ExtendedSolutionConfig)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SolutionConfigId == null) { throw new System.ArgumentNullException("SolutionConfigId cannot be null"); }
            if (ExtendedSolutionConfig == null) { throw new System.ArgumentNullException("ExtendedSolutionConfig cannot be null"); }
            StringBuilder CreateExtendedSolutionConfigServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/solution-configs/{solution-config-id}/extended-solution-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CreateExtendedSolutionConfigServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateExtendedSolutionConfigServiceURL.Replace("{solution-config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SolutionConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ExtendedSolutionConfig);
            request.Resource = CreateExtendedSolutionConfigServiceURL.ToString();
            RestResponse<NSXTExtendedSolutionConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTExtendedSolutionConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateExtendedSolutionConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTExtendedSolutionConfigType> GetExtendedSolutionConfig(string ServiceId, string SolutionConfigId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SolutionConfigId == null) { throw new System.ArgumentNullException("SolutionConfigId cannot be null"); }
            StringBuilder GetExtendedSolutionConfigServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/solution-configs/{solution-config-id}/extended-solution-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetExtendedSolutionConfigServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetExtendedSolutionConfigServiceURL.Replace("{solution-config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SolutionConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetExtendedSolutionConfigServiceURL.ToString();
            RestResponse<NSXTExtendedSolutionConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTExtendedSolutionConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetExtendedSolutionConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteExtendedSolutionConfig(string ServiceId, string SolutionConfigId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SolutionConfigId == null) { throw new System.ArgumentNullException("SolutionConfigId cannot be null"); }
            StringBuilder DeleteExtendedSolutionConfigServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/solution-configs/{solution-config-id}/extended-solution-config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteExtendedSolutionConfigServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteExtendedSolutionConfigServiceURL.Replace("{solution-config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SolutionConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteExtendedSolutionConfigServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteExtendedSolutionConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
