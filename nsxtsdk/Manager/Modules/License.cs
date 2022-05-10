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
    public class License
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public License(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTLicenseType> GetLicenseByKey(string LicenseKey)
        {
            if (LicenseKey == null) { throw new System.ArgumentNullException("LicenseKey cannot be null"); }
            StringBuilder GetLicenseByKeyServiceURL = new StringBuilder("/licenses/{license-key}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetLicenseByKeyServiceURL.Replace("{license-key}", System.Uri.EscapeDataString(Helpers.ConvertToString(LicenseKey, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetLicenseByKeyServiceURL.ToString();
            RestResponse<NSXTLicenseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLicenseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLicenseByKeyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteLicense(string LicenseKey)
        {
            if (LicenseKey == null) { throw new System.ArgumentNullException("LicenseKey cannot be null"); }
            StringBuilder DeleteLicenseServiceURL = new StringBuilder("/licenses/{license-key}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteLicenseServiceURL.Replace("{license-key}", System.Uri.EscapeDataString(Helpers.ConvertToString(LicenseKey, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteLicenseServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteLicenseServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFeatureUsageListType> GetLicenseUsageReport()
        {
            StringBuilder GetLicenseUsageReportServiceURL = new StringBuilder("/licenses/licenses-usage");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetLicenseUsageReportServiceURL.ToString();
            RestResponse<NSXTFeatureUsageListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFeatureUsageListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLicenseUsageReportServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLicenseType> UpdateLicense(NSXTLicenseType License)
        {
            if (License == null) { throw new System.ArgumentNullException("License cannot be null"); }
            StringBuilder UpdateLicenseServiceURL = new StringBuilder("/license");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(License);
            request.Resource = UpdateLicenseServiceURL.ToString();
            RestResponse<NSXTLicenseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLicenseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateLicenseServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLicenseType> GetLicense()
        {
            StringBuilder GetLicenseServiceURL = new StringBuilder("/license");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetLicenseServiceURL.ToString();
            RestResponse<NSXTLicenseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLicenseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLicenseServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFeatureUsageListInCsvFormatType> GetLicenseUsageReportInCsvFormat()
        {
            StringBuilder GetLicenseUsageReportInCsvFormatServiceURL = new StringBuilder("/licenses/licenses-usage?format=csv");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetLicenseUsageReportInCsvFormatServiceURL.ToString();
            RestResponse<NSXTFeatureUsageListInCsvFormatType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFeatureUsageListInCsvFormatType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLicenseUsageReportInCsvFormatServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteLicenseKey(NSXTLicenseType License)
        {
            if (License == null) { throw new System.ArgumentNullException("License cannot be null"); }
            StringBuilder DeleteLicenseKeyServiceURL = new StringBuilder("/licenses?action=delete");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(License);
            request.Resource = DeleteLicenseKeyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + DeleteLicenseKeyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLicenseType> CreateLicense(NSXTLicenseType License)
        {
            if (License == null) { throw new System.ArgumentNullException("License cannot be null"); }
            StringBuilder CreateLicenseServiceURL = new StringBuilder("/licenses");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(License);
            request.Resource = CreateLicenseServiceURL.ToString();
            RestResponse<NSXTLicenseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLicenseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateLicenseServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTLicensesListResultType> GetLicenses()
        {
            StringBuilder GetLicensesServiceURL = new StringBuilder("/licenses");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetLicensesServiceURL.ToString();
            RestResponse<NSXTLicensesListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTLicensesListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetLicensesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
