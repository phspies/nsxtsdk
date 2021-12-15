// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

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
    public class PolicyFirewallCPUMemThresholdsProfileBinding
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public PolicyFirewallCPUMemThresholdsProfileBinding(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapListResultType GlobalListPolicyFirewallCpumemThresholdsProfileBindingMaps(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapListResultType returnValue = default(NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapListResultType);
            StringBuilder ListPolicyFirewallCpumemThresholdsProfileBindingMapsServiceURL = new StringBuilder("/global-infra/settings/firewall/cpu-mem-thresholds-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListPolicyFirewallCpumemThresholdsProfileBindingMapsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapListResultType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapType UpdatePolicyFirewallCpumemThresholdsProfileBindingMap(string CpuMemThresholdsProfileBindingMapId, NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapType PolicyFirewallCpumemThresholdsProfileBindingMap)
        {
            if (CpuMemThresholdsProfileBindingMapId == null) { throw new System.ArgumentNullException("CpuMemThresholdsProfileBindingMapId cannot be null"); }
            if (PolicyFirewallCpumemThresholdsProfileBindingMap == null) { throw new System.ArgumentNullException("PolicyFirewallCpumemThresholdsProfileBindingMap cannot be null"); }
            NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapType returnValue = default(NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapType);
            StringBuilder UpdatePolicyFirewallCpumemThresholdsProfileBindingMapServiceURL = new StringBuilder("/infra/settings/firewall/cpu-mem-thresholds-profile-binding-maps/{cpu-mem-thresholds-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            UpdatePolicyFirewallCpumemThresholdsProfileBindingMapServiceURL.Replace("{cpu-mem-thresholds-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CpuMemThresholdsProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyFirewallCpumemThresholdsProfileBindingMap, defaultSerializationSettings));
            request.Resource = UpdatePolicyFirewallCpumemThresholdsProfileBindingMapServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapType GetPolicyFirewallCpumemThresholdsProfileBindingMap(string CpuMemThresholdsProfileBindingMapId)
        {
            if (CpuMemThresholdsProfileBindingMapId == null) { throw new System.ArgumentNullException("CpuMemThresholdsProfileBindingMapId cannot be null"); }
            NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapType returnValue = default(NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapType);
            StringBuilder GetPolicyFirewallCpumemThresholdsProfileBindingMapServiceURL = new StringBuilder("/infra/settings/firewall/cpu-mem-thresholds-profile-binding-maps/{cpu-mem-thresholds-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetPolicyFirewallCpumemThresholdsProfileBindingMapServiceURL.Replace("{cpu-mem-thresholds-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CpuMemThresholdsProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPolicyFirewallCpumemThresholdsProfileBindingMapServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void DeletePolicyFirewallCpumemThresholdsProfileBindingMap(string CpuMemThresholdsProfileBindingMapId)
        {
            if (CpuMemThresholdsProfileBindingMapId == null) { throw new System.ArgumentNullException("CpuMemThresholdsProfileBindingMapId cannot be null"); }
            
            StringBuilder DeletePolicyFirewallCpumemThresholdsProfileBindingMapServiceURL = new StringBuilder("/infra/settings/firewall/cpu-mem-thresholds-profile-binding-maps/{cpu-mem-thresholds-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeletePolicyFirewallCpumemThresholdsProfileBindingMapServiceURL.Replace("{cpu-mem-thresholds-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CpuMemThresholdsProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePolicyFirewallCpumemThresholdsProfileBindingMapServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void PatchPolicyFirewallCpumemThresholdsProfileBindingMap(string CpuMemThresholdsProfileBindingMapId, NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapType PolicyFirewallCpumemThresholdsProfileBindingMap)
        {
            if (CpuMemThresholdsProfileBindingMapId == null) { throw new System.ArgumentNullException("CpuMemThresholdsProfileBindingMapId cannot be null"); }
            if (PolicyFirewallCpumemThresholdsProfileBindingMap == null) { throw new System.ArgumentNullException("PolicyFirewallCpumemThresholdsProfileBindingMap cannot be null"); }
            
            StringBuilder PatchPolicyFirewallCpumemThresholdsProfileBindingMapServiceURL = new StringBuilder("/infra/settings/firewall/cpu-mem-thresholds-profile-binding-maps/{cpu-mem-thresholds-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            PatchPolicyFirewallCpumemThresholdsProfileBindingMapServiceURL.Replace("{cpu-mem-thresholds-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CpuMemThresholdsProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyFirewallCpumemThresholdsProfileBindingMap, defaultSerializationSettings));
            request.Resource = PatchPolicyFirewallCpumemThresholdsProfileBindingMapServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapListResultType ListPolicyFirewallCpumemThresholdsProfileBindingMaps(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapListResultType returnValue = default(NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapListResultType);
            StringBuilder ListPolicyFirewallCpumemThresholdsProfileBindingMapsServiceURL = new StringBuilder("/infra/settings/firewall/cpu-mem-thresholds-profile-binding-maps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListPolicyFirewallCpumemThresholdsProfileBindingMapsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapListResultType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapType GlobalUpdatePolicyFirewallCpumemThresholdsProfileBindingMap(string CpuMemThresholdsProfileBindingMapId, NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapType PolicyFirewallCpumemThresholdsProfileBindingMap)
        {
            if (CpuMemThresholdsProfileBindingMapId == null) { throw new System.ArgumentNullException("CpuMemThresholdsProfileBindingMapId cannot be null"); }
            if (PolicyFirewallCpumemThresholdsProfileBindingMap == null) { throw new System.ArgumentNullException("PolicyFirewallCpumemThresholdsProfileBindingMap cannot be null"); }
            NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapType returnValue = default(NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapType);
            StringBuilder UpdatePolicyFirewallCpumemThresholdsProfileBindingMapServiceURL = new StringBuilder("/global-infra/settings/firewall/cpu-mem-thresholds-profile-binding-maps/{cpu-mem-thresholds-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            UpdatePolicyFirewallCpumemThresholdsProfileBindingMapServiceURL.Replace("{cpu-mem-thresholds-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CpuMemThresholdsProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyFirewallCpumemThresholdsProfileBindingMap, defaultSerializationSettings));
            request.Resource = UpdatePolicyFirewallCpumemThresholdsProfileBindingMapServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapType GlobalGetPolicyFirewallCpumemThresholdsProfileBindingMap(string CpuMemThresholdsProfileBindingMapId)
        {
            if (CpuMemThresholdsProfileBindingMapId == null) { throw new System.ArgumentNullException("CpuMemThresholdsProfileBindingMapId cannot be null"); }
            NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapType returnValue = default(NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapType);
            StringBuilder GetPolicyFirewallCpumemThresholdsProfileBindingMapServiceURL = new StringBuilder("/global-infra/settings/firewall/cpu-mem-thresholds-profile-binding-maps/{cpu-mem-thresholds-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetPolicyFirewallCpumemThresholdsProfileBindingMapServiceURL.Replace("{cpu-mem-thresholds-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CpuMemThresholdsProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPolicyFirewallCpumemThresholdsProfileBindingMapServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void GlobalDeletePolicyFirewallCpumemThresholdsProfileBindingMap(string CpuMemThresholdsProfileBindingMapId)
        {
            if (CpuMemThresholdsProfileBindingMapId == null) { throw new System.ArgumentNullException("CpuMemThresholdsProfileBindingMapId cannot be null"); }
            
            StringBuilder DeletePolicyFirewallCpumemThresholdsProfileBindingMapServiceURL = new StringBuilder("/global-infra/settings/firewall/cpu-mem-thresholds-profile-binding-maps/{cpu-mem-thresholds-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeletePolicyFirewallCpumemThresholdsProfileBindingMapServiceURL.Replace("{cpu-mem-thresholds-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CpuMemThresholdsProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePolicyFirewallCpumemThresholdsProfileBindingMapServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void GlobalPatchPolicyFirewallCpumemThresholdsProfileBindingMap(string CpuMemThresholdsProfileBindingMapId, NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapType PolicyFirewallCpumemThresholdsProfileBindingMap)
        {
            if (CpuMemThresholdsProfileBindingMapId == null) { throw new System.ArgumentNullException("CpuMemThresholdsProfileBindingMapId cannot be null"); }
            if (PolicyFirewallCpumemThresholdsProfileBindingMap == null) { throw new System.ArgumentNullException("PolicyFirewallCpumemThresholdsProfileBindingMap cannot be null"); }
            
            StringBuilder PatchPolicyFirewallCpumemThresholdsProfileBindingMapServiceURL = new StringBuilder("/global-infra/settings/firewall/cpu-mem-thresholds-profile-binding-maps/{cpu-mem-thresholds-profile-binding-map-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            PatchPolicyFirewallCpumemThresholdsProfileBindingMapServiceURL.Replace("{cpu-mem-thresholds-profile-binding-map-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CpuMemThresholdsProfileBindingMapId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyFirewallCpumemThresholdsProfileBindingMap, defaultSerializationSettings));
            request.Resource = PatchPolicyFirewallCpumemThresholdsProfileBindingMapServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            
        }
    }
}
