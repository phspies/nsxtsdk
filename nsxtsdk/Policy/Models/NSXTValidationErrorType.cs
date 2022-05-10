using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Error while applying transport node profile on discovered node
    /// </summary>
    [NSXTProperty(Description: @"Error while applying transport node profile on discovered node")]
    public class NSXTValidationErrorType 
    {
        /// <summary>
        /// Discovered Node Id
        /// </summary>
        [JsonProperty(PropertyName = "discovered_node_id")]
        public string? DiscoveredNodeId { get; set; }
        /// <summary>
        /// Validation error message
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public string? ErrorMessage { get; set; }
    }
}
