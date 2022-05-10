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
    /// Error class for all the Service Insertion related errors.
    /// </summary>
    [NSXTProperty(Description: @"Error class for all the Service Insertion related errors.")]
    public class NSXTSIErrorClassType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "error_id")]
        public long? ErrorId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public string? ErrorMessage { get; set; }
    }
}
