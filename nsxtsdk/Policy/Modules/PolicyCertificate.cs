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
using nsxtsdk.PolicyModels;

namespace nsxtapi.PolicyModules
{
    public class PolicyCertificate
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyCertificate(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTTlsCsrListResultType> ListTlsCsrs(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListTlsCsrsServiceURL = new StringBuilder("/infra/csrs");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTlsCsrsServiceURL.ToString();
            RestResponse<NSXTTlsCsrListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsCsrListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTlsCsrsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsCrlListResultType> ListTlsCrls(string? Cursor = null, bool? Details = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Type = null)
        {
            StringBuilder ListTlsCrlsServiceURL = new StringBuilder("/infra/crls");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (Details != null) { request.AddQueryParameter("details", Details.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Type != null) { request.AddQueryParameter("type", Type.ToString()); }
            request.Resource = ListTlsCrlsServiceURL.ToString();
            RestResponse<NSXTTlsCrlListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsCrlListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTlsCrlsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsCertificateListType> ListTlsCertificates(string? Cursor = null, bool? Details = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Type = null)
        {
            StringBuilder ListTlsCertificatesServiceURL = new StringBuilder("/infra/certificates");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (Details != null) { request.AddQueryParameter("details", Details.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Type != null) { request.AddQueryParameter("type", Type.ToString()); }
            request.Resource = ListTlsCertificatesServiceURL.ToString();
            RestResponse<NSXTTlsCertificateListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsCertificateListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTlsCertificatesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsCsrType> GenerateTlsCsr(string CsrId, NSXTTlsCsrType TlsCsr)
        {
            if (CsrId == null) { throw new System.ArgumentNullException("CsrId cannot be null"); }
            if (TlsCsr == null) { throw new System.ArgumentNullException("TlsCsr cannot be null"); }
            StringBuilder GenerateTlsCsrServiceURL = new StringBuilder("/infra/csrs/{csr-id}?action=create");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            GenerateTlsCsrServiceURL.Replace("{csr-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CsrId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(TlsCsr);
            request.Resource = GenerateTlsCsrServiceURL.ToString();
            RestResponse<NSXTTlsCsrType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsCsrType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + GenerateTlsCsrServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<string> GetCaBundlePemFile(string CabundleId)
        {
            if (CabundleId == null) { throw new System.ArgumentNullException("CabundleId cannot be null"); }
            StringBuilder GetCaBundlePemFileServiceURL = new StringBuilder("/infra/cabundles/{cabundle-id}/pem-file");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetCaBundlePemFileServiceURL.Replace("{cabundle-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CabundleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetCaBundlePemFileServiceURL.ToString();
            RestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetCaBundlePemFileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsCrlType> GlobalGlobalInfraGetTlsCrl(string CrlId, bool? Details = null)
        {
            if (CrlId == null) { throw new System.ArgumentNullException("CrlId cannot be null"); }
            StringBuilder GlobalInfraGetTlsCrlServiceURL = new StringBuilder("/global-infra/crls/{crl-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTlsCrlServiceURL.Replace("{crl-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CrlId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Details != null) { request.AddQueryParameter("details", Details.ToString()); }
            request.Resource = GlobalInfraGetTlsCrlServiceURL.ToString();
            RestResponse<NSXTTlsCrlType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsCrlType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTlsCrlServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsCrlListResultType> GlobalGlobalInfraListTlsCrls(string? Cursor = null, bool? Details = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Type = null)
        {
            StringBuilder GlobalInfraListTlsCrlsServiceURL = new StringBuilder("/global-infra/crls");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (Details != null) { request.AddQueryParameter("details", Details.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Type != null) { request.AddQueryParameter("type", Type.ToString()); }
            request.Resource = GlobalInfraListTlsCrlsServiceURL.ToString();
            RestResponse<NSXTTlsCrlListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsCrlListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListTlsCrlsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsCertificateListType> GlobalGlobalInfraListTlsCertificates(string? Cursor = null, bool? Details = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Type = null)
        {
            StringBuilder GlobalInfraListTlsCertificatesServiceURL = new StringBuilder("/global-infra/certificates");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (Details != null) { request.AddQueryParameter("details", Details.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Type != null) { request.AddQueryParameter("type", Type.ToString()); }
            request.Resource = GlobalInfraListTlsCertificatesServiceURL.ToString();
            RestResponse<NSXTTlsCertificateListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsCertificateListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListTlsCertificatesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsCertificateType> ImportSignedTlsCertificate(string CsrId, NSXTTlsTrustDataType TlsTrustData)
        {
            if (CsrId == null) { throw new System.ArgumentNullException("CsrId cannot be null"); }
            if (TlsTrustData == null) { throw new System.ArgumentNullException("TlsTrustData cannot be null"); }
            StringBuilder ImportSignedTlsCertificateServiceURL = new StringBuilder("/infra/csrs/{csr-id}?action=import");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ImportSignedTlsCertificateServiceURL.Replace("{csr-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CsrId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(TlsTrustData);
            request.Resource = ImportSignedTlsCertificateServiceURL.ToString();
            RestResponse<NSXTTlsCertificateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsCertificateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ImportSignedTlsCertificateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCaBundleType> AddOrReplaceCaBundle(string CabundleId, NSXTCaBundleType CaBundle)
        {
            if (CabundleId == null) { throw new System.ArgumentNullException("CabundleId cannot be null"); }
            if (CaBundle == null) { throw new System.ArgumentNullException("CaBundle cannot be null"); }
            StringBuilder AddOrReplaceCaBundleServiceURL = new StringBuilder("/infra/cabundles/{cabundle-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            AddOrReplaceCaBundleServiceURL.Replace("{cabundle-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CabundleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(CaBundle);
            request.Resource = AddOrReplaceCaBundleServiceURL.ToString();
            RestResponse<NSXTCaBundleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCaBundleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + AddOrReplaceCaBundleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCaBundleType> AddOrReplaceCaBundleUpload(string CabundleId, string File, string? Description = null, string? DisplayName = null)
        {
            if (CabundleId == null) { throw new System.ArgumentNullException("CabundleId cannot be null"); }
            if (File == null) { throw new System.ArgumentNullException("File cannot be null"); }
            StringBuilder AddOrReplaceCaBundleUploadServiceURL = new StringBuilder("/infra/cabundles/{cabundle-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            AddOrReplaceCaBundleUploadServiceURL.Replace("{cabundle-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CabundleId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Description != null) { request.AddQueryParameter("description", Description.ToString()); }
            if (DisplayName != null) { request.AddQueryParameter("display_name", DisplayName.ToString()); }
            
            request.Resource = AddOrReplaceCaBundleUploadServiceURL.ToString();
            RestResponse<NSXTCaBundleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCaBundleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddOrReplaceCaBundleUploadServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCaBundleType> AddOrPatchCaBundle(string CabundleId, NSXTCaBundleType CaBundle)
        {
            if (CabundleId == null) { throw new System.ArgumentNullException("CabundleId cannot be null"); }
            if (CaBundle == null) { throw new System.ArgumentNullException("CaBundle cannot be null"); }
            StringBuilder AddOrPatchCaBundleServiceURL = new StringBuilder("/infra/cabundles/{cabundle-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            AddOrPatchCaBundleServiceURL.Replace("{cabundle-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CabundleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(CaBundle);
            request.Resource = AddOrPatchCaBundleServiceURL.ToString();
            RestResponse<NSXTCaBundleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCaBundleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + AddOrPatchCaBundleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCaBundleType> GetCaBundle(string CabundleId)
        {
            if (CabundleId == null) { throw new System.ArgumentNullException("CabundleId cannot be null"); }
            StringBuilder GetCaBundleServiceURL = new StringBuilder("/infra/cabundles/{cabundle-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetCaBundleServiceURL.Replace("{cabundle-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CabundleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetCaBundleServiceURL.ToString();
            RestResponse<NSXTCaBundleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCaBundleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetCaBundleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteCaBundle(string CabundleId)
        {
            if (CabundleId == null) { throw new System.ArgumentNullException("CabundleId cannot be null"); }
            StringBuilder DeleteCaBundleServiceURL = new StringBuilder("/infra/cabundles/{cabundle-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteCaBundleServiceURL.Replace("{cabundle-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CabundleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteCaBundleServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteCaBundleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<string> GetTlsCsrPem(string CsrId)
        {
            if (CsrId == null) { throw new System.ArgumentNullException("CsrId cannot be null"); }
            StringBuilder GetTlsCsrPemServiceURL = new StringBuilder("/infra/csrs/{csr-id}/pem-file");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTlsCsrPemServiceURL.Replace("{csr-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CsrId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTlsCsrPemServiceURL.ToString();
            RestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTlsCsrPemServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsCertificateType> AddTlsCertificate(string CertificateId, NSXTTlsTrustDataType TlsTrustData)
        {
            if (CertificateId == null) { throw new System.ArgumentNullException("CertificateId cannot be null"); }
            if (TlsTrustData == null) { throw new System.ArgumentNullException("TlsTrustData cannot be null"); }
            StringBuilder AddTlsCertificateServiceURL = new StringBuilder("/infra/certificates/{certificate-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            AddTlsCertificateServiceURL.Replace("{certificate-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CertificateId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(TlsTrustData);
            request.Resource = AddTlsCertificateServiceURL.ToString();
            RestResponse<NSXTTlsCertificateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsCertificateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + AddTlsCertificateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsCertificateType> GetTlsCertificate(string CertificateId, bool? Details = null)
        {
            if (CertificateId == null) { throw new System.ArgumentNullException("CertificateId cannot be null"); }
            StringBuilder GetTlsCertificateServiceURL = new StringBuilder("/infra/certificates/{certificate-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTlsCertificateServiceURL.Replace("{certificate-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CertificateId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Details != null) { request.AddQueryParameter("details", Details.ToString()); }
            request.Resource = GetTlsCertificateServiceURL.ToString();
            RestResponse<NSXTTlsCertificateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsCertificateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTlsCertificateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchTlsCertificate(string CertificateId, NSXTTlsTrustDataType TlsTrustData)
        {
            if (CertificateId == null) { throw new System.ArgumentNullException("CertificateId cannot be null"); }
            if (TlsTrustData == null) { throw new System.ArgumentNullException("TlsTrustData cannot be null"); }
            StringBuilder PatchTlsCertificateServiceURL = new StringBuilder("/infra/certificates/{certificate-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchTlsCertificateServiceURL.Replace("{certificate-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CertificateId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(TlsTrustData);
            request.Resource = PatchTlsCertificateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchTlsCertificateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTlsCertificate(string CertificateId)
        {
            if (CertificateId == null) { throw new System.ArgumentNullException("CertificateId cannot be null"); }
            StringBuilder DeleteTlsCertificateServiceURL = new StringBuilder("/infra/certificates/{certificate-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTlsCertificateServiceURL.Replace("{certificate-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CertificateId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTlsCertificateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTlsCertificateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsCertificateType> GlobalGlobalInfraGetTlsCertificate(string CertificateId, bool? Details = null)
        {
            if (CertificateId == null) { throw new System.ArgumentNullException("CertificateId cannot be null"); }
            StringBuilder GlobalInfraGetTlsCertificateServiceURL = new StringBuilder("/global-infra/certificates/{certificate-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTlsCertificateServiceURL.Replace("{certificate-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CertificateId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Details != null) { request.AddQueryParameter("details", Details.ToString()); }
            request.Resource = GlobalInfraGetTlsCertificateServiceURL.ToString();
            RestResponse<NSXTTlsCertificateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsCertificateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTlsCertificateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsCrlType> CreateOrUpdateTlsCrl(string CrlId, NSXTTlsCrlType TlsCrl)
        {
            if (CrlId == null) { throw new System.ArgumentNullException("CrlId cannot be null"); }
            if (TlsCrl == null) { throw new System.ArgumentNullException("TlsCrl cannot be null"); }
            StringBuilder CreateOrUpdateTlsCrlServiceURL = new StringBuilder("/infra/crls/{crl-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateTlsCrlServiceURL.Replace("{crl-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CrlId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(TlsCrl);
            request.Resource = CreateOrUpdateTlsCrlServiceURL.ToString();
            RestResponse<NSXTTlsCrlType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsCrlType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateTlsCrlServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTlsCrl(string CrlId)
        {
            if (CrlId == null) { throw new System.ArgumentNullException("CrlId cannot be null"); }
            StringBuilder DeleteTlsCrlServiceURL = new StringBuilder("/infra/crls/{crl-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTlsCrlServiceURL.Replace("{crl-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CrlId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTlsCrlServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTlsCrlServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsCrlType> GetTlsCrl(string CrlId, bool? Details = null)
        {
            if (CrlId == null) { throw new System.ArgumentNullException("CrlId cannot be null"); }
            StringBuilder GetTlsCrlServiceURL = new StringBuilder("/infra/crls/{crl-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTlsCrlServiceURL.Replace("{crl-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CrlId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Details != null) { request.AddQueryParameter("details", Details.ToString()); }
            request.Resource = GetTlsCrlServiceURL.ToString();
            RestResponse<NSXTTlsCrlType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsCrlType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTlsCrlServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchTlsCrl(string CrlId, NSXTTlsCrlType TlsCrl)
        {
            if (CrlId == null) { throw new System.ArgumentNullException("CrlId cannot be null"); }
            if (TlsCrl == null) { throw new System.ArgumentNullException("TlsCrl cannot be null"); }
            StringBuilder CreateOrPatchTlsCrlServiceURL = new StringBuilder("/infra/crls/{crl-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateOrPatchTlsCrlServiceURL.Replace("{crl-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CrlId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(TlsCrl);
            request.Resource = CreateOrPatchTlsCrlServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateOrPatchTlsCrlServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsCrlListResultType> CreateTlsCrl(string CrlId, NSXTTlsCrlType TlsCrl)
        {
            if (CrlId == null) { throw new System.ArgumentNullException("CrlId cannot be null"); }
            if (TlsCrl == null) { throw new System.ArgumentNullException("TlsCrl cannot be null"); }
            StringBuilder CreateTlsCrlServiceURL = new StringBuilder("/infra/crls/{crl-id}?action=import");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CreateTlsCrlServiceURL.Replace("{crl-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CrlId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(TlsCrl);
            request.Resource = CreateTlsCrlServiceURL.ToString();
            RestResponse<NSXTTlsCrlListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsCrlListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateTlsCrlServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsCertificateType> UploadPemSignedTlsCertificate(string CsrId, string File, string? Description = null, string? DisplayName = null)
        {
            if (CsrId == null) { throw new System.ArgumentNullException("CsrId cannot be null"); }
            if (File == null) { throw new System.ArgumentNullException("File cannot be null"); }
            StringBuilder UploadPemSignedTlsCertificateServiceURL = new StringBuilder("/infra/csrs/{csr-id}?action=upload");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            UploadPemSignedTlsCertificateServiceURL.Replace("{csr-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CsrId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Description != null) { request.AddQueryParameter("description", Description.ToString()); }
            if (DisplayName != null) { request.AddQueryParameter("display_name", DisplayName.ToString()); }
            
            request.Resource = UploadPemSignedTlsCertificateServiceURL.ToString();
            RestResponse<NSXTTlsCertificateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsCertificateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + UploadPemSignedTlsCertificateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsCertificateType> GenerateSelfSignedTlsCertificate(NSXTTlsCsrWithDaysValidType TlsCsrWithDaysValid)
        {
            if (TlsCsrWithDaysValid == null) { throw new System.ArgumentNullException("TlsCsrWithDaysValid cannot be null"); }
            StringBuilder GenerateSelfSignedTlsCertificateServiceURL = new StringBuilder("/infra/csrs?action=self_sign");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(TlsCsrWithDaysValid);
            request.Resource = GenerateSelfSignedTlsCertificateServiceURL.ToString();
            RestResponse<NSXTTlsCertificateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsCertificateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + GenerateSelfSignedTlsCertificateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCaBundleListResultType> ListCaBundles(string? Cursor = null, bool? Details = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Type = null)
        {
            StringBuilder ListCaBundlesServiceURL = new StringBuilder("/infra/cabundles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (Details != null) { request.AddQueryParameter("details", Details.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Type != null) { request.AddQueryParameter("type", Type.ToString()); }
            request.Resource = ListCaBundlesServiceURL.ToString();
            RestResponse<NSXTCaBundleListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCaBundleListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListCaBundlesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsCrlType> UploadTlsCrl(string CrlId, string File, string? CrlType = null, string? Description = null, string? DisplayName = null)
        {
            if (CrlId == null) { throw new System.ArgumentNullException("CrlId cannot be null"); }
            if (File == null) { throw new System.ArgumentNullException("File cannot be null"); }
            StringBuilder UploadTlsCrlServiceURL = new StringBuilder("/infra/crls/{crl-id}?action=upload");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            UploadTlsCrlServiceURL.Replace("{crl-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CrlId, System.Globalization.CultureInfo.InvariantCulture)));
            if (CrlType != null) { request.AddQueryParameter("crl_type", CrlType.ToString()); }
            if (Description != null) { request.AddQueryParameter("description", Description.ToString()); }
            if (DisplayName != null) { request.AddQueryParameter("display_name", DisplayName.ToString()); }
            
            request.Resource = UploadTlsCrlServiceURL.ToString();
            RestResponse<NSXTTlsCrlType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsCrlType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + UploadTlsCrlServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsCsrType> GetTlsCsr(string CsrId)
        {
            if (CsrId == null) { throw new System.ArgumentNullException("CsrId cannot be null"); }
            StringBuilder GetTlsCsrServiceURL = new StringBuilder("/infra/csrs/{csr-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTlsCsrServiceURL.Replace("{csr-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CsrId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTlsCsrServiceURL.ToString();
            RestResponse<NSXTTlsCsrType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsCsrType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTlsCsrServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTlsCsr(string CsrId)
        {
            if (CsrId == null) { throw new System.ArgumentNullException("CsrId cannot be null"); }
            StringBuilder DeleteTlsCsrServiceURL = new StringBuilder("/infra/csrs/{csr-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTlsCsrServiceURL.Replace("{csr-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CsrId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTlsCsrServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTlsCsrServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsCertificateType> SelfSignTlsCertificate(string CsrId, long DaysValid)
        {
            if (CsrId == null) { throw new System.ArgumentNullException("CsrId cannot be null"); }
            if (DaysValid == null) { throw new System.ArgumentNullException("DaysValid cannot be null"); }
            StringBuilder SelfSignTlsCertificateServiceURL = new StringBuilder("/infra/csrs/{csr-id}?action=self_sign");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            SelfSignTlsCertificateServiceURL.Replace("{csr-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CsrId, System.Globalization.CultureInfo.InvariantCulture)));
            if (DaysValid != null) { request.AddQueryParameter("days_valid", DaysValid.ToString()); }
            request.Resource = SelfSignTlsCertificateServiceURL.ToString();
            RestResponse<NSXTTlsCertificateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsCertificateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + SelfSignTlsCertificateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
