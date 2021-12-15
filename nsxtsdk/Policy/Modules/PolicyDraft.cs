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
    public class PolicyDraft
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public PolicyDraft(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTPolicyDraftPaginatedAggregatedConfigurationResultType GetPolicyDraftPaginatedAggregatedConfigurationResult(string DraftId, string? RequestId = null, string? RootPath = null)
        {
            if (DraftId == null) { throw new System.ArgumentNullException("DraftId cannot be null"); }
            NSXTPolicyDraftPaginatedAggregatedConfigurationResultType returnValue = default(NSXTPolicyDraftPaginatedAggregatedConfigurationResultType);
            StringBuilder GetPolicyDraftPaginatedAggregatedConfigurationResultServiceURL = new StringBuilder("/infra/drafts/{draft-id}/aggregated_with_pagination");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetPolicyDraftPaginatedAggregatedConfigurationResultServiceURL.Replace("{draft-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DraftId, System.Globalization.CultureInfo.InvariantCulture)));
            if (RequestId != null) { request.AddQueryParameter("request_id", RequestId.ToString()); }
            if (RootPath != null) { request.AddQueryParameter("root_path", RootPath.ToString()); }
            request.Resource = GetPolicyDraftPaginatedAggregatedConfigurationResultServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTPolicyDraftPaginatedAggregatedConfigurationResultType>(response.Content, defaultSerializationSettings);
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
        public NSXTInfraType GetPreviewOfConfigurationAfterPublishOfDraft(string DraftId)
        {
            if (DraftId == null) { throw new System.ArgumentNullException("DraftId cannot be null"); }
            NSXTInfraType returnValue = default(NSXTInfraType);
            StringBuilder GetPreviewOfConfigurationAfterPublishOfDraftServiceURL = new StringBuilder("/infra/drafts/{draft-id}/complete");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetPreviewOfConfigurationAfterPublishOfDraftServiceURL.Replace("{draft-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DraftId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPreviewOfConfigurationAfterPublishOfDraftServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTInfraType>(response.Content, defaultSerializationSettings);
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
        public NSXTPolicyDraftType PutDraft(string DraftId, NSXTPolicyDraftType PolicyDraft)
        {
            if (DraftId == null) { throw new System.ArgumentNullException("DraftId cannot be null"); }
            if (PolicyDraft == null) { throw new System.ArgumentNullException("PolicyDraft cannot be null"); }
            NSXTPolicyDraftType returnValue = default(NSXTPolicyDraftType);
            StringBuilder PutDraftServiceURL = new StringBuilder("/infra/drafts/{draft-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            PutDraftServiceURL.Replace("{draft-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DraftId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyDraft, defaultSerializationSettings));
            request.Resource = PutDraftServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTPolicyDraftType>(response.Content, defaultSerializationSettings);
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
        public void DeleteDraft(string DraftId)
        {
            if (DraftId == null) { throw new System.ArgumentNullException("DraftId cannot be null"); }
            
            StringBuilder DeleteDraftServiceURL = new StringBuilder("/infra/drafts/{draft-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeleteDraftServiceURL.Replace("{draft-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DraftId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteDraftServiceURL.ToString();
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
        public void PatchDraft(string DraftId, NSXTPolicyDraftType PolicyDraft)
        {
            if (DraftId == null) { throw new System.ArgumentNullException("DraftId cannot be null"); }
            if (PolicyDraft == null) { throw new System.ArgumentNullException("PolicyDraft cannot be null"); }
            
            StringBuilder PatchDraftServiceURL = new StringBuilder("/infra/drafts/{draft-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            PatchDraftServiceURL.Replace("{draft-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DraftId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyDraft, defaultSerializationSettings));
            request.Resource = PatchDraftServiceURL.ToString();
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
        public NSXTPolicyDraftType ReadDraft(string DraftId)
        {
            if (DraftId == null) { throw new System.ArgumentNullException("DraftId cannot be null"); }
            NSXTPolicyDraftType returnValue = default(NSXTPolicyDraftType);
            StringBuilder ReadDraftServiceURL = new StringBuilder("/infra/drafts/{draft-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ReadDraftServiceURL.Replace("{draft-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DraftId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadDraftServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTPolicyDraftType>(response.Content, defaultSerializationSettings);
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
        public NSXTInfraType GetAggregatedConfigurationToBePublishedForDraft(string DraftId)
        {
            if (DraftId == null) { throw new System.ArgumentNullException("DraftId cannot be null"); }
            NSXTInfraType returnValue = default(NSXTInfraType);
            StringBuilder GetAggregatedConfigurationToBePublishedForDraftServiceURL = new StringBuilder("/infra/drafts/{draft-id}/aggregated");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetAggregatedConfigurationToBePublishedForDraftServiceURL.Replace("{draft-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DraftId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetAggregatedConfigurationToBePublishedForDraftServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTInfraType>(response.Content, defaultSerializationSettings);
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
        public NSXTPolicyDraftListResultType ListDrafts(bool? AutoDrafts = null, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTPolicyDraftListResultType returnValue = default(NSXTPolicyDraftListResultType);
            StringBuilder ListDraftsServiceURL = new StringBuilder("/infra/drafts");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (AutoDrafts != null) { request.AddQueryParameter("auto_drafts", AutoDrafts.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListDraftsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTPolicyDraftListResultType>(response.Content, defaultSerializationSettings);
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
        public void GlobalPublishDraftPublish(string DraftId, NSXTInfraType Infra)
        {
            if (DraftId == null) { throw new System.ArgumentNullException("DraftId cannot be null"); }
            if (Infra == null) { throw new System.ArgumentNullException("Infra cannot be null"); }
            
            StringBuilder PublishDraftPublishServiceURL = new StringBuilder("/global-infra/drafts/{draft-id}?action=publish");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            PublishDraftPublishServiceURL.Replace("{draft-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DraftId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(Infra, defaultSerializationSettings));
            request.Resource = PublishDraftPublishServiceURL.ToString();
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
        public NSXTPolicyDraftPaginatedAggregatedConfigurationResultType GlobalGetPolicyDraftPaginatedAggregatedConfigurationResult(string DraftId, string? RequestId = null, string? RootPath = null)
        {
            if (DraftId == null) { throw new System.ArgumentNullException("DraftId cannot be null"); }
            NSXTPolicyDraftPaginatedAggregatedConfigurationResultType returnValue = default(NSXTPolicyDraftPaginatedAggregatedConfigurationResultType);
            StringBuilder GetPolicyDraftPaginatedAggregatedConfigurationResultServiceURL = new StringBuilder("/global-infra/drafts/{draft-id}/aggregated_with_pagination");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetPolicyDraftPaginatedAggregatedConfigurationResultServiceURL.Replace("{draft-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DraftId, System.Globalization.CultureInfo.InvariantCulture)));
            if (RequestId != null) { request.AddQueryParameter("request_id", RequestId.ToString()); }
            if (RootPath != null) { request.AddQueryParameter("root_path", RootPath.ToString()); }
            request.Resource = GetPolicyDraftPaginatedAggregatedConfigurationResultServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTPolicyDraftPaginatedAggregatedConfigurationResultType>(response.Content, defaultSerializationSettings);
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
        public void PublishDraftPublish(string DraftId, NSXTInfraType Infra)
        {
            if (DraftId == null) { throw new System.ArgumentNullException("DraftId cannot be null"); }
            if (Infra == null) { throw new System.ArgumentNullException("Infra cannot be null"); }
            
            StringBuilder PublishDraftPublishServiceURL = new StringBuilder("/infra/drafts/{draft-id}?action=publish");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            PublishDraftPublishServiceURL.Replace("{draft-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DraftId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(Infra, defaultSerializationSettings));
            request.Resource = PublishDraftPublishServiceURL.ToString();
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
        public NSXTPolicyDraftType GlobalPutDraft(string DraftId, NSXTPolicyDraftType PolicyDraft)
        {
            if (DraftId == null) { throw new System.ArgumentNullException("DraftId cannot be null"); }
            if (PolicyDraft == null) { throw new System.ArgumentNullException("PolicyDraft cannot be null"); }
            NSXTPolicyDraftType returnValue = default(NSXTPolicyDraftType);
            StringBuilder PutDraftServiceURL = new StringBuilder("/global-infra/drafts/{draft-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            PutDraftServiceURL.Replace("{draft-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DraftId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyDraft, defaultSerializationSettings));
            request.Resource = PutDraftServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTPolicyDraftType>(response.Content, defaultSerializationSettings);
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
        public void GlobalDeleteDraft(string DraftId)
        {
            if (DraftId == null) { throw new System.ArgumentNullException("DraftId cannot be null"); }
            
            StringBuilder DeleteDraftServiceURL = new StringBuilder("/global-infra/drafts/{draft-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeleteDraftServiceURL.Replace("{draft-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DraftId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteDraftServiceURL.ToString();
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
        public void GlobalPatchDraft(string DraftId, NSXTPolicyDraftType PolicyDraft)
        {
            if (DraftId == null) { throw new System.ArgumentNullException("DraftId cannot be null"); }
            if (PolicyDraft == null) { throw new System.ArgumentNullException("PolicyDraft cannot be null"); }
            
            StringBuilder PatchDraftServiceURL = new StringBuilder("/global-infra/drafts/{draft-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            PatchDraftServiceURL.Replace("{draft-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DraftId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(PolicyDraft, defaultSerializationSettings));
            request.Resource = PatchDraftServiceURL.ToString();
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
        public NSXTPolicyDraftType GlobalReadDraft(string DraftId)
        {
            if (DraftId == null) { throw new System.ArgumentNullException("DraftId cannot be null"); }
            NSXTPolicyDraftType returnValue = default(NSXTPolicyDraftType);
            StringBuilder ReadDraftServiceURL = new StringBuilder("/global-infra/drafts/{draft-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ReadDraftServiceURL.Replace("{draft-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DraftId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadDraftServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTPolicyDraftType>(response.Content, defaultSerializationSettings);
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
        public NSXTInfraType GlobalGetPreviewOfConfigurationAfterPublishOfDraft(string DraftId)
        {
            if (DraftId == null) { throw new System.ArgumentNullException("DraftId cannot be null"); }
            NSXTInfraType returnValue = default(NSXTInfraType);
            StringBuilder GetPreviewOfConfigurationAfterPublishOfDraftServiceURL = new StringBuilder("/global-infra/drafts/{draft-id}/complete");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetPreviewOfConfigurationAfterPublishOfDraftServiceURL.Replace("{draft-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DraftId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPreviewOfConfigurationAfterPublishOfDraftServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTInfraType>(response.Content, defaultSerializationSettings);
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
        public NSXTPolicyDraftListResultType GlobalListDrafts(bool? AutoDrafts = null, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTPolicyDraftListResultType returnValue = default(NSXTPolicyDraftListResultType);
            StringBuilder ListDraftsServiceURL = new StringBuilder("/global-infra/drafts");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (AutoDrafts != null) { request.AddQueryParameter("auto_drafts", AutoDrafts.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListDraftsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTPolicyDraftListResultType>(response.Content, defaultSerializationSettings);
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
        public NSXTInfraType GlobalGetAggregatedConfigurationToBePublishedForDraft(string DraftId)
        {
            if (DraftId == null) { throw new System.ArgumentNullException("DraftId cannot be null"); }
            NSXTInfraType returnValue = default(NSXTInfraType);
            StringBuilder GetAggregatedConfigurationToBePublishedForDraftServiceURL = new StringBuilder("/global-infra/drafts/{draft-id}/aggregated");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetAggregatedConfigurationToBePublishedForDraftServiceURL.Replace("{draft-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DraftId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetAggregatedConfigurationToBePublishedForDraftServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTInfraType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
    }
}
