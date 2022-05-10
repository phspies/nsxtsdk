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
    /// Errors encountered while fetching entities in the forwarding path
    /// </summary>
    [NSXTProperty(Description: @"Errors encountered while fetching entities in the forwarding path")]
    public class NSXTPortConnectionErrorType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "error_summary")]
        public string? ErrorSummary { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "error_details")]
        public object? ErrorDetails { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "entity_type")]
        public string? EntityType { get; set; }
    }
}
