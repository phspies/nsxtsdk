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
    public class PolicyGatewayProfileBinding
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyGatewayProfileBinding(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTFloodProtectionProfileBindingMapType> UpdateTier0FloodProtectionProfileBinding(string Tier0Id, string FloodProtectionProfileBindingId, NSXTFloodProtectionProfileBindingMapType FloodProtectionProfileBindingMap)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (FloodProtectionProfileBindingId == null) { throw new System.ArgumentNullException("FloodProtectionProfileBindingId cannot be null"); }
            if (FloodProtectionProfileBindingMap == null) { throw new System.ArgumentNullException("FloodProtectionProfileBindingMap cannot be null"); }
            StringBuilder UpdateTier0FloodProtectionProfileBindingServiceURL = new StringBuilder("/infra/tier-0s/{tier0-id}/flood-protection-profile-bindings/{flood-protection-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateTier0FloodProtectionProfileBindingServiceURL.Replace("{tier0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateTier0FloodProtectionProfileBindingServiceURL.Replace("{flood-protection-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FloodProtectionProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(FloodProtectionProfileBindingMap);
            request.Resource = UpdateTier0FloodProtectionProfileBindingServiceURL.ToString();
            RestResponse<NSXTFloodProtectionProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFloodProtectionProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateTier0FloodProtectionProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchTier0FloodProtectionProfileBindingMap(string Tier0Id, string FloodProtectionProfileBindingId, NSXTFloodProtectionProfileBindingMapType FloodProtectionProfileBindingMap)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (FloodProtectionProfileBindingId == null) { throw new System.ArgumentNullException("FloodProtectionProfileBindingId cannot be null"); }
            if (FloodProtectionProfileBindingMap == null) { throw new System.ArgumentNullException("FloodProtectionProfileBindingMap cannot be null"); }
            StringBuilder PatchTier0FloodProtectionProfileBindingMapServiceURL = new StringBuilder("/infra/tier-0s/{tier0-id}/flood-protection-profile-bindings/{flood-protection-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchTier0FloodProtectionProfileBindingMapServiceURL.Replace("{tier0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier0FloodProtectionProfileBindingMapServiceURL.Replace("{flood-protection-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FloodProtectionProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(FloodProtectionProfileBindingMap);
            request.Resource = PatchTier0FloodProtectionProfileBindingMapServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchTier0FloodProtectionProfileBindingMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier0FloodProtectionProfileBinding(string Tier0Id, string FloodProtectionProfileBindingId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (FloodProtectionProfileBindingId == null) { throw new System.ArgumentNullException("FloodProtectionProfileBindingId cannot be null"); }
            StringBuilder DeleteTier0FloodProtectionProfileBindingServiceURL = new StringBuilder("/infra/tier-0s/{tier0-id}/flood-protection-profile-bindings/{flood-protection-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier0FloodProtectionProfileBindingServiceURL.Replace("{tier0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier0FloodProtectionProfileBindingServiceURL.Replace("{flood-protection-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FloodProtectionProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier0FloodProtectionProfileBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier0FloodProtectionProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFloodProtectionProfileBindingMapType> GetTier0FloodProtectionProfileBinding(string Tier0Id, string FloodProtectionProfileBindingId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (FloodProtectionProfileBindingId == null) { throw new System.ArgumentNullException("FloodProtectionProfileBindingId cannot be null"); }
            StringBuilder GetTier0FloodProtectionProfileBindingServiceURL = new StringBuilder("/infra/tier-0s/{tier0-id}/flood-protection-profile-bindings/{flood-protection-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0FloodProtectionProfileBindingServiceURL.Replace("{tier0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0FloodProtectionProfileBindingServiceURL.Replace("{flood-protection-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FloodProtectionProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTier0FloodProtectionProfileBindingServiceURL.ToString();
            RestResponse<NSXTFloodProtectionProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFloodProtectionProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0FloodProtectionProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFloodProtectionProfileBindingMapType> GlobalGlobalInfraGetTier0FloodProtectionProfileBinding(string Tier0Id, string FloodProtectionProfileBindingId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (FloodProtectionProfileBindingId == null) { throw new System.ArgumentNullException("FloodProtectionProfileBindingId cannot be null"); }
            StringBuilder GlobalInfraGetTier0FloodProtectionProfileBindingServiceURL = new StringBuilder("/global-infra/tier-0s/{tier0-id}/flood-protection-profile-bindings/{flood-protection-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier0FloodProtectionProfileBindingServiceURL.Replace("{tier0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier0FloodProtectionProfileBindingServiceURL.Replace("{flood-protection-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FloodProtectionProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetTier0FloodProtectionProfileBindingServiceURL.ToString();
            RestResponse<NSXTFloodProtectionProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFloodProtectionProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier0FloodProtectionProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSessionTimerProfileBindingMapType> UpdateTier1LocaleServicesSessionTimerProfileBinding(string Tier1Id, string LocaleServicesId, string SessionTimerProfileBindingId, NSXTSessionTimerProfileBindingMapType SessionTimerProfileBindingMap)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (SessionTimerProfileBindingId == null) { throw new System.ArgumentNullException("SessionTimerProfileBindingId cannot be null"); }
            if (SessionTimerProfileBindingMap == null) { throw new System.ArgumentNullException("SessionTimerProfileBindingMap cannot be null"); }
            StringBuilder UpdateTier1LocaleServicesSessionTimerProfileBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier1-id}/locale-services/{locale-services-id}/session-timer-profile-bindings/{session-timer-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateTier1LocaleServicesSessionTimerProfileBindingServiceURL.Replace("{tier1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateTier1LocaleServicesSessionTimerProfileBindingServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateTier1LocaleServicesSessionTimerProfileBindingServiceURL.Replace("{session-timer-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionTimerProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SessionTimerProfileBindingMap);
            request.Resource = UpdateTier1LocaleServicesSessionTimerProfileBindingServiceURL.ToString();
            RestResponse<NSXTSessionTimerProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSessionTimerProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateTier1LocaleServicesSessionTimerProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchTier1LocaleServicesSessionTimerProfileBindingMap(string Tier1Id, string LocaleServicesId, string SessionTimerProfileBindingId, NSXTSessionTimerProfileBindingMapType SessionTimerProfileBindingMap)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (SessionTimerProfileBindingId == null) { throw new System.ArgumentNullException("SessionTimerProfileBindingId cannot be null"); }
            if (SessionTimerProfileBindingMap == null) { throw new System.ArgumentNullException("SessionTimerProfileBindingMap cannot be null"); }
            StringBuilder PatchTier1LocaleServicesSessionTimerProfileBindingMapServiceURL = new StringBuilder("/infra/tier-1s/{tier1-id}/locale-services/{locale-services-id}/session-timer-profile-bindings/{session-timer-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchTier1LocaleServicesSessionTimerProfileBindingMapServiceURL.Replace("{tier1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier1LocaleServicesSessionTimerProfileBindingMapServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier1LocaleServicesSessionTimerProfileBindingMapServiceURL.Replace("{session-timer-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionTimerProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SessionTimerProfileBindingMap);
            request.Resource = PatchTier1LocaleServicesSessionTimerProfileBindingMapServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchTier1LocaleServicesSessionTimerProfileBindingMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier1LocaleServicesSessionTimerProfileBinding(string Tier1Id, string LocaleServicesId, string SessionTimerProfileBindingId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (SessionTimerProfileBindingId == null) { throw new System.ArgumentNullException("SessionTimerProfileBindingId cannot be null"); }
            StringBuilder DeleteTier1LocaleServicesSessionTimerProfileBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier1-id}/locale-services/{locale-services-id}/session-timer-profile-bindings/{session-timer-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier1LocaleServicesSessionTimerProfileBindingServiceURL.Replace("{tier1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1LocaleServicesSessionTimerProfileBindingServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1LocaleServicesSessionTimerProfileBindingServiceURL.Replace("{session-timer-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionTimerProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier1LocaleServicesSessionTimerProfileBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier1LocaleServicesSessionTimerProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSessionTimerProfileBindingMapType> GetTier1LocaleServicesSessionTimerProfileBinding(string Tier1Id, string LocaleServicesId, string SessionTimerProfileBindingId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (SessionTimerProfileBindingId == null) { throw new System.ArgumentNullException("SessionTimerProfileBindingId cannot be null"); }
            StringBuilder GetTier1LocaleServicesSessionTimerProfileBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier1-id}/locale-services/{locale-services-id}/session-timer-profile-bindings/{session-timer-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1LocaleServicesSessionTimerProfileBindingServiceURL.Replace("{tier1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1LocaleServicesSessionTimerProfileBindingServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1LocaleServicesSessionTimerProfileBindingServiceURL.Replace("{session-timer-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionTimerProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTier1LocaleServicesSessionTimerProfileBindingServiceURL.ToString();
            RestResponse<NSXTSessionTimerProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSessionTimerProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1LocaleServicesSessionTimerProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSessionTimerProfileBindingMapType> UpdateTier0LocaleServicesSessionTimerProfileBinding(string Tier0Id, string LocaleServicesId, string SessionTimerProfileBindingId, NSXTSessionTimerProfileBindingMapType SessionTimerProfileBindingMap)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (SessionTimerProfileBindingId == null) { throw new System.ArgumentNullException("SessionTimerProfileBindingId cannot be null"); }
            if (SessionTimerProfileBindingMap == null) { throw new System.ArgumentNullException("SessionTimerProfileBindingMap cannot be null"); }
            StringBuilder UpdateTier0LocaleServicesSessionTimerProfileBindingServiceURL = new StringBuilder("/infra/tier-0s/{tier0-id}/locale-services/{locale-services-id}/session-timer-profile-bindings/{session-timer-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateTier0LocaleServicesSessionTimerProfileBindingServiceURL.Replace("{tier0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateTier0LocaleServicesSessionTimerProfileBindingServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateTier0LocaleServicesSessionTimerProfileBindingServiceURL.Replace("{session-timer-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionTimerProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SessionTimerProfileBindingMap);
            request.Resource = UpdateTier0LocaleServicesSessionTimerProfileBindingServiceURL.ToString();
            RestResponse<NSXTSessionTimerProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSessionTimerProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateTier0LocaleServicesSessionTimerProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSessionTimerProfileBindingMapType> GetTier0LocaleServicesSessionTimerProfileBinding(string Tier0Id, string LocaleServicesId, string SessionTimerProfileBindingId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (SessionTimerProfileBindingId == null) { throw new System.ArgumentNullException("SessionTimerProfileBindingId cannot be null"); }
            StringBuilder GetTier0LocaleServicesSessionTimerProfileBindingServiceURL = new StringBuilder("/infra/tier-0s/{tier0-id}/locale-services/{locale-services-id}/session-timer-profile-bindings/{session-timer-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0LocaleServicesSessionTimerProfileBindingServiceURL.Replace("{tier0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0LocaleServicesSessionTimerProfileBindingServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0LocaleServicesSessionTimerProfileBindingServiceURL.Replace("{session-timer-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionTimerProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTier0LocaleServicesSessionTimerProfileBindingServiceURL.ToString();
            RestResponse<NSXTSessionTimerProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSessionTimerProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0LocaleServicesSessionTimerProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier0LocaleServicesSessionTimerProfileBinding(string Tier0Id, string LocaleServicesId, string SessionTimerProfileBindingId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (SessionTimerProfileBindingId == null) { throw new System.ArgumentNullException("SessionTimerProfileBindingId cannot be null"); }
            StringBuilder DeleteTier0LocaleServicesSessionTimerProfileBindingServiceURL = new StringBuilder("/infra/tier-0s/{tier0-id}/locale-services/{locale-services-id}/session-timer-profile-bindings/{session-timer-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier0LocaleServicesSessionTimerProfileBindingServiceURL.Replace("{tier0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier0LocaleServicesSessionTimerProfileBindingServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier0LocaleServicesSessionTimerProfileBindingServiceURL.Replace("{session-timer-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionTimerProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier0LocaleServicesSessionTimerProfileBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier0LocaleServicesSessionTimerProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchTier0LocalServicesSessionTimerProfileBindingMap(string Tier0Id, string LocaleServicesId, string SessionTimerProfileBindingId, NSXTSessionTimerProfileBindingMapType SessionTimerProfileBindingMap)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (SessionTimerProfileBindingId == null) { throw new System.ArgumentNullException("SessionTimerProfileBindingId cannot be null"); }
            if (SessionTimerProfileBindingMap == null) { throw new System.ArgumentNullException("SessionTimerProfileBindingMap cannot be null"); }
            StringBuilder PatchTier0LocalServicesSessionTimerProfileBindingMapServiceURL = new StringBuilder("/infra/tier-0s/{tier0-id}/locale-services/{locale-services-id}/session-timer-profile-bindings/{session-timer-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchTier0LocalServicesSessionTimerProfileBindingMapServiceURL.Replace("{tier0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier0LocalServicesSessionTimerProfileBindingMapServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier0LocalServicesSessionTimerProfileBindingMapServiceURL.Replace("{session-timer-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionTimerProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SessionTimerProfileBindingMap);
            request.Resource = PatchTier0LocalServicesSessionTimerProfileBindingMapServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchTier0LocalServicesSessionTimerProfileBindingMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSessionTimerProfileBindingMapType> GlobalGlobalInfraGetTier1LocaleServicesSessionTimerProfileBinding(string Tier1Id, string LocaleServicesId, string SessionTimerProfileBindingId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (SessionTimerProfileBindingId == null) { throw new System.ArgumentNullException("SessionTimerProfileBindingId cannot be null"); }
            StringBuilder GlobalInfraGetTier1LocaleServicesSessionTimerProfileBindingServiceURL = new StringBuilder("/global-infra/tier-1s/{tier1-id}/locale-services/{locale-services-id}/session-timer-profile-bindings/{session-timer-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier1LocaleServicesSessionTimerProfileBindingServiceURL.Replace("{tier1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier1LocaleServicesSessionTimerProfileBindingServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier1LocaleServicesSessionTimerProfileBindingServiceURL.Replace("{session-timer-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionTimerProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetTier1LocaleServicesSessionTimerProfileBindingServiceURL.ToString();
            RestResponse<NSXTSessionTimerProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSessionTimerProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier1LocaleServicesSessionTimerProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFloodProtectionProfileBindingMapType> GlobalGlobalInfraGetTier1LocaleServicesFloodProtectionProfileBinding(string Tier1Id, string LocaleServicesId, string FloodProtectionProfileBindingId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (FloodProtectionProfileBindingId == null) { throw new System.ArgumentNullException("FloodProtectionProfileBindingId cannot be null"); }
            StringBuilder GlobalInfraGetTier1LocaleServicesFloodProtectionProfileBindingServiceURL = new StringBuilder("/global-infra/tier-1s/{tier1-id}/locale-services/{locale-services-id}/flood-protection-profile-bindings/{flood-protection-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier1LocaleServicesFloodProtectionProfileBindingServiceURL.Replace("{tier1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier1LocaleServicesFloodProtectionProfileBindingServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier1LocaleServicesFloodProtectionProfileBindingServiceURL.Replace("{flood-protection-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FloodProtectionProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetTier1LocaleServicesFloodProtectionProfileBindingServiceURL.ToString();
            RestResponse<NSXTFloodProtectionProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFloodProtectionProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier1LocaleServicesFloodProtectionProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFloodProtectionProfileBindingMapType> UpdateTier0LocaleServicesFloodProtectionProfileBinding(string Tier0Id, string LocaleServicesId, string FloodProtectionProfileBindingId, NSXTFloodProtectionProfileBindingMapType FloodProtectionProfileBindingMap)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (FloodProtectionProfileBindingId == null) { throw new System.ArgumentNullException("FloodProtectionProfileBindingId cannot be null"); }
            if (FloodProtectionProfileBindingMap == null) { throw new System.ArgumentNullException("FloodProtectionProfileBindingMap cannot be null"); }
            StringBuilder UpdateTier0LocaleServicesFloodProtectionProfileBindingServiceURL = new StringBuilder("/infra/tier-0s/{tier0-id}/locale-services/{locale-services-id}/flood-protection-profile-bindings/{flood-protection-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateTier0LocaleServicesFloodProtectionProfileBindingServiceURL.Replace("{tier0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateTier0LocaleServicesFloodProtectionProfileBindingServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateTier0LocaleServicesFloodProtectionProfileBindingServiceURL.Replace("{flood-protection-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FloodProtectionProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(FloodProtectionProfileBindingMap);
            request.Resource = UpdateTier0LocaleServicesFloodProtectionProfileBindingServiceURL.ToString();
            RestResponse<NSXTFloodProtectionProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFloodProtectionProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateTier0LocaleServicesFloodProtectionProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFloodProtectionProfileBindingMapType> GetTier0LocaleServicesFloodProtectionProfileBinding(string Tier0Id, string LocaleServicesId, string FloodProtectionProfileBindingId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (FloodProtectionProfileBindingId == null) { throw new System.ArgumentNullException("FloodProtectionProfileBindingId cannot be null"); }
            StringBuilder GetTier0LocaleServicesFloodProtectionProfileBindingServiceURL = new StringBuilder("/infra/tier-0s/{tier0-id}/locale-services/{locale-services-id}/flood-protection-profile-bindings/{flood-protection-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0LocaleServicesFloodProtectionProfileBindingServiceURL.Replace("{tier0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0LocaleServicesFloodProtectionProfileBindingServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0LocaleServicesFloodProtectionProfileBindingServiceURL.Replace("{flood-protection-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FloodProtectionProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTier0LocaleServicesFloodProtectionProfileBindingServiceURL.ToString();
            RestResponse<NSXTFloodProtectionProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFloodProtectionProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0LocaleServicesFloodProtectionProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier0LocaleServicesFloodProtectionProfileBinding(string Tier0Id, string LocaleServicesId, string FloodProtectionProfileBindingId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (FloodProtectionProfileBindingId == null) { throw new System.ArgumentNullException("FloodProtectionProfileBindingId cannot be null"); }
            StringBuilder DeleteTier0LocaleServicesFloodProtectionProfileBindingServiceURL = new StringBuilder("/infra/tier-0s/{tier0-id}/locale-services/{locale-services-id}/flood-protection-profile-bindings/{flood-protection-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier0LocaleServicesFloodProtectionProfileBindingServiceURL.Replace("{tier0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier0LocaleServicesFloodProtectionProfileBindingServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier0LocaleServicesFloodProtectionProfileBindingServiceURL.Replace("{flood-protection-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FloodProtectionProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier0LocaleServicesFloodProtectionProfileBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier0LocaleServicesFloodProtectionProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchTier0LocaleServicesFloodProtectionProfileBindingMap(string Tier0Id, string LocaleServicesId, string FloodProtectionProfileBindingId, NSXTFloodProtectionProfileBindingMapType FloodProtectionProfileBindingMap)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (FloodProtectionProfileBindingId == null) { throw new System.ArgumentNullException("FloodProtectionProfileBindingId cannot be null"); }
            if (FloodProtectionProfileBindingMap == null) { throw new System.ArgumentNullException("FloodProtectionProfileBindingMap cannot be null"); }
            StringBuilder PatchTier0LocaleServicesFloodProtectionProfileBindingMapServiceURL = new StringBuilder("/infra/tier-0s/{tier0-id}/locale-services/{locale-services-id}/flood-protection-profile-bindings/{flood-protection-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchTier0LocaleServicesFloodProtectionProfileBindingMapServiceURL.Replace("{tier0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier0LocaleServicesFloodProtectionProfileBindingMapServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier0LocaleServicesFloodProtectionProfileBindingMapServiceURL.Replace("{flood-protection-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FloodProtectionProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(FloodProtectionProfileBindingMap);
            request.Resource = PatchTier0LocaleServicesFloodProtectionProfileBindingMapServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchTier0LocaleServicesFloodProtectionProfileBindingMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFloodProtectionProfileBindingMapType> UpdateTier1LocaleServicesFloodProtectionProfileBinding(string Tier1Id, string LocaleServicesId, string FloodProtectionProfileBindingId, NSXTFloodProtectionProfileBindingMapType FloodProtectionProfileBindingMap)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (FloodProtectionProfileBindingId == null) { throw new System.ArgumentNullException("FloodProtectionProfileBindingId cannot be null"); }
            if (FloodProtectionProfileBindingMap == null) { throw new System.ArgumentNullException("FloodProtectionProfileBindingMap cannot be null"); }
            StringBuilder UpdateTier1LocaleServicesFloodProtectionProfileBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier1-id}/locale-services/{locale-services-id}/flood-protection-profile-bindings/{flood-protection-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateTier1LocaleServicesFloodProtectionProfileBindingServiceURL.Replace("{tier1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateTier1LocaleServicesFloodProtectionProfileBindingServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateTier1LocaleServicesFloodProtectionProfileBindingServiceURL.Replace("{flood-protection-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FloodProtectionProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(FloodProtectionProfileBindingMap);
            request.Resource = UpdateTier1LocaleServicesFloodProtectionProfileBindingServiceURL.ToString();
            RestResponse<NSXTFloodProtectionProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFloodProtectionProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateTier1LocaleServicesFloodProtectionProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier1LocaleServicesFloodProtectionProfileBinding(string Tier1Id, string LocaleServicesId, string FloodProtectionProfileBindingId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (FloodProtectionProfileBindingId == null) { throw new System.ArgumentNullException("FloodProtectionProfileBindingId cannot be null"); }
            StringBuilder DeleteTier1LocaleServicesFloodProtectionProfileBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier1-id}/locale-services/{locale-services-id}/flood-protection-profile-bindings/{flood-protection-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier1LocaleServicesFloodProtectionProfileBindingServiceURL.Replace("{tier1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1LocaleServicesFloodProtectionProfileBindingServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1LocaleServicesFloodProtectionProfileBindingServiceURL.Replace("{flood-protection-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FloodProtectionProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier1LocaleServicesFloodProtectionProfileBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier1LocaleServicesFloodProtectionProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFloodProtectionProfileBindingMapType> GetTier1LocaleServicesFloodProtectionProfileBinding(string Tier1Id, string LocaleServicesId, string FloodProtectionProfileBindingId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (FloodProtectionProfileBindingId == null) { throw new System.ArgumentNullException("FloodProtectionProfileBindingId cannot be null"); }
            StringBuilder GetTier1LocaleServicesFloodProtectionProfileBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier1-id}/locale-services/{locale-services-id}/flood-protection-profile-bindings/{flood-protection-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1LocaleServicesFloodProtectionProfileBindingServiceURL.Replace("{tier1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1LocaleServicesFloodProtectionProfileBindingServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1LocaleServicesFloodProtectionProfileBindingServiceURL.Replace("{flood-protection-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FloodProtectionProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTier1LocaleServicesFloodProtectionProfileBindingServiceURL.ToString();
            RestResponse<NSXTFloodProtectionProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFloodProtectionProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1LocaleServicesFloodProtectionProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchTier1LocaleServicesFloodProtectionProfileBindingMap(string Tier1Id, string LocaleServicesId, string FloodProtectionProfileBindingId, NSXTFloodProtectionProfileBindingMapType FloodProtectionProfileBindingMap)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (FloodProtectionProfileBindingId == null) { throw new System.ArgumentNullException("FloodProtectionProfileBindingId cannot be null"); }
            if (FloodProtectionProfileBindingMap == null) { throw new System.ArgumentNullException("FloodProtectionProfileBindingMap cannot be null"); }
            StringBuilder PatchTier1LocaleServicesFloodProtectionProfileBindingMapServiceURL = new StringBuilder("/infra/tier-1s/{tier1-id}/locale-services/{locale-services-id}/flood-protection-profile-bindings/{flood-protection-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchTier1LocaleServicesFloodProtectionProfileBindingMapServiceURL.Replace("{tier1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier1LocaleServicesFloodProtectionProfileBindingMapServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier1LocaleServicesFloodProtectionProfileBindingMapServiceURL.Replace("{flood-protection-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FloodProtectionProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(FloodProtectionProfileBindingMap);
            request.Resource = PatchTier1LocaleServicesFloodProtectionProfileBindingMapServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchTier1LocaleServicesFloodProtectionProfileBindingMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSessionTimerProfileBindingMapType> UpdateTier0SessionTimerProfileBinding(string Tier0Id, string SessionTimerProfileBindingId, NSXTSessionTimerProfileBindingMapType SessionTimerProfileBindingMap)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (SessionTimerProfileBindingId == null) { throw new System.ArgumentNullException("SessionTimerProfileBindingId cannot be null"); }
            if (SessionTimerProfileBindingMap == null) { throw new System.ArgumentNullException("SessionTimerProfileBindingMap cannot be null"); }
            StringBuilder UpdateTier0SessionTimerProfileBindingServiceURL = new StringBuilder("/infra/tier-0s/{tier0-id}/session-timer-profile-bindings/{session-timer-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateTier0SessionTimerProfileBindingServiceURL.Replace("{tier0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateTier0SessionTimerProfileBindingServiceURL.Replace("{session-timer-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionTimerProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SessionTimerProfileBindingMap);
            request.Resource = UpdateTier0SessionTimerProfileBindingServiceURL.ToString();
            RestResponse<NSXTSessionTimerProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSessionTimerProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateTier0SessionTimerProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier0SessionTimerProfileBinding(string Tier0Id, string SessionTimerProfileBindingId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (SessionTimerProfileBindingId == null) { throw new System.ArgumentNullException("SessionTimerProfileBindingId cannot be null"); }
            StringBuilder DeleteTier0SessionTimerProfileBindingServiceURL = new StringBuilder("/infra/tier-0s/{tier0-id}/session-timer-profile-bindings/{session-timer-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier0SessionTimerProfileBindingServiceURL.Replace("{tier0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier0SessionTimerProfileBindingServiceURL.Replace("{session-timer-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionTimerProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier0SessionTimerProfileBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier0SessionTimerProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSessionTimerProfileBindingMapType> GetTier0SessionTimerProfileBinding(string Tier0Id, string SessionTimerProfileBindingId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (SessionTimerProfileBindingId == null) { throw new System.ArgumentNullException("SessionTimerProfileBindingId cannot be null"); }
            StringBuilder GetTier0SessionTimerProfileBindingServiceURL = new StringBuilder("/infra/tier-0s/{tier0-id}/session-timer-profile-bindings/{session-timer-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0SessionTimerProfileBindingServiceURL.Replace("{tier0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0SessionTimerProfileBindingServiceURL.Replace("{session-timer-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionTimerProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTier0SessionTimerProfileBindingServiceURL.ToString();
            RestResponse<NSXTSessionTimerProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSessionTimerProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0SessionTimerProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchTier0SessionTimerProfileBindingMap(string Tier0Id, string SessionTimerProfileBindingId, NSXTSessionTimerProfileBindingMapType SessionTimerProfileBindingMap)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (SessionTimerProfileBindingId == null) { throw new System.ArgumentNullException("SessionTimerProfileBindingId cannot be null"); }
            if (SessionTimerProfileBindingMap == null) { throw new System.ArgumentNullException("SessionTimerProfileBindingMap cannot be null"); }
            StringBuilder PatchTier0SessionTimerProfileBindingMapServiceURL = new StringBuilder("/infra/tier-0s/{tier0-id}/session-timer-profile-bindings/{session-timer-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchTier0SessionTimerProfileBindingMapServiceURL.Replace("{tier0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier0SessionTimerProfileBindingMapServiceURL.Replace("{session-timer-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionTimerProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SessionTimerProfileBindingMap);
            request.Resource = PatchTier0SessionTimerProfileBindingMapServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchTier0SessionTimerProfileBindingMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsConfigProfileBindingMapType> GlobalGlobalInfraGetTier1TlsConfigProfileBindingMap(string Tier1Id, string TlsInspectionConfigProfileBindingId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (TlsInspectionConfigProfileBindingId == null) { throw new System.ArgumentNullException("TlsInspectionConfigProfileBindingId cannot be null"); }
            StringBuilder GlobalInfraGetTier1TlsConfigProfileBindingMapServiceURL = new StringBuilder("/global-infra/tier-1s/{tier1-id}/tls-inspection-config-profile-bindings/{tls-inspection-config-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier1TlsConfigProfileBindingMapServiceURL.Replace("{tier1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier1TlsConfigProfileBindingMapServiceURL.Replace("{tls-inspection-config-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TlsInspectionConfigProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetTier1TlsConfigProfileBindingMapServiceURL.ToString();
            RestResponse<NSXTTlsConfigProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsConfigProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier1TlsConfigProfileBindingMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSessionTimerProfileBindingMapType> GlobalGlobalInfraGetTier0SessionTimerProfileBinding(string Tier0Id, string SessionTimerProfileBindingId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (SessionTimerProfileBindingId == null) { throw new System.ArgumentNullException("SessionTimerProfileBindingId cannot be null"); }
            StringBuilder GlobalInfraGetTier0SessionTimerProfileBindingServiceURL = new StringBuilder("/global-infra/tier-0s/{tier0-id}/session-timer-profile-bindings/{session-timer-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier0SessionTimerProfileBindingServiceURL.Replace("{tier0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier0SessionTimerProfileBindingServiceURL.Replace("{session-timer-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionTimerProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetTier0SessionTimerProfileBindingServiceURL.ToString();
            RestResponse<NSXTSessionTimerProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSessionTimerProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier0SessionTimerProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFloodProtectionProfileBindingMapType> GlobalGlobalInfraGetTier0LocaleServicesFloodProtectionProfileBinding(string Tier0Id, string LocaleServicesId, string FloodProtectionProfileBindingId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (FloodProtectionProfileBindingId == null) { throw new System.ArgumentNullException("FloodProtectionProfileBindingId cannot be null"); }
            StringBuilder GlobalInfraGetTier0LocaleServicesFloodProtectionProfileBindingServiceURL = new StringBuilder("/global-infra/tier-0s/{tier0-id}/locale-services/{locale-services-id}/flood-protection-profile-bindings/{flood-protection-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier0LocaleServicesFloodProtectionProfileBindingServiceURL.Replace("{tier0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier0LocaleServicesFloodProtectionProfileBindingServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier0LocaleServicesFloodProtectionProfileBindingServiceURL.Replace("{flood-protection-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FloodProtectionProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetTier0LocaleServicesFloodProtectionProfileBindingServiceURL.ToString();
            RestResponse<NSXTFloodProtectionProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFloodProtectionProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier0LocaleServicesFloodProtectionProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSessionTimerProfileBindingMapType> GlobalGlobalInfraGetTier1SessionTimerProfileBinding(string Tier1Id, string SessionTimerProfileBindingId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SessionTimerProfileBindingId == null) { throw new System.ArgumentNullException("SessionTimerProfileBindingId cannot be null"); }
            StringBuilder GlobalInfraGetTier1SessionTimerProfileBindingServiceURL = new StringBuilder("/global-infra/tier-1s/{tier1-id}/session-timer-profile-bindings/{session-timer-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier1SessionTimerProfileBindingServiceURL.Replace("{tier1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier1SessionTimerProfileBindingServiceURL.Replace("{session-timer-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionTimerProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetTier1SessionTimerProfileBindingServiceURL.ToString();
            RestResponse<NSXTSessionTimerProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSessionTimerProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier1SessionTimerProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFloodProtectionProfileBindingMapType> UpdateTier1FloodProtectionProfileBinding(string Tier1Id, string FloodProtectionProfileBindingId, NSXTFloodProtectionProfileBindingMapType FloodProtectionProfileBindingMap)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (FloodProtectionProfileBindingId == null) { throw new System.ArgumentNullException("FloodProtectionProfileBindingId cannot be null"); }
            if (FloodProtectionProfileBindingMap == null) { throw new System.ArgumentNullException("FloodProtectionProfileBindingMap cannot be null"); }
            StringBuilder UpdateTier1FloodProtectionProfileBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier1-id}/flood-protection-profile-bindings/{flood-protection-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateTier1FloodProtectionProfileBindingServiceURL.Replace("{tier1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateTier1FloodProtectionProfileBindingServiceURL.Replace("{flood-protection-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FloodProtectionProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(FloodProtectionProfileBindingMap);
            request.Resource = UpdateTier1FloodProtectionProfileBindingServiceURL.ToString();
            RestResponse<NSXTFloodProtectionProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFloodProtectionProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateTier1FloodProtectionProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier1FloodProtectionProfileBinding(string Tier1Id, string FloodProtectionProfileBindingId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (FloodProtectionProfileBindingId == null) { throw new System.ArgumentNullException("FloodProtectionProfileBindingId cannot be null"); }
            StringBuilder DeleteTier1FloodProtectionProfileBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier1-id}/flood-protection-profile-bindings/{flood-protection-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier1FloodProtectionProfileBindingServiceURL.Replace("{tier1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1FloodProtectionProfileBindingServiceURL.Replace("{flood-protection-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FloodProtectionProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier1FloodProtectionProfileBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier1FloodProtectionProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFloodProtectionProfileBindingMapType> GetTier1FloodProtectionProfileBinding(string Tier1Id, string FloodProtectionProfileBindingId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (FloodProtectionProfileBindingId == null) { throw new System.ArgumentNullException("FloodProtectionProfileBindingId cannot be null"); }
            StringBuilder GetTier1FloodProtectionProfileBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier1-id}/flood-protection-profile-bindings/{flood-protection-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1FloodProtectionProfileBindingServiceURL.Replace("{tier1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1FloodProtectionProfileBindingServiceURL.Replace("{flood-protection-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FloodProtectionProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTier1FloodProtectionProfileBindingServiceURL.ToString();
            RestResponse<NSXTFloodProtectionProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFloodProtectionProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1FloodProtectionProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchTier1FloodProtectionProfileBindingMap(string Tier1Id, string FloodProtectionProfileBindingId, NSXTFloodProtectionProfileBindingMapType FloodProtectionProfileBindingMap)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (FloodProtectionProfileBindingId == null) { throw new System.ArgumentNullException("FloodProtectionProfileBindingId cannot be null"); }
            if (FloodProtectionProfileBindingMap == null) { throw new System.ArgumentNullException("FloodProtectionProfileBindingMap cannot be null"); }
            StringBuilder PatchTier1FloodProtectionProfileBindingMapServiceURL = new StringBuilder("/infra/tier-1s/{tier1-id}/flood-protection-profile-bindings/{flood-protection-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchTier1FloodProtectionProfileBindingMapServiceURL.Replace("{tier1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier1FloodProtectionProfileBindingMapServiceURL.Replace("{flood-protection-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FloodProtectionProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(FloodProtectionProfileBindingMap);
            request.Resource = PatchTier1FloodProtectionProfileBindingMapServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchTier1FloodProtectionProfileBindingMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsConfigProfileBindingMapType> UpdateTier1TlsConfigProfileBindingMap(string Tier1Id, string TlsInspectionConfigProfileBindingId, NSXTTlsConfigProfileBindingMapType TlsConfigProfileBindingMap)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (TlsInspectionConfigProfileBindingId == null) { throw new System.ArgumentNullException("TlsInspectionConfigProfileBindingId cannot be null"); }
            if (TlsConfigProfileBindingMap == null) { throw new System.ArgumentNullException("TlsConfigProfileBindingMap cannot be null"); }
            StringBuilder UpdateTier1TlsConfigProfileBindingMapServiceURL = new StringBuilder("/infra/tier-1s/{tier1-id}/tls-inspection-config-profile-bindings/{tls-inspection-config-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateTier1TlsConfigProfileBindingMapServiceURL.Replace("{tier1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateTier1TlsConfigProfileBindingMapServiceURL.Replace("{tls-inspection-config-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TlsInspectionConfigProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(TlsConfigProfileBindingMap);
            request.Resource = UpdateTier1TlsConfigProfileBindingMapServiceURL.ToString();
            RestResponse<NSXTTlsConfigProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsConfigProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateTier1TlsConfigProfileBindingMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier1TlsConfigProfileBindingMap(string Tier1Id, string TlsInspectionConfigProfileBindingId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (TlsInspectionConfigProfileBindingId == null) { throw new System.ArgumentNullException("TlsInspectionConfigProfileBindingId cannot be null"); }
            StringBuilder DeleteTier1TlsConfigProfileBindingMapServiceURL = new StringBuilder("/infra/tier-1s/{tier1-id}/tls-inspection-config-profile-bindings/{tls-inspection-config-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier1TlsConfigProfileBindingMapServiceURL.Replace("{tier1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1TlsConfigProfileBindingMapServiceURL.Replace("{tls-inspection-config-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TlsInspectionConfigProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier1TlsConfigProfileBindingMapServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier1TlsConfigProfileBindingMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsConfigProfileBindingMapType> GetTier1TlsConfigProfileBindingMap(string Tier1Id, string TlsInspectionConfigProfileBindingId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (TlsInspectionConfigProfileBindingId == null) { throw new System.ArgumentNullException("TlsInspectionConfigProfileBindingId cannot be null"); }
            StringBuilder GetTier1TlsConfigProfileBindingMapServiceURL = new StringBuilder("/infra/tier-1s/{tier1-id}/tls-inspection-config-profile-bindings/{tls-inspection-config-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1TlsConfigProfileBindingMapServiceURL.Replace("{tier1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1TlsConfigProfileBindingMapServiceURL.Replace("{tls-inspection-config-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TlsInspectionConfigProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTier1TlsConfigProfileBindingMapServiceURL.ToString();
            RestResponse<NSXTTlsConfigProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsConfigProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1TlsConfigProfileBindingMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsConfigProfileBindingMapType> PatchTier1TlsConfigProfileBindingMap(string Tier1Id, string TlsInspectionConfigProfileBindingId, NSXTTlsConfigProfileBindingMapType TlsConfigProfileBindingMap)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (TlsInspectionConfigProfileBindingId == null) { throw new System.ArgumentNullException("TlsInspectionConfigProfileBindingId cannot be null"); }
            if (TlsConfigProfileBindingMap == null) { throw new System.ArgumentNullException("TlsConfigProfileBindingMap cannot be null"); }
            StringBuilder PatchTier1TlsConfigProfileBindingMapServiceURL = new StringBuilder("/infra/tier-1s/{tier1-id}/tls-inspection-config-profile-bindings/{tls-inspection-config-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchTier1TlsConfigProfileBindingMapServiceURL.Replace("{tier1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier1TlsConfigProfileBindingMapServiceURL.Replace("{tls-inspection-config-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TlsInspectionConfigProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(TlsConfigProfileBindingMap);
            request.Resource = PatchTier1TlsConfigProfileBindingMapServiceURL.ToString();
            RestResponse<NSXTTlsConfigProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsConfigProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchTier1TlsConfigProfileBindingMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFloodProtectionProfileBindingMapType> GlobalGlobalInfraGetTier1FloodProtectionProfileBinding(string Tier1Id, string FloodProtectionProfileBindingId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (FloodProtectionProfileBindingId == null) { throw new System.ArgumentNullException("FloodProtectionProfileBindingId cannot be null"); }
            StringBuilder GlobalInfraGetTier1FloodProtectionProfileBindingServiceURL = new StringBuilder("/global-infra/tier-1s/{tier1-id}/flood-protection-profile-bindings/{flood-protection-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier1FloodProtectionProfileBindingServiceURL.Replace("{tier1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier1FloodProtectionProfileBindingServiceURL.Replace("{flood-protection-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FloodProtectionProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetTier1FloodProtectionProfileBindingServiceURL.ToString();
            RestResponse<NSXTFloodProtectionProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFloodProtectionProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier1FloodProtectionProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSessionTimerProfileBindingMapType> UpdateTier1SessionTimerProfileBinding(string Tier1Id, string SessionTimerProfileBindingId, NSXTSessionTimerProfileBindingMapType SessionTimerProfileBindingMap)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SessionTimerProfileBindingId == null) { throw new System.ArgumentNullException("SessionTimerProfileBindingId cannot be null"); }
            if (SessionTimerProfileBindingMap == null) { throw new System.ArgumentNullException("SessionTimerProfileBindingMap cannot be null"); }
            StringBuilder UpdateTier1SessionTimerProfileBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier1-id}/session-timer-profile-bindings/{session-timer-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateTier1SessionTimerProfileBindingServiceURL.Replace("{tier1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateTier1SessionTimerProfileBindingServiceURL.Replace("{session-timer-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionTimerProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SessionTimerProfileBindingMap);
            request.Resource = UpdateTier1SessionTimerProfileBindingServiceURL.ToString();
            RestResponse<NSXTSessionTimerProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSessionTimerProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateTier1SessionTimerProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier1SessionTimerProfileBinding(string Tier1Id, string SessionTimerProfileBindingId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SessionTimerProfileBindingId == null) { throw new System.ArgumentNullException("SessionTimerProfileBindingId cannot be null"); }
            StringBuilder DeleteTier1SessionTimerProfileBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier1-id}/session-timer-profile-bindings/{session-timer-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier1SessionTimerProfileBindingServiceURL.Replace("{tier1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier1SessionTimerProfileBindingServiceURL.Replace("{session-timer-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionTimerProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier1SessionTimerProfileBindingServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier1SessionTimerProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSessionTimerProfileBindingMapType> GetTier1SessionTimerProfileBinding(string Tier1Id, string SessionTimerProfileBindingId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SessionTimerProfileBindingId == null) { throw new System.ArgumentNullException("SessionTimerProfileBindingId cannot be null"); }
            StringBuilder GetTier1SessionTimerProfileBindingServiceURL = new StringBuilder("/infra/tier-1s/{tier1-id}/session-timer-profile-bindings/{session-timer-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1SessionTimerProfileBindingServiceURL.Replace("{tier1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1SessionTimerProfileBindingServiceURL.Replace("{session-timer-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionTimerProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTier1SessionTimerProfileBindingServiceURL.ToString();
            RestResponse<NSXTSessionTimerProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSessionTimerProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1SessionTimerProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchTier1SessionTimerProfileBindingMap(string Tier1Id, string SessionTimerProfileBindingId, NSXTSessionTimerProfileBindingMapType SessionTimerProfileBindingMap)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (SessionTimerProfileBindingId == null) { throw new System.ArgumentNullException("SessionTimerProfileBindingId cannot be null"); }
            if (SessionTimerProfileBindingMap == null) { throw new System.ArgumentNullException("SessionTimerProfileBindingMap cannot be null"); }
            StringBuilder PatchTier1SessionTimerProfileBindingMapServiceURL = new StringBuilder("/infra/tier-1s/{tier1-id}/session-timer-profile-bindings/{session-timer-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchTier1SessionTimerProfileBindingMapServiceURL.Replace("{tier1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier1SessionTimerProfileBindingMapServiceURL.Replace("{session-timer-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionTimerProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SessionTimerProfileBindingMap);
            request.Resource = PatchTier1SessionTimerProfileBindingMapServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchTier1SessionTimerProfileBindingMapServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSessionTimerProfileBindingMapType> GlobalGlobalInfraGetTier0LocaleServicesSessionTimerProfileBinding(string Tier0Id, string LocaleServicesId, string SessionTimerProfileBindingId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            if (SessionTimerProfileBindingId == null) { throw new System.ArgumentNullException("SessionTimerProfileBindingId cannot be null"); }
            StringBuilder GlobalInfraGetTier0LocaleServicesSessionTimerProfileBindingServiceURL = new StringBuilder("/global-infra/tier-0s/{tier0-id}/locale-services/{locale-services-id}/session-timer-profile-bindings/{session-timer-profile-binding-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier0LocaleServicesSessionTimerProfileBindingServiceURL.Replace("{tier0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier0LocaleServicesSessionTimerProfileBindingServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetTier0LocaleServicesSessionTimerProfileBindingServiceURL.Replace("{session-timer-profile-binding-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionTimerProfileBindingId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetTier0LocaleServicesSessionTimerProfileBindingServiceURL.ToString();
            RestResponse<NSXTSessionTimerProfileBindingMapType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSessionTimerProfileBindingMapType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier0LocaleServicesSessionTimerProfileBindingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
