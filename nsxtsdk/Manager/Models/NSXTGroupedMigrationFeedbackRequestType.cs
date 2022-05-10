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
    public class NSXTGroupedMigrationFeedbackRequestType 
    {
        /// <summary>
        /// Indicates if a valid response already exist for all feedback requests in this group.
        /// </summary>
        [JsonProperty(PropertyName = "resolved")]
        public bool? Resolved { get; set; }
        /// <summary>
        /// List of acceptable actions for this feedback request.
        /// </summary>
        [JsonProperty(PropertyName = "accepted_actions")]
        public IList<string> AcceptedActions { get; set; }
        /// <summary>
        /// Identify a feedback request type across objects. This can be used to group together objects with similar feedback
        /// request and resolve them in one go.
        /// </summary>
        [JsonProperty(PropertyName = "hash")]
        public string? Hash { get; set; }
        /// <summary>
        /// Functional area that this query falls into.
        /// </summary>
        [JsonProperty(PropertyName = "vertical")]
        public string? Vertical { get; set; }
        /// <summary>
        /// The suggested value to resolve this feedback request.
        /// </summary>
        [JsonProperty(PropertyName = "suggested_value")]
        public string? SuggestedValue { get; set; }
        /// <summary>
        /// Indicates if multiple values can be selected as response from the list of acceptable value.
        /// </summary>
        [JsonProperty(PropertyName = "multi_value")]
        public bool? MultiValue { get; set; }
        /// <summary>
        /// Functional sub-area that this query falls into.
        /// </summary>
        [JsonProperty(PropertyName = "sub_vertical")]
        public string? SubVertical { get; set; }
        /// <summary>
        /// Collection of feedback requests of a given type
        /// </summary>
        [JsonProperty(PropertyName = "objects", Required = Required.AllowNull)]
        public IList<NSXTSummaryMigrationFeedbackRequestType> Objects { get; set; }
        /// <summary>
        /// List of acceptable values for this feedback request.
        /// </summary>
        [JsonProperty(PropertyName = "accepted_values")]
        public IList<string> AcceptedValues { get; set; }
        /// <summary>
        /// Detailed feedback request with options.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string? Message { get; set; }
        /// <summary>
        /// Data type of the items listed in acceptable values list.
        /// </summary>
        [JsonProperty(PropertyName = "accepted_value_type")]
        public string? AcceptedValueType { get; set; }
        /// <summary>
        /// The suggested action to resolve this feedback request.
        /// </summary>
        [JsonProperty(PropertyName = "suggested_action")]
        public string? SuggestedAction { get; set; }
    }
}
