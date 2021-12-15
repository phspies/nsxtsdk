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
    public class Ipfix
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public Ipfix(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTIpfixObsPointConfigType UpdateSwitchIpfixConfig(NSXTIpfixObsPointConfigType IpfixObsPointConfig)
        {
            if (IpfixObsPointConfig == null) { throw new System.ArgumentNullException("IpfixObsPointConfig cannot be null"); }
            NSXTIpfixObsPointConfigType returnValue = default(NSXTIpfixObsPointConfigType);
            StringBuilder UpdateSwitchIpfixConfigServiceURL = new StringBuilder("/ipfix-obs-points/switch-global");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(IpfixObsPointConfig, defaultSerializationSettings));
            request.Resource = UpdateSwitchIpfixConfigServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTIpfixObsPointConfigType>(response.Content, defaultSerializationSettings);
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
        public NSXTIpfixObsPointConfigType GetSwitchIpfixConfig()
        {
            NSXTIpfixObsPointConfigType returnValue = default(NSXTIpfixObsPointConfigType);
            StringBuilder GetSwitchIpfixConfigServiceURL = new StringBuilder("/ipfix-obs-points/switch-global");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = GetSwitchIpfixConfigServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTIpfixObsPointConfigType>(response.Content, defaultSerializationSettings);
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
        public NSXTIpfixConfigType CreateIpfixConfig(NSXTIpfixConfigType IpfixConfig)
        {
            if (IpfixConfig == null) { throw new System.ArgumentNullException("IpfixConfig cannot be null"); }
            NSXTIpfixConfigType returnValue = default(NSXTIpfixConfigType);
            StringBuilder CreateIpfixConfigServiceURL = new StringBuilder("/ipfix/configs");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(IpfixConfig, defaultSerializationSettings));
            request.Resource = CreateIpfixConfigServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTIpfixConfigType>(response.Content, defaultSerializationSettings);
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
        public NSXTIpfixConfigListResultType ListIpfixConfig(string? AppliedTo = null, string? Cursor = null, string? IncludedFields = null, string? IpfixConfigType = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTIpfixConfigListResultType returnValue = default(NSXTIpfixConfigListResultType);
            StringBuilder ListIpfixConfigServiceURL = new StringBuilder("/ipfix/configs");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (AppliedTo != null) { request.AddQueryParameter("applied_to", AppliedTo.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (IpfixConfigType != null) { request.AddQueryParameter("ipfix_config_type", IpfixConfigType.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListIpfixConfigServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTIpfixConfigListResultType>(response.Content, defaultSerializationSettings);
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
        public NSXTIpfixConfigType UpdateIpfixConfig(string ConfigId, NSXTIpfixConfigType IpfixConfig)
        {
            if (ConfigId == null) { throw new System.ArgumentNullException("ConfigId cannot be null"); }
            if (IpfixConfig == null) { throw new System.ArgumentNullException("IpfixConfig cannot be null"); }
            NSXTIpfixConfigType returnValue = default(NSXTIpfixConfigType);
            StringBuilder UpdateIpfixConfigServiceURL = new StringBuilder("/ipfix/configs/{config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            UpdateIpfixConfigServiceURL.Replace("{config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(IpfixConfig, defaultSerializationSettings));
            request.Resource = UpdateIpfixConfigServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTIpfixConfigType>(response.Content, defaultSerializationSettings);
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
        public void DeleteIpfixConfig(string ConfigId)
        {
            if (ConfigId == null) { throw new System.ArgumentNullException("ConfigId cannot be null"); }
            
            StringBuilder DeleteIpfixConfigServiceURL = new StringBuilder("/ipfix/configs/{config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeleteIpfixConfigServiceURL.Replace("{config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteIpfixConfigServiceURL.ToString();
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
        public NSXTIpfixConfigType GetIpfixConfig(string ConfigId)
        {
            if (ConfigId == null) { throw new System.ArgumentNullException("ConfigId cannot be null"); }
            NSXTIpfixConfigType returnValue = default(NSXTIpfixConfigType);
            StringBuilder GetIpfixConfigServiceURL = new StringBuilder("/ipfix/configs/{config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetIpfixConfigServiceURL.Replace("{config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetIpfixConfigServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTIpfixConfigType>(response.Content, defaultSerializationSettings);
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
        public NSXTIpfixCollectorConfigType CreateIpfixCollectorConfig(NSXTIpfixCollectorConfigType IpfixCollectorConfig)
        {
            if (IpfixCollectorConfig == null) { throw new System.ArgumentNullException("IpfixCollectorConfig cannot be null"); }
            NSXTIpfixCollectorConfigType returnValue = default(NSXTIpfixCollectorConfigType);
            StringBuilder CreateIpfixCollectorConfigServiceURL = new StringBuilder("/ipfix/collectorconfigs");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(IpfixCollectorConfig, defaultSerializationSettings));
            request.Resource = CreateIpfixCollectorConfigServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTIpfixCollectorConfigType>(response.Content, defaultSerializationSettings);
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
        public NSXTIpfixCollectorConfigListResultType ListIpfixCollectorConfig(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTIpfixCollectorConfigListResultType returnValue = default(NSXTIpfixCollectorConfigListResultType);
            StringBuilder ListIpfixCollectorConfigServiceURL = new StringBuilder("/ipfix/collectorconfigs");
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
            request.Resource = ListIpfixCollectorConfigServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTIpfixCollectorConfigListResultType>(response.Content, defaultSerializationSettings);
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
        public NSXTIpfixCollectorConfigType UpdateIpfixCollectorConfig(string CollectorConfigId, NSXTIpfixCollectorConfigType IpfixCollectorConfig)
        {
            if (CollectorConfigId == null) { throw new System.ArgumentNullException("CollectorConfigId cannot be null"); }
            if (IpfixCollectorConfig == null) { throw new System.ArgumentNullException("IpfixCollectorConfig cannot be null"); }
            NSXTIpfixCollectorConfigType returnValue = default(NSXTIpfixCollectorConfigType);
            StringBuilder UpdateIpfixCollectorConfigServiceURL = new StringBuilder("/ipfix/collectorconfigs/{collector-config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            UpdateIpfixCollectorConfigServiceURL.Replace("{collector-config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CollectorConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(IpfixCollectorConfig, defaultSerializationSettings));
            request.Resource = UpdateIpfixCollectorConfigServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTIpfixCollectorConfigType>(response.Content, defaultSerializationSettings);
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
        public void DeleteIpfixCollectorConfig(string CollectorConfigId)
        {
            if (CollectorConfigId == null) { throw new System.ArgumentNullException("CollectorConfigId cannot be null"); }
            
            StringBuilder DeleteIpfixCollectorConfigServiceURL = new StringBuilder("/ipfix/collectorconfigs/{collector-config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeleteIpfixCollectorConfigServiceURL.Replace("{collector-config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CollectorConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteIpfixCollectorConfigServiceURL.ToString();
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
        public NSXTIpfixCollectorConfigType GetIpfixCollectorConfig(string CollectorConfigId)
        {
            if (CollectorConfigId == null) { throw new System.ArgumentNullException("CollectorConfigId cannot be null"); }
            NSXTIpfixCollectorConfigType returnValue = default(NSXTIpfixCollectorConfigType);
            StringBuilder GetIpfixCollectorConfigServiceURL = new StringBuilder("/ipfix/collectorconfigs/{collector-config-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetIpfixCollectorConfigServiceURL.Replace("{collector-config-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CollectorConfigId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetIpfixCollectorConfigServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTIpfixCollectorConfigType>(response.Content, defaultSerializationSettings);
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
        public NSXTIpfixObsPointsListResultType GetIpfixObsPoints()
        {
            NSXTIpfixObsPointsListResultType returnValue = default(NSXTIpfixObsPointsListResultType);
            StringBuilder GetIpfixObsPointsServiceURL = new StringBuilder("/ipfix-obs-points");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = GetIpfixObsPointsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTIpfixObsPointsListResultType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
    }
}