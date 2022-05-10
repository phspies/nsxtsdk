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
    /// Detailed information about a related API error
    /// </summary>
    [NSXTProperty(Description: @"Detailed information about a related API error")]
    public class NSXTRelatedApiErrorType 
    {
        /// <summary>
        /// The module name where the error occurred
        /// </summary>
        [JsonProperty(PropertyName = "module_name")]
        public string? ModuleName { get; set; }
        /// <summary>
        /// A description of the error
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public string? ErrorMessage { get; set; }
        /// <summary>
        /// A numeric error code
        /// </summary>
        [JsonProperty(PropertyName = "error_code")]
        public long? ErrorCode { get; set; }
        /// <summary>
        /// Further details about the error
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public string? Details { get; set; }
        /// <summary>
        /// Additional data about the error
        /// </summary>
        [JsonProperty(PropertyName = "error_data")]
        public object? ErrorData { get; set; }
    }
}
