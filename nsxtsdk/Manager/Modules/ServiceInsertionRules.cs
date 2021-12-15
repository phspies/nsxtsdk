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
    public class ServiceInsertionRules
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public ServiceInsertionRules(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTServiceInsertionRuleType AddServiceInsertionRuleInSection(string SectionId, NSXTServiceInsertionRuleType ServiceInsertionRule, string? Id = null, string? Operation = null)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            if (ServiceInsertionRule == null) { throw new System.ArgumentNullException("ServiceInsertionRule cannot be null"); }
            NSXTServiceInsertionRuleType returnValue = default(NSXTServiceInsertionRuleType);
            StringBuilder AddServiceInsertionRuleInSectionServiceURL = new StringBuilder("/serviceinsertion/sections/{section-id}/rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            AddServiceInsertionRuleInSectionServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(ServiceInsertionRule, defaultSerializationSettings));
            if (Id != null) { request.AddQueryParameter("id", Id.ToString()); }
            if (Operation != null) { request.AddQueryParameter("operation", Operation.ToString()); }
            request.Resource = AddServiceInsertionRuleInSectionServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTServiceInsertionRuleType>(response.Content, defaultSerializationSettings);
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
        public NSXTServiceInsertionRuleListResultType GetServiceInsertionRules(string SectionId, string? AppliedTos = null, string? Cursor = null, string? Destinations = null, string? FilterType = null, string? IncludedFields = null, long? PageSize = null, string? Services = null, bool? SortAscending = null, string? SortBy = null, string? Sources = null)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            NSXTServiceInsertionRuleListResultType returnValue = default(NSXTServiceInsertionRuleListResultType);
            StringBuilder GetServiceInsertionRulesServiceURL = new StringBuilder("/serviceinsertion/sections/{section-id}/rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetServiceInsertionRulesServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (AppliedTos != null) { request.AddQueryParameter("applied_tos", AppliedTos.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (Destinations != null) { request.AddQueryParameter("destinations", Destinations.ToString()); }
            if (FilterType != null) { request.AddQueryParameter("filter_type", FilterType.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (Services != null) { request.AddQueryParameter("services", Services.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Sources != null) { request.AddQueryParameter("sources", Sources.ToString()); }
            request.Resource = GetServiceInsertionRulesServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTServiceInsertionRuleListResultType>(response.Content, defaultSerializationSettings);
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
        public NSXTServiceInsertionSectionRuleListType GetServiceInsertionSectionWithRulesListWithRules(string SectionId)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            NSXTServiceInsertionSectionRuleListType returnValue = default(NSXTServiceInsertionSectionRuleListType);
            StringBuilder GetServiceInsertionSectionWithRulesListWithRulesServiceURL = new StringBuilder("/serviceinsertion/sections/{section-id}?action=list_with_rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            GetServiceInsertionSectionWithRulesListWithRulesServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceInsertionSectionWithRulesListWithRulesServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTServiceInsertionSectionRuleListType>(response.Content, defaultSerializationSettings);
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
        public NSXTServiceInsertionSectionRuleListType ReviseServiceInsertionSectionWithRulesReviseWithRules(string SectionId, NSXTServiceInsertionSectionRuleListType ServiceInsertionSectionRuleList, string? Id = null, string? Operation = null)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            if (ServiceInsertionSectionRuleList == null) { throw new System.ArgumentNullException("ServiceInsertionSectionRuleList cannot be null"); }
            NSXTServiceInsertionSectionRuleListType returnValue = default(NSXTServiceInsertionSectionRuleListType);
            StringBuilder ReviseServiceInsertionSectionWithRulesReviseWithRulesServiceURL = new StringBuilder("/serviceinsertion/sections/{section-id}?action=revise_with_rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            ReviseServiceInsertionSectionWithRulesReviseWithRulesServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(ServiceInsertionSectionRuleList, defaultSerializationSettings));
            if (Id != null) { request.AddQueryParameter("id", Id.ToString()); }
            if (Operation != null) { request.AddQueryParameter("operation", Operation.ToString()); }
            request.Resource = ReviseServiceInsertionSectionWithRulesReviseWithRulesServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTServiceInsertionSectionRuleListType>(response.Content, defaultSerializationSettings);
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
        public NSXTServiceInsertionSectionType UpdateServiceInsertionSection(string SectionId, NSXTServiceInsertionSectionType ServiceInsertionSection)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            if (ServiceInsertionSection == null) { throw new System.ArgumentNullException("ServiceInsertionSection cannot be null"); }
            NSXTServiceInsertionSectionType returnValue = default(NSXTServiceInsertionSectionType);
            StringBuilder UpdateServiceInsertionSectionServiceURL = new StringBuilder("/serviceinsertion/sections/{section-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            UpdateServiceInsertionSectionServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(ServiceInsertionSection, defaultSerializationSettings));
            request.Resource = UpdateServiceInsertionSectionServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTServiceInsertionSectionType>(response.Content, defaultSerializationSettings);
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
        public void DeleteServiceInsertionSection(string SectionId, bool? Cascade = null)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            
            StringBuilder DeleteServiceInsertionSectionServiceURL = new StringBuilder("/serviceinsertion/sections/{section-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeleteServiceInsertionSectionServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cascade != null) { request.AddQueryParameter("cascade", Cascade.ToString()); }
            request.Resource = DeleteServiceInsertionSectionServiceURL.ToString();
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
        public NSXTServiceInsertionSectionType GetServiceInsertionSection(string SectionId)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            NSXTServiceInsertionSectionType returnValue = default(NSXTServiceInsertionSectionType);
            StringBuilder GetServiceInsertionSectionServiceURL = new StringBuilder("/serviceinsertion/sections/{section-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetServiceInsertionSectionServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceInsertionSectionServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTServiceInsertionSectionType>(response.Content, defaultSerializationSettings);
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
        public NSXTServiceInsertionSectionRuleListType AddServiceInsertionSectionWithRulesCreateWithRules(NSXTServiceInsertionSectionRuleListType ServiceInsertionSectionRuleList, string? Id = null, string? Operation = null)
        {
            if (ServiceInsertionSectionRuleList == null) { throw new System.ArgumentNullException("ServiceInsertionSectionRuleList cannot be null"); }
            NSXTServiceInsertionSectionRuleListType returnValue = default(NSXTServiceInsertionSectionRuleListType);
            StringBuilder AddServiceInsertionSectionWithRulesCreateWithRulesServiceURL = new StringBuilder("/serviceinsertion/sections?action=create_with_rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(ServiceInsertionSectionRuleList, defaultSerializationSettings));
            if (Id != null) { request.AddQueryParameter("id", Id.ToString()); }
            if (Operation != null) { request.AddQueryParameter("operation", Operation.ToString()); }
            request.Resource = AddServiceInsertionSectionWithRulesCreateWithRulesServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTServiceInsertionSectionRuleListType>(response.Content, defaultSerializationSettings);
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
        public NSXTServiceInsertionRuleType ReviseServiceInsertionRuleRevise(string SectionId, string RuleId, NSXTServiceInsertionRuleType ServiceInsertionRule, string? Id = null, string? Operation = null)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            if (ServiceInsertionRule == null) { throw new System.ArgumentNullException("ServiceInsertionRule cannot be null"); }
            NSXTServiceInsertionRuleType returnValue = default(NSXTServiceInsertionRuleType);
            StringBuilder ReviseServiceInsertionRuleReviseServiceURL = new StringBuilder("/serviceinsertion/sections/{section-id}/rules/{rule-id}?action=revise");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            ReviseServiceInsertionRuleReviseServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            ReviseServiceInsertionRuleReviseServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(ServiceInsertionRule, defaultSerializationSettings));
            if (Id != null) { request.AddQueryParameter("id", Id.ToString()); }
            if (Operation != null) { request.AddQueryParameter("operation", Operation.ToString()); }
            request.Resource = ReviseServiceInsertionRuleReviseServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTServiceInsertionRuleType>(response.Content, defaultSerializationSettings);
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
        public NSXTServiceInsertionRuleType UpdateServiceInsertionRule(string SectionId, string RuleId, NSXTServiceInsertionRuleType ServiceInsertionRule)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            if (ServiceInsertionRule == null) { throw new System.ArgumentNullException("ServiceInsertionRule cannot be null"); }
            NSXTServiceInsertionRuleType returnValue = default(NSXTServiceInsertionRuleType);
            StringBuilder UpdateServiceInsertionRuleServiceURL = new StringBuilder("/serviceinsertion/sections/{section-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            UpdateServiceInsertionRuleServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateServiceInsertionRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(ServiceInsertionRule, defaultSerializationSettings));
            request.Resource = UpdateServiceInsertionRuleServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTServiceInsertionRuleType>(response.Content, defaultSerializationSettings);
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
        public void DeleteServiceInsertionRule(string SectionId, string RuleId)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            
            StringBuilder DeleteServiceInsertionRuleServiceURL = new StringBuilder("/serviceinsertion/sections/{section-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeleteServiceInsertionRuleServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteServiceInsertionRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteServiceInsertionRuleServiceURL.ToString();
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
        public NSXTServiceInsertionRuleType GetServiceInsertionRule(string SectionId, string RuleId)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            NSXTServiceInsertionRuleType returnValue = default(NSXTServiceInsertionRuleType);
            StringBuilder GetServiceInsertionRuleServiceURL = new StringBuilder("/serviceinsertion/sections/{section-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetServiceInsertionRuleServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            GetServiceInsertionRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceInsertionRuleServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTServiceInsertionRuleType>(response.Content, defaultSerializationSettings);
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
        public NSXTServiceInsertionSectionType ReviseServiceInsertionSectionRevise(string SectionId, NSXTServiceInsertionSectionType ServiceInsertionSection, string? Id = null, string? Operation = null)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            if (ServiceInsertionSection == null) { throw new System.ArgumentNullException("ServiceInsertionSection cannot be null"); }
            NSXTServiceInsertionSectionType returnValue = default(NSXTServiceInsertionSectionType);
            StringBuilder ReviseServiceInsertionSectionReviseServiceURL = new StringBuilder("/serviceinsertion/sections/{section-id}?action=revise");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            ReviseServiceInsertionSectionReviseServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(ServiceInsertionSection, defaultSerializationSettings));
            if (Id != null) { request.AddQueryParameter("id", Id.ToString()); }
            if (Operation != null) { request.AddQueryParameter("operation", Operation.ToString()); }
            request.Resource = ReviseServiceInsertionSectionReviseServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTServiceInsertionSectionType>(response.Content, defaultSerializationSettings);
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
        public NSXTServiceInsertionSectionRuleListType UpdateServiceInsertionSectionWithRulesUpdateWithRules(string SectionId, NSXTServiceInsertionSectionRuleListType ServiceInsertionSectionRuleList)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            if (ServiceInsertionSectionRuleList == null) { throw new System.ArgumentNullException("ServiceInsertionSectionRuleList cannot be null"); }
            NSXTServiceInsertionSectionRuleListType returnValue = default(NSXTServiceInsertionSectionRuleListType);
            StringBuilder UpdateServiceInsertionSectionWithRulesUpdateWithRulesServiceURL = new StringBuilder("/serviceinsertion/sections/{section-id}?action=update_with_rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            UpdateServiceInsertionSectionWithRulesUpdateWithRulesServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(ServiceInsertionSectionRuleList, defaultSerializationSettings));
            request.Resource = UpdateServiceInsertionSectionWithRulesUpdateWithRulesServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTServiceInsertionSectionRuleListType>(response.Content, defaultSerializationSettings);
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
        public NSXTServiceInsertionSectionType AddServiceInsertionSection(NSXTServiceInsertionSectionType ServiceInsertionSection, string? Id = null, string? Operation = null)
        {
            if (ServiceInsertionSection == null) { throw new System.ArgumentNullException("ServiceInsertionSection cannot be null"); }
            NSXTServiceInsertionSectionType returnValue = default(NSXTServiceInsertionSectionType);
            StringBuilder AddServiceInsertionSectionServiceURL = new StringBuilder("/serviceinsertion/sections");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(ServiceInsertionSection, defaultSerializationSettings));
            if (Id != null) { request.AddQueryParameter("id", Id.ToString()); }
            if (Operation != null) { request.AddQueryParameter("operation", Operation.ToString()); }
            request.Resource = AddServiceInsertionSectionServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTServiceInsertionSectionType>(response.Content, defaultSerializationSettings);
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
        public NSXTServiceInsertionSectionListResultType ListServiceInsertionSections(string? AppliedTos = null, string? Cursor = null, string? Destinations = null, string? ExcludeAppliedToType = null, string? FilterType = null, string? IncludeAppliedToType = null, string? IncludedFields = null, long? PageSize = null, string? Services = null, bool? SortAscending = null, string? SortBy = null, string? Sources = null, string? Type = null)
        {
            NSXTServiceInsertionSectionListResultType returnValue = default(NSXTServiceInsertionSectionListResultType);
            StringBuilder ListServiceInsertionSectionsServiceURL = new StringBuilder("/serviceinsertion/sections");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (AppliedTos != null) { request.AddQueryParameter("applied_tos", AppliedTos.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (Destinations != null) { request.AddQueryParameter("destinations", Destinations.ToString()); }
            if (ExcludeAppliedToType != null) { request.AddQueryParameter("exclude_applied_to_type", ExcludeAppliedToType.ToString()); }
            if (FilterType != null) { request.AddQueryParameter("filter_type", FilterType.ToString()); }
            if (IncludeAppliedToType != null) { request.AddQueryParameter("include_applied_to_type", IncludeAppliedToType.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (Services != null) { request.AddQueryParameter("services", Services.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Sources != null) { request.AddQueryParameter("sources", Sources.ToString()); }
            if (Type != null) { request.AddQueryParameter("type", Type.ToString()); }
            request.Resource = ListServiceInsertionSectionsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTServiceInsertionSectionListResultType>(response.Content, defaultSerializationSettings);
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
        public NSXTServiceInsertionRuleListType AddServiceInsertionRulesInSectionCreateMultiple(string SectionId, NSXTServiceInsertionRuleListType ServiceInsertionRuleList, string? Id = null, string? Operation = null)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            if (ServiceInsertionRuleList == null) { throw new System.ArgumentNullException("ServiceInsertionRuleList cannot be null"); }
            NSXTServiceInsertionRuleListType returnValue = default(NSXTServiceInsertionRuleListType);
            StringBuilder AddServiceInsertionRulesInSectionCreateMultipleServiceURL = new StringBuilder("/serviceinsertion/sections/{section-id}/rules?action=create_multiple");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            AddServiceInsertionRulesInSectionCreateMultipleServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(ServiceInsertionRuleList, defaultSerializationSettings));
            if (Id != null) { request.AddQueryParameter("id", Id.ToString()); }
            if (Operation != null) { request.AddQueryParameter("operation", Operation.ToString()); }
            request.Resource = AddServiceInsertionRulesInSectionCreateMultipleServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTServiceInsertionRuleListType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
    }
}
