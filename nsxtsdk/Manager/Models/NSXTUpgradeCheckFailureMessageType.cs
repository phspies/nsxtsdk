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
    /// Pre/post-upgrade check failure message
    /// </summary>
    [NSXTProperty(Description: @"Pre/post-upgrade check failure message")]
    public class NSXTUpgradeCheckFailureMessageType 
    {
        /// <summary>
        /// Error/warning message
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string? Message { get; set; }
        /// <summary>
        /// Error code for the error/warning
        /// </summary>
        [JsonProperty(PropertyName = "error_code")]
        public long? ErrorCode { get; set; }
    }
}
