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
using nsxtsdk.ManagerModels;

namespace nsxtapi.ManagerModules
{
    public class IdentityFirewall
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public IdentityFirewall(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTIdfwMasterSwitchSettingType UpdateMasterSwitchSetting(NSXTIdfwMasterSwitchSettingType IdfwMasterSwitchSetting)
        {
            if (IdfwMasterSwitchSetting == null) { throw new System.ArgumentNullException("IdfwMasterSwitchSetting cannot be null"); }
            NSXTIdfwMasterSwitchSettingType returnValue = default(NSXTIdfwMasterSwitchSettingType);
            StringBuilder UpdateMasterSwitchSettingServiceURL = new StringBuilder("/idfw/master-switch-setting");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(IdfwMasterSwitchSetting, defaultSerializationSettings));
            request.Resource = UpdateMasterSwitchSettingServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + UpdateMasterSwitchSettingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTIdfwMasterSwitchSettingType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTIdfwMasterSwitchSettingType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTIdfwMasterSwitchSettingType GetMasterSwitchSetting()
        {
            NSXTIdfwMasterSwitchSettingType returnValue = default(NSXTIdfwMasterSwitchSettingType);
            StringBuilder GetMasterSwitchSettingServiceURL = new StringBuilder("/idfw/master-switch-setting");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = GetMasterSwitchSettingServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetMasterSwitchSettingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTIdfwMasterSwitchSettingType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTIdfwMasterSwitchSettingType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTIdfwEnabledComputeCollectionType UpdateEnabledComputeCollection(string CcExtId, NSXTIdfwEnabledComputeCollectionType IdfwEnabledComputeCollection)
        {
            if (CcExtId == null) { throw new System.ArgumentNullException("CcExtId cannot be null"); }
            if (IdfwEnabledComputeCollection == null) { throw new System.ArgumentNullException("IdfwEnabledComputeCollection cannot be null"); }
            NSXTIdfwEnabledComputeCollectionType returnValue = default(NSXTIdfwEnabledComputeCollectionType);
            StringBuilder UpdateEnabledComputeCollectionServiceURL = new StringBuilder("/idfw/idfw-compute-collections/{cc-ext-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            UpdateEnabledComputeCollectionServiceURL.Replace("{cc-ext-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CcExtId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(IdfwEnabledComputeCollection, defaultSerializationSettings));
            request.Resource = UpdateEnabledComputeCollectionServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + UpdateEnabledComputeCollectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTIdfwEnabledComputeCollectionType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTIdfwEnabledComputeCollectionType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTIdfwEnabledComputeCollectionType GetEnabledComputeCollection(string CcExtId)
        {
            if (CcExtId == null) { throw new System.ArgumentNullException("CcExtId cannot be null"); }
            NSXTIdfwEnabledComputeCollectionType returnValue = default(NSXTIdfwEnabledComputeCollectionType);
            StringBuilder GetEnabledComputeCollectionServiceURL = new StringBuilder("/idfw/idfw-compute-collections/{cc-ext-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetEnabledComputeCollectionServiceURL.Replace("{cc-ext-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CcExtId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetEnabledComputeCollectionServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetEnabledComputeCollectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTIdfwEnabledComputeCollectionType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTIdfwEnabledComputeCollectionType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void DeleteEnabledComputeCollection(string CcExtId)
        {
            if (CcExtId == null) { throw new System.ArgumentNullException("CcExtId cannot be null"); }
            
            StringBuilder DeleteEnabledComputeCollectionServiceURL = new StringBuilder("/idfw/idfw-compute-collections/{cc-ext-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeleteEnabledComputeCollectionServiceURL.Replace("{cc-ext-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CcExtId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteEnabledComputeCollectionServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + DeleteEnabledComputeCollectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTIdfwTransportNodeStatusListResultType ListTransportNodeStatusesByComputeCollectionId(string CcExtId)
        {
            if (CcExtId == null) { throw new System.ArgumentNullException("CcExtId cannot be null"); }
            NSXTIdfwTransportNodeStatusListResultType returnValue = default(NSXTIdfwTransportNodeStatusListResultType);
            StringBuilder ListTransportNodeStatusesByComputeCollectionIdServiceURL = new StringBuilder("/idfw/compute-collections/{cc-ext-id}/transport-nodes/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ListTransportNodeStatusesByComputeCollectionIdServiceURL.Replace("{cc-ext-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CcExtId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ListTransportNodeStatusesByComputeCollectionIdServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListTransportNodeStatusesByComputeCollectionIdServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTIdfwTransportNodeStatusListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTIdfwTransportNodeStatusListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTIdfwComputeCollectionStatusType GetComputeCollectionStatusById(string ComputeCollectionExtId)
        {
            if (ComputeCollectionExtId == null) { throw new System.ArgumentNullException("ComputeCollectionExtId cannot be null"); }
            NSXTIdfwComputeCollectionStatusType returnValue = default(NSXTIdfwComputeCollectionStatusType);
            StringBuilder GetComputeCollectionStatusByIdServiceURL = new StringBuilder("/idfw/compute-collections/{compute-collection-ext-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetComputeCollectionStatusByIdServiceURL.Replace("{compute-collection-ext-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ComputeCollectionExtId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetComputeCollectionStatusByIdServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetComputeCollectionStatusByIdServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTIdfwComputeCollectionStatusType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTIdfwComputeCollectionStatusType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTIdfwVmStatsType GetVmStats(string VmExtId)
        {
            if (VmExtId == null) { throw new System.ArgumentNullException("VmExtId cannot be null"); }
            NSXTIdfwVmStatsType returnValue = default(NSXTIdfwVmStatsType);
            StringBuilder GetVmStatsServiceURL = new StringBuilder("/idfw/vm-stats/{vm-ext-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetVmStatsServiceURL.Replace("{vm-ext-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(VmExtId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetVmStatsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetVmStatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTIdfwVmStatsType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTIdfwVmStatsType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTIdfwSystemStatsType GetSystemStats()
        {
            NSXTIdfwSystemStatsType returnValue = default(NSXTIdfwSystemStatsType);
            StringBuilder GetSystemStatsServiceURL = new StringBuilder("/idfw/system-stats");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = GetSystemStatsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetSystemStatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTIdfwSystemStatsType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTIdfwSystemStatsType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTIdfwNsgroupVmDetailListResultType GetNsgroupVmDetails(string GroupId)
        {
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            NSXTIdfwNsgroupVmDetailListResultType returnValue = default(NSXTIdfwNsgroupVmDetailListResultType);
            StringBuilder GetNsgroupVmDetailsServiceURL = new StringBuilder("/idfw/nsgroup-vm-details/{group-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetNsgroupVmDetailsServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetNsgroupVmDetailsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetNsgroupVmDetailsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTIdfwNsgroupVmDetailListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTIdfwNsgroupVmDetailListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTIdfwUserSessionDataAndMappingsType ListUserSessions()
        {
            NSXTIdfwUserSessionDataAndMappingsType returnValue = default(NSXTIdfwUserSessionDataAndMappingsType);
            StringBuilder ListUserSessionsServiceURL = new StringBuilder("/idfw/user-session-data");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = ListUserSessionsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListUserSessionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTIdfwUserSessionDataAndMappingsType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTIdfwUserSessionDataAndMappingsType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTIdfwEnabledComputeCollectionListResultType ListEnabledComputeCollections(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTIdfwEnabledComputeCollectionListResultType returnValue = default(NSXTIdfwEnabledComputeCollectionListResultType);
            StringBuilder ListEnabledComputeCollectionsServiceURL = new StringBuilder("/idfw/idfw-compute-collections");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListEnabledComputeCollectionsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListEnabledComputeCollectionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTIdfwEnabledComputeCollectionListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTIdfwEnabledComputeCollectionListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTIdfwVirtualMachineStatusListResultType ListVirtualMachineStatusesByTransportNodeId(string TransportNodeId)
        {
            if (TransportNodeId == null) { throw new System.ArgumentNullException("TransportNodeId cannot be null"); }
            NSXTIdfwVirtualMachineStatusListResultType returnValue = default(NSXTIdfwVirtualMachineStatusListResultType);
            StringBuilder ListVirtualMachineStatusesByTransportNodeIdServiceURL = new StringBuilder("/idfw/transport-nodes/{transport-node-id}/vms/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ListVirtualMachineStatusesByTransportNodeIdServiceURL.Replace("{transport-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ListVirtualMachineStatusesByTransportNodeIdServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListVirtualMachineStatusesByTransportNodeIdServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTIdfwVirtualMachineStatusListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTIdfwVirtualMachineStatusListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTIdfwStandaloneHostsSwitchSettingType UpdateStandaloneHostsSwitchSetting(NSXTIdfwStandaloneHostsSwitchSettingType IdfwStandaloneHostsSwitchSetting)
        {
            if (IdfwStandaloneHostsSwitchSetting == null) { throw new System.ArgumentNullException("IdfwStandaloneHostsSwitchSetting cannot be null"); }
            NSXTIdfwStandaloneHostsSwitchSettingType returnValue = default(NSXTIdfwStandaloneHostsSwitchSettingType);
            StringBuilder UpdateStandaloneHostsSwitchSettingServiceURL = new StringBuilder("/idfw/standalone-host-switch-setting");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(IdfwStandaloneHostsSwitchSetting, defaultSerializationSettings));
            request.Resource = UpdateStandaloneHostsSwitchSettingServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + UpdateStandaloneHostsSwitchSettingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTIdfwStandaloneHostsSwitchSettingType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTIdfwStandaloneHostsSwitchSettingType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTIdfwStandaloneHostsSwitchSettingType GetStandaloneHostsSwitchSetting()
        {
            NSXTIdfwStandaloneHostsSwitchSettingType returnValue = default(NSXTIdfwStandaloneHostsSwitchSettingType);
            StringBuilder GetStandaloneHostsSwitchSettingServiceURL = new StringBuilder("/idfw/standalone-host-switch-setting");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = GetStandaloneHostsSwitchSettingServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetStandaloneHostsSwitchSettingServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTIdfwStandaloneHostsSwitchSettingType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTIdfwStandaloneHostsSwitchSettingType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTIdfwUserStatsType GetUserStats(string UserId)
        {
            if (UserId == null) { throw new System.ArgumentNullException("UserId cannot be null"); }
            NSXTIdfwUserStatsType returnValue = default(NSXTIdfwUserStatsType);
            StringBuilder GetUserStatsServiceURL = new StringBuilder("/idfw/user-stats/{user-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetUserStatsServiceURL.Replace("{user-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(UserId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetUserStatsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetUserStatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTIdfwUserStatsType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTIdfwUserStatsType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTIdfwComputeCollectionListResultType ListComputeCollectionStatuses()
        {
            NSXTIdfwComputeCollectionListResultType returnValue = default(NSXTIdfwComputeCollectionListResultType);
            StringBuilder ListComputeCollectionStatusesServiceURL = new StringBuilder("/idfw/compute-collections/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = ListComputeCollectionStatusesServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListComputeCollectionStatusesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTIdfwComputeCollectionListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTIdfwComputeCollectionListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
    }
}
