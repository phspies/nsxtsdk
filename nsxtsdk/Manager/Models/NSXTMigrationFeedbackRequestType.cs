using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Detailed feedback requests from the migration tool where user input is required.
    /// </summary>
    [NSXTProperty(Description: @"Detailed feedback requests from the migration tool where user input is required.")]
    public class NSXTMigrationFeedbackRequestType 
    {
        /// <summary>
        /// Indicates if a valid response already exist for this feedback request.
        /// </summary>
        [JsonProperty(PropertyName = "resolved")]
        public bool? Resolved { get; set; }
        /// <summary>
        /// Name of this object in the source NSX endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "v_object_name")]
        public string? VObjectName { get; set; }
        /// <summary>
        /// Identify a feedback request type across objects. This can be used to group together objects with similar feedback
        /// request and resolve them in one go.
        /// </summary>
        [JsonProperty(PropertyName = "hash")]
        public string? Hash { get; set; }
        /// <summary>
        /// List of acceptable actions for this feedback request.
        /// </summary>
        [JsonProperty(PropertyName = "accepted_actions")]
        public IList<string> AcceptedActions { get; set; }
        /// <summary>
        /// Functional area that this query falls into.
        /// </summary>
        [JsonProperty(PropertyName = "vertical")]
        public string? Vertical { get; set; }
        /// <summary>
        /// Identifier for this object in the source NSX endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "v_object_id")]
        public string? VObjectId { get; set; }
        /// <summary>
        /// The suggested value to resolve this feedback request.
        /// </summary>
        [JsonProperty(PropertyName = "suggested_value")]
        public string? SuggestedValue { get; set; }
        /// <summary>
        /// Detailed feedback request with options.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string? Message { get; set; }
        /// <summary>
        /// Indicates if multiple values can be selected as response from the list of acceptable value.
        /// </summary>
        [JsonProperty(PropertyName = "multi_value")]
        public bool? MultiValue { get; set; }
        /// <summary>
        /// Data type of the items listed in acceptable values list.
        /// </summary>
        [JsonProperty(PropertyName = "accepted_value_type")]
        public string? AcceptedValueType { get; set; }
        /// <summary>
        /// Id of the site in NSX-T Federation
        /// </summary>
        [JsonProperty(PropertyName = "federation_site_id")]
        public string? FederationSiteId { get; set; }
        /// <summary>
        /// Identifier of the object for which feedback is requested.
        /// </summary>
        [JsonProperty(PropertyName = "object_id")]
        public string? ObjectId { get; set; }
        /// <summary>
        /// List of acceptable values for this feedback request.
        /// </summary>
        [JsonProperty(PropertyName = "accepted_values")]
        public IList<string> AcceptedValues { get; set; }
        /// <summary>
        /// Identifier of the feedback request.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// The suggested action to resolve this feedback request.
        /// </summary>
        [JsonProperty(PropertyName = "suggested_action")]
        public string? SuggestedAction { get; set; }
        /// <summary>
        /// Functional sub-area that this query falls into.
        /// </summary>
        [JsonProperty(PropertyName = "sub_vertical")]
        public string? SubVertical { get; set; }
        /// <summary>
        /// If the feedback request was resolved earlier, provides details about the previous resolution.
        /// </summary>
        [JsonProperty(PropertyName = "resolution")]
        public string? Resolution { get; set; }
        /// <summary>
        /// Indicates if previous response was invalid. Please provide a valid response.
        /// </summary>
        [JsonProperty(PropertyName = "rejected")]
        public bool? Rejected { get; set; }
    }
}
