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
    /// Minimal description of feedback requests.
    /// </summary>
    [NSXTProperty(Description: @"Minimal description of feedback requests.")]
    public class NSXTSummaryMigrationFeedbackRequestType 
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
        /// Identifier of the object for which feedback is requested.
        /// </summary>
        [JsonProperty(PropertyName = "object_id")]
        public string? ObjectId { get; set; }
        /// <summary>
        /// Identifier for this object in the source NSX endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "v_object_id")]
        public string? VObjectId { get; set; }
        /// <summary>
        /// Id of the site in NSX-T Federation
        /// </summary>
        [JsonProperty(PropertyName = "federation_site_id")]
        public string? FederationSiteId { get; set; }
        /// <summary>
        /// If the feedback request was resolved earlier, provides details about the previous resolution.
        /// </summary>
        [JsonProperty(PropertyName = "resolution")]
        public string? Resolution { get; set; }
        /// <summary>
        /// Identifier of the feedback request.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// Indicates if previous response was invalid. Please provide a valid response.
        /// </summary>
        [JsonProperty(PropertyName = "rejected")]
        public bool? Rejected { get; set; }
        /// <summary>
        /// Details about this specific feedback request.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public string? Details { get; set; }
    }
}
