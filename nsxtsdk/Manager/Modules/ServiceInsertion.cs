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
    public class ServiceInsertion
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public ServiceInsertion(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTServiceProfileNSGroupsType> GetServiceProfileNsgroups(string ServiceId, string ServiceProfileId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (ServiceProfileId == null) { throw new System.ArgumentNullException("ServiceProfileId cannot be null"); }
            StringBuilder GetServiceProfileNsgroupsServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/service-profiles/{service-profile-id}/nsgroups");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceProfileNsgroupsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetServiceProfileNsgroupsServiceURL.Replace("{service-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceProfileNsgroupsServiceURL.ToString();
            RestResponse<NSXTServiceProfileNSGroupsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceProfileNSGroupsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetServiceProfileNsgroupsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInstanceNSGroupsType> GetServiceInstanceNsgroups(string ServiceId, string ServiceInstanceId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            StringBuilder GetServiceInstanceNsgroupsServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/service-instances/{service-instance-id}/group-associations");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceInstanceNsgroupsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetServiceInstanceNsgroupsServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceInstanceNsgroupsServiceURL.ToString();
            RestResponse<NSXTServiceInstanceNSGroupsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInstanceNSGroupsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetServiceInstanceNsgroupsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceDefinitionType> UpdateServiceInsertionService(string ServiceId, NSXTServiceDefinitionType ServiceDefinition)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (ServiceDefinition == null) { throw new System.ArgumentNullException("ServiceDefinition cannot be null"); }
            StringBuilder UpdateServiceInsertionServiceServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateServiceInsertionServiceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ServiceDefinition);
            request.Resource = UpdateServiceInsertionServiceServiceURL.ToString();
            RestResponse<NSXTServiceDefinitionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceDefinitionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateServiceInsertionServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceDefinitionType> GetServiceInsertionService(string ServiceId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder GetServiceInsertionServiceServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceInsertionServiceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceInsertionServiceServiceURL.ToString();
            RestResponse<NSXTServiceDefinitionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceDefinitionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetServiceInsertionServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteServiceInsertionService(string ServiceId, bool? Cascade = null)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder DeleteServiceInsertionServiceServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteServiceInsertionServiceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cascade != null) { request.AddQueryParameter("cascade", Cascade.ToString()); }
            request.Resource = DeleteServiceInsertionServiceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteServiceInsertionServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceManagerType> UpdateServiceManager(string ServiceManagerId, NSXTServiceManagerType ServiceManager)
        {
            if (ServiceManagerId == null) { throw new System.ArgumentNullException("ServiceManagerId cannot be null"); }
            if (ServiceManager == null) { throw new System.ArgumentNullException("ServiceManager cannot be null"); }
            StringBuilder UpdateServiceManagerServiceURL = new StringBuilder("/serviceinsertion/service-managers/{service-manager-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateServiceManagerServiceURL.Replace("{service-manager-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceManagerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ServiceManager);
            request.Resource = UpdateServiceManagerServiceURL.ToString();
            RestResponse<NSXTServiceManagerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceManagerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateServiceManagerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceManagerType> GetServiceManager(string ServiceManagerId)
        {
            if (ServiceManagerId == null) { throw new System.ArgumentNullException("ServiceManagerId cannot be null"); }
            StringBuilder GetServiceManagerServiceURL = new StringBuilder("/serviceinsertion/service-managers/{service-manager-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceManagerServiceURL.Replace("{service-manager-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceManagerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceManagerServiceURL.ToString();
            RestResponse<NSXTServiceManagerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceManagerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetServiceManagerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteServiceManager(string ServiceManagerId)
        {
            if (ServiceManagerId == null) { throw new System.ArgumentNullException("ServiceManagerId cannot be null"); }
            StringBuilder DeleteServiceManagerServiceURL = new StringBuilder("/serviceinsertion/service-managers/{service-manager-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteServiceManagerServiceURL.Replace("{service-manager-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceManagerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteServiceManagerServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteServiceManagerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBaseServiceProfileType> AddSiserviceProfile(string ServiceId, NSXTBaseServiceProfileType BaseServiceProfile)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (BaseServiceProfile == null) { throw new System.ArgumentNullException("BaseServiceProfile cannot be null"); }
            StringBuilder AddSiserviceProfileServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/service-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            AddSiserviceProfileServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(BaseServiceProfile);
            request.Resource = AddSiserviceProfileServiceURL.ToString();
            RestResponse<NSXTBaseServiceProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBaseServiceProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddSiserviceProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSIServiceProfileListResultType> ListSiserviceProfiles(string ServiceId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder ListSiserviceProfilesServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/service-profiles");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListSiserviceProfilesServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ListSiserviceProfilesServiceURL.ToString();
            RestResponse<NSXTSIServiceProfileListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSIServiceProfileListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListSiserviceProfilesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBaseServiceInstanceType> UpdateServiceInstance(string ServiceId, string ServiceInstanceId, NSXTBaseServiceInstanceType BaseServiceInstance)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            if (BaseServiceInstance == null) { throw new System.ArgumentNullException("BaseServiceInstance cannot be null"); }
            StringBuilder UpdateServiceInstanceServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/service-instances/{service-instance-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateServiceInstanceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateServiceInstanceServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(BaseServiceInstance);
            request.Resource = UpdateServiceInstanceServiceURL.ToString();
            RestResponse<NSXTBaseServiceInstanceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBaseServiceInstanceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateServiceInstanceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteServiceInstance(string ServiceId, string ServiceInstanceId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            StringBuilder DeleteServiceInstanceServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/service-instances/{service-instance-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteServiceInstanceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteServiceInstanceServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteServiceInstanceServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteServiceInstanceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBaseServiceInstanceType> GetServiceInstance(string ServiceId, string ServiceInstanceId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            StringBuilder GetServiceInstanceServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/service-instances/{service-instance-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceInstanceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetServiceInstanceServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceInstanceServiceURL.ToString();
            RestResponse<NSXTBaseServiceInstanceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBaseServiceInstanceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetServiceInstanceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInstanceEndpointType> AddInstanceEndpoint(string ServiceId, string ServiceInstanceId, NSXTInstanceEndpointType InstanceEndpoint)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            if (InstanceEndpoint == null) { throw new System.ArgumentNullException("InstanceEndpoint cannot be null"); }
            StringBuilder AddInstanceEndpointServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/service-instances/{service-instance-id}/instance-endpoints");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            AddInstanceEndpointServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            AddInstanceEndpointServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(InstanceEndpoint);
            request.Resource = AddInstanceEndpointServiceURL.ToString();
            RestResponse<NSXTInstanceEndpointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInstanceEndpointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddInstanceEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInstanceEndpointListResultType> ListInstanceEndpoints(string ServiceId, string ServiceInstanceId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            StringBuilder ListInstanceEndpointsServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/service-instances/{service-instance-id}/instance-endpoints");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListInstanceEndpointsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ListInstanceEndpointsServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ListInstanceEndpointsServiceURL.ToString();
            RestResponse<NSXTInstanceEndpointListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInstanceEndpointListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListInstanceEndpointsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInstanceListResultType> ListServiceInstances(string? DeployedTo = null, string? ServiceDeploymentId = null)
        {
            StringBuilder ListServiceInstancesServiceURL = new StringBuilder("/serviceinsertion/service-instances");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (DeployedTo != null) { request.AddQueryParameter("deployed_to", DeployedTo.ToString()); }
            if (ServiceDeploymentId != null) { request.AddQueryParameter("service_deployment_id", ServiceDeploymentId.ToString()); }
            request.Resource = ListServiceInstancesServiceURL.ToString();
            RestResponse<NSXTServiceInstanceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInstanceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListServiceInstancesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTVendorTemplateType> AddVendorTemplate(string ServiceId, NSXTVendorTemplateType VendorTemplate)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (VendorTemplate == null) { throw new System.ArgumentNullException("VendorTemplate cannot be null"); }
            StringBuilder AddVendorTemplateServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/vendor-templates");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            AddVendorTemplateServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(VendorTemplate);
            request.Resource = AddVendorTemplateServiceURL.ToString();
            RestResponse<NSXTVendorTemplateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVendorTemplateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddVendorTemplateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTVendorTemplateListResultType> ListVendorTemplates(string ServiceId, string? VendorTemplateName = null)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder ListVendorTemplatesServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/vendor-templates");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListVendorTemplatesServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (VendorTemplateName != null) { request.AddQueryParameter("vendor_template_name", VendorTemplateName.ToString()); }
            request.Resource = ListVendorTemplatesServiceURL.ToString();
            RestResponse<NSXTVendorTemplateListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVendorTemplateListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListVendorTemplatesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceAttachmentType> AddServiceAttachment(NSXTServiceAttachmentType ServiceAttachment)
        {
            if (ServiceAttachment == null) { throw new System.ArgumentNullException("ServiceAttachment cannot be null"); }
            StringBuilder AddServiceAttachmentServiceURL = new StringBuilder("/serviceinsertion/service-attachments");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(ServiceAttachment);
            request.Resource = AddServiceAttachmentServiceURL.ToString();
            RestResponse<NSXTServiceAttachmentType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceAttachmentType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddServiceAttachmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceAttachmentListResultType> ListServiceAttachments()
        {
            StringBuilder ListServiceAttachmentsServiceURL = new StringBuilder("/serviceinsertion/service-attachments");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListServiceAttachmentsServiceURL.ToString();
            RestResponse<NSXTServiceAttachmentListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceAttachmentListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListServiceAttachmentsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceChainType> GetServiceChain(string ServiceChainId)
        {
            if (ServiceChainId == null) { throw new System.ArgumentNullException("ServiceChainId cannot be null"); }
            StringBuilder GetServiceChainServiceURL = new StringBuilder("/serviceinsertion/service-chains/{service-chain-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceChainServiceURL.Replace("{service-chain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceChainId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceChainServiceURL.ToString();
            RestResponse<NSXTServiceChainType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceChainType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetServiceChainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteServiceChain(string ServiceChainId)
        {
            if (ServiceChainId == null) { throw new System.ArgumentNullException("ServiceChainId cannot be null"); }
            StringBuilder DeleteServiceChainServiceURL = new StringBuilder("/serviceinsertion/service-chains/{service-chain-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteServiceChainServiceURL.Replace("{service-chain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceChainId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteServiceChainServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteServiceChainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceManagerType> RegisterServiceManager(NSXTServiceManagerType ServiceManager)
        {
            if (ServiceManager == null) { throw new System.ArgumentNullException("ServiceManager cannot be null"); }
            StringBuilder RegisterServiceManagerServiceURL = new StringBuilder("/serviceinsertion/service-managers");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(ServiceManager);
            request.Resource = RegisterServiceManagerServiceURL.ToString();
            RestResponse<NSXTServiceManagerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceManagerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + RegisterServiceManagerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceManagerListResultType> ListServiceManagers()
        {
            StringBuilder ListServiceManagersServiceURL = new StringBuilder("/serviceinsertion/service-managers");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListServiceManagersServiceURL.ToString();
            RestResponse<NSXTServiceManagerListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceManagerListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListServiceManagersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTVendorTemplateType> GetVendorTemplate(string ServiceId, string VendorTemplateId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (VendorTemplateId == null) { throw new System.ArgumentNullException("VendorTemplateId cannot be null"); }
            StringBuilder GetVendorTemplateServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/vendor-templates/{vendor-template-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetVendorTemplateServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetVendorTemplateServiceURL.Replace("{vendor-template-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(VendorTemplateId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVendorTemplateServiceURL.ToString();
            RestResponse<NSXTVendorTemplateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTVendorTemplateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetVendorTemplateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteVendorTemplate(string ServiceId, string VendorTemplateId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (VendorTemplateId == null) { throw new System.ArgumentNullException("VendorTemplateId cannot be null"); }
            StringBuilder DeleteVendorTemplateServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/vendor-templates/{vendor-template-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteVendorTemplateServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteVendorTemplateServiceURL.Replace("{vendor-template-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(VendorTemplateId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteVendorTemplateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteVendorTemplateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceChainMappingListResultType> ListServiceChainMappings(string ServiceId, string ServiceProfileId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (ServiceProfileId == null) { throw new System.ArgumentNullException("ServiceProfileId cannot be null"); }
            StringBuilder ListServiceChainMappingsServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/service-profiles/{service-profile-id}/service-chain-mappings");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListServiceChainMappingsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ListServiceChainMappingsServiceURL.Replace("{service-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ListServiceChainMappingsServiceURL.ToString();
            RestResponse<NSXTServiceChainMappingListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceChainMappingListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListServiceChainMappingsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInstanceEndpointType> GetInstanceEndpoint(string ServiceId, string ServiceInstanceId, string InstanceEndpointId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            if (InstanceEndpointId == null) { throw new System.ArgumentNullException("InstanceEndpointId cannot be null"); }
            StringBuilder GetInstanceEndpointServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/service-instances/{service-instance-id}/instance-endpoints/{instance-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetInstanceEndpointServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetInstanceEndpointServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetInstanceEndpointServiceURL.Replace("{instance-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InstanceEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetInstanceEndpointServiceURL.ToString();
            RestResponse<NSXTInstanceEndpointType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInstanceEndpointType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInstanceEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteInstanceEndpoint(string ServiceId, string ServiceInstanceId, string InstanceEndpointId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (ServiceInstanceId == null) { throw new System.ArgumentNullException("ServiceInstanceId cannot be null"); }
            if (InstanceEndpointId == null) { throw new System.ArgumentNullException("InstanceEndpointId cannot be null"); }
            StringBuilder DeleteInstanceEndpointServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/service-instances/{service-instance-id}/instance-endpoints/{instance-endpoint-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteInstanceEndpointServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteInstanceEndpointServiceURL.Replace("{service-instance-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceInstanceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteInstanceEndpointServiceURL.Replace("{instance-endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InstanceEndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteInstanceEndpointServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteInstanceEndpointServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSourceEntityResultType> ResolveSourceEntities(string SourceNodeValue)
        {
            if (SourceNodeValue == null) { throw new System.ArgumentNullException("SourceNodeValue cannot be null"); }
            StringBuilder ResolveSourceEntitiesServiceURL = new StringBuilder("/serviceinsertion/source-entities");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (SourceNodeValue != null) { request.AddQueryParameter("source_node_value", SourceNodeValue.ToString()); }
            request.Resource = ResolveSourceEntitiesServiceURL.ToString();
            RestResponse<NSXTSourceEntityResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSourceEntityResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ResolveSourceEntitiesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceDefinitionType> AddServiceInsertionService(NSXTServiceDefinitionType ServiceDefinition)
        {
            if (ServiceDefinition == null) { throw new System.ArgumentNullException("ServiceDefinition cannot be null"); }
            StringBuilder AddServiceInsertionServiceServiceURL = new StringBuilder("/serviceinsertion/services");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(ServiceDefinition);
            request.Resource = AddServiceInsertionServiceServiceURL.ToString();
            RestResponse<NSXTServiceDefinitionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceDefinitionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddServiceInsertionServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInsertionServiceListResultType> ListServiceInsertionServices()
        {
            StringBuilder ListServiceInsertionServicesServiceURL = new StringBuilder("/serviceinsertion/services");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListServiceInsertionServicesServiceURL.ToString();
            RestResponse<NSXTServiceInsertionServiceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInsertionServiceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListServiceInsertionServicesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceAttachmentType> UpdateServiceAttachment(string ServiceAttachmentId, NSXTServiceAttachmentType ServiceAttachment)
        {
            if (ServiceAttachmentId == null) { throw new System.ArgumentNullException("ServiceAttachmentId cannot be null"); }
            if (ServiceAttachment == null) { throw new System.ArgumentNullException("ServiceAttachment cannot be null"); }
            StringBuilder UpdateServiceAttachmentServiceURL = new StringBuilder("/serviceinsertion/service-attachments/{service-attachment-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateServiceAttachmentServiceURL.Replace("{service-attachment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceAttachmentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ServiceAttachment);
            request.Resource = UpdateServiceAttachmentServiceURL.ToString();
            RestResponse<NSXTServiceAttachmentType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceAttachmentType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateServiceAttachmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteServiceAttachment(string ServiceAttachmentId)
        {
            if (ServiceAttachmentId == null) { throw new System.ArgumentNullException("ServiceAttachmentId cannot be null"); }
            StringBuilder DeleteServiceAttachmentServiceURL = new StringBuilder("/serviceinsertion/service-attachments/{service-attachment-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteServiceAttachmentServiceURL.Replace("{service-attachment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceAttachmentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteServiceAttachmentServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteServiceAttachmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceAttachmentType> GetServiceAttachment(string ServiceAttachmentId)
        {
            if (ServiceAttachmentId == null) { throw new System.ArgumentNullException("ServiceAttachmentId cannot be null"); }
            StringBuilder GetServiceAttachmentServiceURL = new StringBuilder("/serviceinsertion/service-attachments/{service-attachment-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceAttachmentServiceURL.Replace("{service-attachment-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceAttachmentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceAttachmentServiceURL.ToString();
            RestResponse<NSXTServiceAttachmentType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceAttachmentType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetServiceAttachmentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBaseServiceProfileType> GetSiserviceProfile(string ServiceId, string ServiceProfileId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (ServiceProfileId == null) { throw new System.ArgumentNullException("ServiceProfileId cannot be null"); }
            StringBuilder GetSiserviceProfileServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/service-profiles/{service-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetSiserviceProfileServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetSiserviceProfileServiceURL.Replace("{service-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetSiserviceProfileServiceURL.ToString();
            RestResponse<NSXTBaseServiceProfileType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBaseServiceProfileType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetSiserviceProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteSiserviceProfile(string ServiceId, string ServiceProfileId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (ServiceProfileId == null) { throw new System.ArgumentNullException("ServiceProfileId cannot be null"); }
            StringBuilder DeleteSiserviceProfileServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/service-profiles/{service-profile-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteSiserviceProfileServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteSiserviceProfileServiceURL.Replace("{service-profile-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceProfileId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteSiserviceProfileServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteSiserviceProfileServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServicePathListResultType> ListServicePaths(string ServiceChainId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (ServiceChainId == null) { throw new System.ArgumentNullException("ServiceChainId cannot be null"); }
            StringBuilder ListServicePathsServiceURL = new StringBuilder("/serviceinsertion/service-chains/{service-chain-id}/service-paths");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListServicePathsServiceURL.Replace("{service-chain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceChainId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListServicePathsServiceURL.ToString();
            RestResponse<NSXTServicePathListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServicePathListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListServicePathsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBaseServiceInstanceType> AddServiceInstance(string ServiceId, NSXTBaseServiceInstanceType BaseServiceInstance)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (BaseServiceInstance == null) { throw new System.ArgumentNullException("BaseServiceInstance cannot be null"); }
            StringBuilder AddServiceInstanceServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/service-instances");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            AddServiceInstanceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(BaseServiceInstance);
            request.Resource = AddServiceInstanceServiceURL.ToString();
            RestResponse<NSXTBaseServiceInstanceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBaseServiceInstanceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddServiceInstanceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInstanceListResultType> ListServiceInstancesForService(string ServiceId)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder ListServiceInstancesForServiceServiceURL = new StringBuilder("/serviceinsertion/services/{service-id}/service-instances");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListServiceInstancesForServiceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ListServiceInstancesForServiceServiceURL.ToString();
            RestResponse<NSXTServiceInstanceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInstanceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListServiceInstancesForServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceChainType> AddServiceChain(NSXTServiceChainType ServiceChain)
        {
            if (ServiceChain == null) { throw new System.ArgumentNullException("ServiceChain cannot be null"); }
            StringBuilder AddServiceChainServiceURL = new StringBuilder("/serviceinsertion/service-chains");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(ServiceChain);
            request.Resource = AddServiceChainServiceURL.ToString();
            RestResponse<NSXTServiceChainType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceChainType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddServiceChainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceChainListResultType> ListServiceChains()
        {
            StringBuilder ListServiceChainsServiceURL = new StringBuilder("/serviceinsertion/service-chains");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListServiceChainsServiceURL.ToString();
            RestResponse<NSXTServiceChainListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceChainListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListServiceChainsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
