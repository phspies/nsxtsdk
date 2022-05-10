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
    /// Network error related to container objects.
    /// </summary>
    [NSXTProperty(Description: @"Network error related to container objects.")]
    public class NSXTNetworkErrorType 
    {
        /// <summary>
        /// Detailed message of network related error.
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public string? ErrorMessage { get; set; }
        /// <summary>
        /// Error code of network related error.
        /// </summary>
        [JsonProperty(PropertyName = "error_code")]
        public string? ErrorCode { get; set; }
        /// <summary>
        /// Additional error information in json format.
        /// </summary>
        [JsonProperty(PropertyName = "spec")]
        public string? Spec { get; set; }
    }
}
