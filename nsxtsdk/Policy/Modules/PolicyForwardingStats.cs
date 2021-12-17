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
    public class PolicyForwardingStats
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public PolicyForwardingStats(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void ResetForwardingStats(string DomainId, string? ContainerClusterPath = null, string? EnforcementPointPath = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            
            StringBuilder ResetForwardingStatsServiceURL = new StringBuilder("/infra/domains/{domain-id}/forwarding-policies/stats?action=reset");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            ResetForwardingStatsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ContainerClusterPath != null) { request.AddQueryParameter("container_cluster_path", ContainerClusterPath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = ResetForwardingStatsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + ResetForwardingStatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTForwardingPolicyStatisticsListResultType GetForwardingPolicyStats(string DomainId, string ForwardingPolicyId, string? ContainerClusterPath = null, string? EnforcementPointPath = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (ForwardingPolicyId == null) { throw new System.ArgumentNullException("ForwardingPolicyId cannot be null"); }
            NSXTForwardingPolicyStatisticsListResultType returnValue = default(NSXTForwardingPolicyStatisticsListResultType);
            StringBuilder GetForwardingPolicyStatsServiceURL = new StringBuilder("/infra/domains/{domain-id}/forwarding-policies/{forwarding-policy-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetForwardingPolicyStatsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GetForwardingPolicyStatsServiceURL.Replace("{forwarding-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ForwardingPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ContainerClusterPath != null) { request.AddQueryParameter("container_cluster_path", ContainerClusterPath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetForwardingPolicyStatsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetForwardingPolicyStatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTForwardingPolicyStatisticsListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTForwardingPolicyStatisticsListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTForwardingRuleStatisticsListResultType GetForwardingRuleStats(string DomainId, string ForwardingPolicyId, string ForwardingRuleId, string? ContainerClusterPath = null, string? EnforcementPointPath = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (ForwardingPolicyId == null) { throw new System.ArgumentNullException("ForwardingPolicyId cannot be null"); }
            if (ForwardingRuleId == null) { throw new System.ArgumentNullException("ForwardingRuleId cannot be null"); }
            NSXTForwardingRuleStatisticsListResultType returnValue = default(NSXTForwardingRuleStatisticsListResultType);
            StringBuilder GetForwardingRuleStatsServiceURL = new StringBuilder("/infra/domains/{domain-id}/forwarding-policies/{forwarding-policy-id}/rules/{forwarding-rule-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetForwardingRuleStatsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GetForwardingRuleStatsServiceURL.Replace("{forwarding-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ForwardingPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            GetForwardingRuleStatsServiceURL.Replace("{forwarding-rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ForwardingRuleId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ContainerClusterPath != null) { request.AddQueryParameter("container_cluster_path", ContainerClusterPath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetForwardingRuleStatsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetForwardingRuleStatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTForwardingRuleStatisticsListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTForwardingRuleStatisticsListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
    }
}
