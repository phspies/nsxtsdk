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
    /// Error information
    /// </summary>
    [NSXTProperty(Description: @"Error information")]
    public class NSXTErrorInfoType 
    {
        /// <summary>
        /// Timestamp when the error occurred
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public long? Timestamp { get; set; }
        /// <summary>
        /// Error message
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public string? ErrorMessage { get; set; }
        /// <summary>
        /// Error code of the error.
        /// </summary>
        [JsonProperty(PropertyName = "error_code")]
        public int? ErrorCode { get; set; }
    }
}
