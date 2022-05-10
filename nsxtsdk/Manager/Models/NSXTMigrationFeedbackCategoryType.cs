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
    /// Categorization of feedback requests from the migration tool where user input is required.
    /// </summary>
    [NSXTProperty(Description: @"Categorization of feedback requests from the migration tool where user input is required.")]
    public class NSXTMigrationFeedbackCategoryType 
    {
        /// <summary>
        /// Functional area that this query falls into.
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string? Category { get; set; }
        /// <summary>
        /// Total number of feedback requests for this functional area.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int? Count { get; set; }
        /// <summary>
        /// Total number of resolved feedback requests for this functional area.
        /// </summary>
        [JsonProperty(PropertyName = "resolved")]
        public int? Resolved { get; set; }
        /// <summary>
        /// List of acceptable values for this feedback request.
        /// </summary>
        [JsonProperty(PropertyName = "accepted_values")]
        public IList<string> AcceptedValues { get; set; }
    }
}
