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
    public class CertificateManager
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public CertificateManager(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTOidcEndPointType> GetOidcEndPoint(string Id, bool? Refresh = null)
        {
            if (Id == null) { throw new System.ArgumentNullException("Id cannot be null"); }
            StringBuilder GetOidcEndPointServiceURL = new StringBuilder("/trust-management/oidc-uris/{id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetOidcEndPointServiceURL.Replace("{id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Refresh != null) { request.AddQueryParameter("refresh", Refresh.ToString()); }
            request.Resource = GetOidcEndPointServiceURL.ToString();
            RestResponse<NSXTOidcEndPointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTOidcEndPointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetOidcEndPointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCsrType> GetCsr(string CsrId)
        {
            if (CsrId == null) { throw new System.ArgumentNullException("CsrId cannot be null"); }
            StringBuilder GetCsrServiceURL = new StringBuilder("/trust-management/csrs/{csr-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetCsrServiceURL.Replace("{csr-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CsrId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetCsrServiceURL.ToString();
            RestResponse<NSXTCsrType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCsrType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetCsrServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteCsr(string CsrId)
        {
            if (CsrId == null) { throw new System.ArgumentNullException("CsrId cannot be null"); }
            StringBuilder DeleteCsrServiceURL = new StringBuilder("/trust-management/csrs/{csr-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteCsrServiceURL.Replace("{csr-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CsrId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteCsrServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteCsrServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCertificateProfileListResultType> ListCertificateProfiles()
        {
            StringBuilder ListCertificateProfilesServiceURL = new StringBuilder("/trust-management/certificate-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListCertificateProfilesServiceURL.ToString();
            RestResponse<NSXTCertificateProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCertificateProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListCertificateProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTrustManagementDataType> GetTrustObjects()
        {
            StringBuilder GetTrustObjectsServiceURL = new StringBuilder("/trust-management");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetTrustObjectsServiceURL.ToString();
            RestResponse<NSXTTrustManagementDataType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTrustManagementDataType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTrustObjectsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCrlListType> AddCrl(NSXTCrlObjectDataType CrlObjectData)
        {
            if (CrlObjectData == null) { throw new System.ArgumentNullException("CrlObjectData cannot be null"); }
            StringBuilder AddCrlServiceURL = new StringBuilder("/trust-management/crls?action=import");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(CrlObjectData);
            request.Resource = AddCrlServiceURL.ToString();
            RestResponse<NSXTCrlListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCrlListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddCrlServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCertificateProfileType> GetCertificateProfile(string ServiceType)
        {
            if (ServiceType == null) { throw new System.ArgumentNullException("ServiceType cannot be null"); }
            StringBuilder GetCertificateProfileServiceURL = new StringBuilder("/trust-management/certificate-profile/{service-type}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetCertificateProfileServiceURL.Replace("{service-type}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceType, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetCertificateProfileServiceURL.ToString();
            RestResponse<NSXTCertificateProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCertificateProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetCertificateProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task ApplyCertificate(string CertId, string ServiceType, string? NodeId = null)
        {
            if (CertId == null) { throw new System.ArgumentNullException("CertId cannot be null"); }
            if (ServiceType == null) { throw new System.ArgumentNullException("ServiceType cannot be null"); }
            StringBuilder ApplyCertificateServiceURL = new StringBuilder("/trust-management/certificates/{cert-id}?action=apply_certificate");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ApplyCertificateServiceURL.Replace("{cert-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CertId, System.Globalization.CultureInfo.InvariantCulture)));
            if (NodeId != null) { request.AddQueryParameter("node_id", NodeId.ToString()); }
            if (ServiceType != null) { request.AddQueryParameter("service_type", ServiceType.ToString()); }
            request.Resource = ApplyCertificateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ApplyCertificateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCertificateListType> ImportCertificate(string CsrId, NSXTTrustObjectDataType TrustObjectData)
        {
            if (CsrId == null) { throw new System.ArgumentNullException("CsrId cannot be null"); }
            if (TrustObjectData == null) { throw new System.ArgumentNullException("TrustObjectData cannot be null"); }
            StringBuilder ImportCertificateServiceURL = new StringBuilder("/trust-management/csrs/{csr-id}?action=import");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ImportCertificateServiceURL.Replace("{csr-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CsrId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(TrustObjectData);
            request.Resource = ImportCertificateServiceURL.ToString();
            RestResponse<NSXTCertificateListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCertificateListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ImportCertificateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCrlDistributionPointType> CreateCrlDistributionPoint(NSXTCrlDistributionPointType CrlDistributionPoint)
        {
            if (CrlDistributionPoint == null) { throw new System.ArgumentNullException("CrlDistributionPoint cannot be null"); }
            StringBuilder CreateCrlDistributionPointServiceURL = new StringBuilder("/trust-management/crl-distribution-points");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(CrlDistributionPoint);
            request.Resource = CreateCrlDistributionPointServiceURL.ToString();
            RestResponse<NSXTCrlDistributionPointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCrlDistributionPointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateCrlDistributionPointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCrlDistributionPointListType> ListCrlDistributionPoints(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListCrlDistributionPointsServiceURL = new StringBuilder("/trust-management/crl-distribution-points");
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
            request.Resource = ListCrlDistributionPointsServiceURL.ToString();
            RestResponse<NSXTCrlDistributionPointListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCrlDistributionPointListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListCrlDistributionPointsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCertificateCheckingStatusType> ValidateCertificate(string CertId, string? Usage = null)
        {
            if (CertId == null) { throw new System.ArgumentNullException("CertId cannot be null"); }
            StringBuilder ValidateCertificateServiceURL = new StringBuilder("/trust-management/certificates/{cert-id}?action=validate");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ValidateCertificateServiceURL.Replace("{cert-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CertId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Usage != null) { request.AddQueryParameter("usage", Usage.ToString()); }
            request.Resource = ValidateCertificateServiceURL.ToString();
            RestResponse<NSXTCertificateCheckingStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCertificateCheckingStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ValidateCertificateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCertificateType> GenerateSelfSignedCertificate(NSXTCsrWithDaysValidType CsrWithDaysValid)
        {
            if (CsrWithDaysValid == null) { throw new System.ArgumentNullException("CsrWithDaysValid cannot be null"); }
            StringBuilder GenerateSelfSignedCertificateServiceURL = new StringBuilder("/trust-management/csrs?action=self_sign");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(CsrWithDaysValid);
            request.Resource = GenerateSelfSignedCertificateServiceURL.ToString();
            RestResponse<NSXTCertificateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCertificateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + GenerateSelfSignedCertificateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCrlDistributionPointStatusType> GetCrlDistributionPointStatus(string CrlDistributionPointId)
        {
            if (CrlDistributionPointId == null) { throw new System.ArgumentNullException("CrlDistributionPointId cannot be null"); }
            StringBuilder GetCrlDistributionPointStatusServiceURL = new StringBuilder("/trust-management/crl-distribution-points/{crl-distribution-point-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetCrlDistributionPointStatusServiceURL.Replace("{crl-distribution-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CrlDistributionPointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetCrlDistributionPointStatusServiceURL.ToString();
            RestResponse<NSXTCrlDistributionPointStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCrlDistributionPointStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetCrlDistributionPointStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<string> GetCsrPem(string CsrId)
        {
            if (CsrId == null) { throw new System.ArgumentNullException("CsrId cannot be null"); }
            StringBuilder GetCsrPemServiceURL = new StringBuilder("/trust-management/csrs/{csr-id}/pem-file");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetCsrPemServiceURL.Replace("{csr-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CsrId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetCsrPemServiceURL.ToString();
            RestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetCsrPemServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task SetInterSiteAphCertificate(NSXTSetInterSiteAphCertificateRequestType SetInterSiteAphCertificateRequest)
        {
            if (SetInterSiteAphCertificateRequest == null) { throw new System.ArgumentNullException("SetInterSiteAphCertificateRequest cannot be null"); }
            StringBuilder SetInterSiteAphCertificateServiceURL = new StringBuilder("/trust-management/certificates?action=set_appliance_proxy_certificate_for_inter_site_communication");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(SetInterSiteAphCertificateRequest);
            request.Resource = SetInterSiteAphCertificateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + SetInterSiteAphCertificateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTOidcEndPointType> AddOidcEndPoint(NSXTOidcEndPointType OidcEndPoint)
        {
            if (OidcEndPoint == null) { throw new System.ArgumentNullException("OidcEndPoint cannot be null"); }
            StringBuilder AddOidcEndPointServiceURL = new StringBuilder("/trust-management/oidc-uris");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(OidcEndPoint);
            request.Resource = AddOidcEndPointServiceURL.ToString();
            RestResponse<NSXTOidcEndPointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTOidcEndPointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddOidcEndPointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTOidcEndPointListResultType> ListOidcEndPoints()
        {
            StringBuilder ListOidcEndPointsServiceURL = new StringBuilder("/trust-management/oidc-uris");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListOidcEndPointsServiceURL.ToString();
            RestResponse<NSXTOidcEndPointListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTOidcEndPointListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListOidcEndPointsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeletePrincipalIdentity(string PrincipalIdentityId)
        {
            if (PrincipalIdentityId == null) { throw new System.ArgumentNullException("PrincipalIdentityId cannot be null"); }
            StringBuilder DeletePrincipalIdentityServiceURL = new StringBuilder("/trust-management/principal-identities/{principal-identity-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeletePrincipalIdentityServiceURL.Replace("{principal-identity-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PrincipalIdentityId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePrincipalIdentityServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeletePrincipalIdentityServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPrincipalIdentityType> GetPrincipalIdentity(string PrincipalIdentityId)
        {
            if (PrincipalIdentityId == null) { throw new System.ArgumentNullException("PrincipalIdentityId cannot be null"); }
            StringBuilder GetPrincipalIdentityServiceURL = new StringBuilder("/trust-management/principal-identities/{principal-identity-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPrincipalIdentityServiceURL.Replace("{principal-identity-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PrincipalIdentityId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPrincipalIdentityServiceURL.ToString();
            RestResponse<NSXTPrincipalIdentityType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPrincipalIdentityType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPrincipalIdentityServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTOidcEndPointType> UpdateOidcEndPointThumbprint(NSXTUpdateOidcEndPointThumbprintRequestType UpdateOidcEndPointThumbprintRequest)
        {
            if (UpdateOidcEndPointThumbprintRequest == null) { throw new System.ArgumentNullException("UpdateOidcEndPointThumbprintRequest cannot be null"); }
            StringBuilder UpdateOidcEndPointThumbprintServiceURL = new StringBuilder("/trust-management/oidc-uris?action=update_thumbprint");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(UpdateOidcEndPointThumbprintRequest);
            request.Resource = UpdateOidcEndPointThumbprintServiceURL.ToString();
            RestResponse<NSXTOidcEndPointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTOidcEndPointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + UpdateOidcEndPointThumbprintServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCsrType> GenerateCsrWithExtensions(NSXTCsrExtType CsrExt)
        {
            if (CsrExt == null) { throw new System.ArgumentNullException("CsrExt cannot be null"); }
            StringBuilder GenerateCsrWithExtensionsServiceURL = new StringBuilder("/trust-management/csrs-extended");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(CsrExt);
            request.Resource = GenerateCsrWithExtensionsServiceURL.ToString();
            RestResponse<NSXTCsrType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCsrType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + GenerateCsrWithExtensionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPrincipalIdentityType> RegisterPrincipalIdentityWithCertificate(NSXTPrincipalIdentityWithCertificateType PrincipalIdentityWithCertificate)
        {
            if (PrincipalIdentityWithCertificate == null) { throw new System.ArgumentNullException("PrincipalIdentityWithCertificate cannot be null"); }
            StringBuilder RegisterPrincipalIdentityWithCertificateServiceURL = new StringBuilder("/trust-management/principal-identities/with-certificate");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(PrincipalIdentityWithCertificate);
            request.Resource = RegisterPrincipalIdentityWithCertificateServiceURL.ToString();
            RestResponse<NSXTPrincipalIdentityType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPrincipalIdentityType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + RegisterPrincipalIdentityWithCertificateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCrlDistributionPointType> UpdateCrlDistributionPoint(string CrlDistributionPointId, NSXTCrlDistributionPointType CrlDistributionPoint)
        {
            if (CrlDistributionPointId == null) { throw new System.ArgumentNullException("CrlDistributionPointId cannot be null"); }
            if (CrlDistributionPoint == null) { throw new System.ArgumentNullException("CrlDistributionPoint cannot be null"); }
            StringBuilder UpdateCrlDistributionPointServiceURL = new StringBuilder("/trust-management/crl-distribution-points/{crl-distribution-point-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateCrlDistributionPointServiceURL.Replace("{crl-distribution-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CrlDistributionPointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(CrlDistributionPoint);
            request.Resource = UpdateCrlDistributionPointServiceURL.ToString();
            RestResponse<NSXTCrlDistributionPointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCrlDistributionPointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateCrlDistributionPointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteCrlDistributionPoint(string CrlDistributionPointId)
        {
            if (CrlDistributionPointId == null) { throw new System.ArgumentNullException("CrlDistributionPointId cannot be null"); }
            StringBuilder DeleteCrlDistributionPointServiceURL = new StringBuilder("/trust-management/crl-distribution-points/{crl-distribution-point-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteCrlDistributionPointServiceURL.Replace("{crl-distribution-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CrlDistributionPointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteCrlDistributionPointServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteCrlDistributionPointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCrlDistributionPointType> GetCrlDistributionPoint(string CrlDistributionPointId)
        {
            if (CrlDistributionPointId == null) { throw new System.ArgumentNullException("CrlDistributionPointId cannot be null"); }
            StringBuilder GetCrlDistributionPointServiceURL = new StringBuilder("/trust-management/crl-distribution-points/{crl-distribution-point-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetCrlDistributionPointServiceURL.Replace("{crl-distribution-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CrlDistributionPointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetCrlDistributionPointServiceURL.ToString();
            RestResponse<NSXTCrlDistributionPointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCrlDistributionPointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetCrlDistributionPointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTokenBasedPrincipalIdentityType> RegisterTokenBasedPrincipalIdentity(NSXTTokenBasedPrincipalIdentityType TokenBasedPrincipalIdentity)
        {
            if (TokenBasedPrincipalIdentity == null) { throw new System.ArgumentNullException("TokenBasedPrincipalIdentity cannot be null"); }
            StringBuilder RegisterTokenBasedPrincipalIdentityServiceURL = new StringBuilder("/trust-management/token-principal-identities");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(TokenBasedPrincipalIdentity);
            request.Resource = RegisterTokenBasedPrincipalIdentityServiceURL.ToString();
            RestResponse<NSXTTokenBasedPrincipalIdentityType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTokenBasedPrincipalIdentityType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + RegisterTokenBasedPrincipalIdentityServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTokenBasedPrincipalIdentityListResultType> ListTokenBasedPrincipalIdentities()
        {
            StringBuilder ListTokenBasedPrincipalIdentitiesServiceURL = new StringBuilder("/trust-management/token-principal-identities");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListTokenBasedPrincipalIdentitiesServiceURL.ToString();
            RestResponse<NSXTTokenBasedPrincipalIdentityListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTokenBasedPrincipalIdentityListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTokenBasedPrincipalIdentitiesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCsrType> GenerateCsr(NSXTCsrType Csr)
        {
            if (Csr == null) { throw new System.ArgumentNullException("Csr cannot be null"); }
            StringBuilder GenerateCsrServiceURL = new StringBuilder("/trust-management/csrs");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(Csr);
            request.Resource = GenerateCsrServiceURL.ToString();
            RestResponse<NSXTCsrType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCsrType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + GenerateCsrServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCsrListType> GetCsrs(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GetCsrsServiceURL = new StringBuilder("/trust-management/csrs");
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
            request.Resource = GetCsrsServiceURL.ToString();
            RestResponse<NSXTCsrListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCsrListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetCsrsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCrlType> UpdateCrl(string CrlId, NSXTCrlType Crl)
        {
            if (CrlId == null) { throw new System.ArgumentNullException("CrlId cannot be null"); }
            if (Crl == null) { throw new System.ArgumentNullException("Crl cannot be null"); }
            StringBuilder UpdateCrlServiceURL = new StringBuilder("/trust-management/crls/{crl-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateCrlServiceURL.Replace("{crl-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CrlId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Crl);
            request.Resource = UpdateCrlServiceURL.ToString();
            RestResponse<NSXTCrlType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCrlType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateCrlServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCrlType> GetCrl(string CrlId, bool? Details = null)
        {
            if (CrlId == null) { throw new System.ArgumentNullException("CrlId cannot be null"); }
            StringBuilder GetCrlServiceURL = new StringBuilder("/trust-management/crls/{crl-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetCrlServiceURL.Replace("{crl-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CrlId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Details != null) { request.AddQueryParameter("details", Details.ToString()); }
            request.Resource = GetCrlServiceURL.ToString();
            RestResponse<NSXTCrlType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCrlType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetCrlServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteCrl(string CrlId)
        {
            if (CrlId == null) { throw new System.ArgumentNullException("CrlId cannot be null"); }
            StringBuilder DeleteCrlServiceURL = new StringBuilder("/trust-management/crls/{crl-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteCrlServiceURL.Replace("{crl-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CrlId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteCrlServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteCrlServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCertificateType> SelfSignCertificate(string CsrId, long DaysValid)
        {
            if (CsrId == null) { throw new System.ArgumentNullException("CsrId cannot be null"); }
            if (DaysValid == null) { throw new System.ArgumentNullException("DaysValid cannot be null"); }
            StringBuilder SelfSignCertificateServiceURL = new StringBuilder("/trust-management/csrs/{csr-id}?action=self_sign");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            SelfSignCertificateServiceURL.Replace("{csr-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CsrId, System.Globalization.CultureInfo.InvariantCulture)));
            if (DaysValid != null) { request.AddQueryParameter("days_valid", DaysValid.ToString()); }
            request.Resource = SelfSignCertificateServiceURL.ToString();
            RestResponse<NSXTCertificateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCertificateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + SelfSignCertificateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteCertificate(string CertId)
        {
            if (CertId == null) { throw new System.ArgumentNullException("CertId cannot be null"); }
            StringBuilder DeleteCertificateServiceURL = new StringBuilder("/trust-management/certificates/{cert-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteCertificateServiceURL.Replace("{cert-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CertId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteCertificateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteCertificateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCertificateType> GetCertificate(string CertId, bool? Details = null)
        {
            if (CertId == null) { throw new System.ArgumentNullException("CertId cannot be null"); }
            StringBuilder GetCertificateServiceURL = new StringBuilder("/trust-management/certificates/{cert-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetCertificateServiceURL.Replace("{cert-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CertId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Details != null) { request.AddQueryParameter("details", Details.ToString()); }
            request.Resource = GetCertificateServiceURL.ToString();
            RestResponse<NSXTCertificateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCertificateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetCertificateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPrincipalIdentityType> UpdatePrincipalIdentityCertificate(NSXTUpdatePrincipalIdentityCertificateRequestType UpdatePrincipalIdentityCertificateRequest)
        {
            if (UpdatePrincipalIdentityCertificateRequest == null) { throw new System.ArgumentNullException("UpdatePrincipalIdentityCertificateRequest cannot be null"); }
            StringBuilder UpdatePrincipalIdentityCertificateServiceURL = new StringBuilder("/trust-management/principal-identities?action=update_certificate");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(UpdatePrincipalIdentityCertificateRequest);
            request.Resource = UpdatePrincipalIdentityCertificateServiceURL.ToString();
            RestResponse<NSXTPrincipalIdentityType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPrincipalIdentityType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + UpdatePrincipalIdentityCertificateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTokenBasedPrincipalIdentityType> GetTokenBasedPrincipalIdentity(string PrincipalIdentityId)
        {
            if (PrincipalIdentityId == null) { throw new System.ArgumentNullException("PrincipalIdentityId cannot be null"); }
            StringBuilder GetTokenBasedPrincipalIdentityServiceURL = new StringBuilder("/trust-management/token-principal-identities/{principal-identity-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTokenBasedPrincipalIdentityServiceURL.Replace("{principal-identity-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PrincipalIdentityId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTokenBasedPrincipalIdentityServiceURL.ToString();
            RestResponse<NSXTTokenBasedPrincipalIdentityType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTokenBasedPrincipalIdentityType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTokenBasedPrincipalIdentityServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTokenBasedPrincipalIdentity(string PrincipalIdentityId)
        {
            if (PrincipalIdentityId == null) { throw new System.ArgumentNullException("PrincipalIdentityId cannot be null"); }
            StringBuilder DeleteTokenBasedPrincipalIdentityServiceURL = new StringBuilder("/trust-management/token-principal-identities/{principal-identity-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTokenBasedPrincipalIdentityServiceURL.Replace("{principal-identity-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PrincipalIdentityId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTokenBasedPrincipalIdentityServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTokenBasedPrincipalIdentityServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCrlListType> GetCrls(string? Cursor = null, bool? Details = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Type = null)
        {
            StringBuilder GetCrlsServiceURL = new StringBuilder("/trust-management/crls");
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
            request.Resource = GetCrlsServiceURL.ToString();
            RestResponse<NSXTCrlListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCrlListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetCrlsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task SetPrincipalIdentityCertificateForFederation(NSXTSetPrincipalIdentityCertificateForFederationRequestType SetPrincipalIdentityCertificateForFederationRequest)
        {
            if (SetPrincipalIdentityCertificateForFederationRequest == null) { throw new System.ArgumentNullException("SetPrincipalIdentityCertificateForFederationRequest cannot be null"); }
            StringBuilder SetPrincipalIdentityCertificateForFederationServiceURL = new StringBuilder("/trust-management/certificates?action=set_pi_certificate_for_federation");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(SetPrincipalIdentityCertificateForFederationRequest);
            request.Resource = SetPrincipalIdentityCertificateForFederationServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + SetPrincipalIdentityCertificateForFederationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCertificateListType> GetCertificates(string? Cursor = null, bool? Details = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null, string? Type = null)
        {
            StringBuilder GetCertificatesServiceURL = new StringBuilder("/trust-management/certificates");
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
            request.Resource = GetCertificatesServiceURL.ToString();
            RestResponse<NSXTCertificateListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCertificateListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetCertificatesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPrincipalIdentityType> RegisterPrincipalIdentity(NSXTPrincipalIdentityType PrincipalIdentity)
        {
            if (PrincipalIdentity == null) { throw new System.ArgumentNullException("PrincipalIdentity cannot be null"); }
            StringBuilder RegisterPrincipalIdentityServiceURL = new StringBuilder("/trust-management/principal-identities");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(PrincipalIdentity);
            request.Resource = RegisterPrincipalIdentityServiceURL.ToString();
            RestResponse<NSXTPrincipalIdentityType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPrincipalIdentityType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + RegisterPrincipalIdentityServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPrincipalIdentityListType> GetPrincipalIdentities()
        {
            StringBuilder GetPrincipalIdentitiesServiceURL = new StringBuilder("/trust-management/principal-identities");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetPrincipalIdentitiesServiceURL.ToString();
            RestResponse<NSXTPrincipalIdentityListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPrincipalIdentityListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPrincipalIdentitiesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCertificateListType> AddCertificate(NSXTTrustObjectDataType TrustObjectData)
        {
            if (TrustObjectData == null) { throw new System.ArgumentNullException("TrustObjectData cannot be null"); }
            StringBuilder AddCertificateServiceURL = new StringBuilder("/trust-management/certificates?action=import");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(TrustObjectData);
            request.Resource = AddCertificateServiceURL.ToString();
            RestResponse<NSXTCertificateListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCertificateListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddCertificateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<string> GetCrlDistributionPointPem(NSXTCrlPemRequestTypeType CrlPemRequestType)
        {
            if (CrlPemRequestType == null) { throw new System.ArgumentNullException("CrlPemRequestType cannot be null"); }
            StringBuilder GetCrlDistributionPointPemServiceURL = new StringBuilder("/trust-management/crl-distribution-points/pem-file");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(CrlPemRequestType);
            request.Resource = GetCrlDistributionPointPemServiceURL.ToString();
            RestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + GetCrlDistributionPointPemServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
