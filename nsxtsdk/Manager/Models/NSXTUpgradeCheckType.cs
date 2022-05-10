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
    /// Check to identify potential pre/post-upgrade issues
    /// </summary>
    [NSXTProperty(Description: @"Check to identify potential pre/post-upgrade issues")]
    public class NSXTUpgradeCheckType 
    {
        /// <summary>
        /// Status of pre/post-upgrade check
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTUpgradeCheckStatusEnumType? Status { get; set; }
        /// <summary>
        /// List of failures
        /// </summary>
        [JsonProperty(PropertyName = "failures")]
        public IList<NSXTUpgradeCheckFailureMessageType> Failures { get; set; }
        /// <summary>
        /// Name of the pre/post-upgrade check
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// List of failure messages. This field is deprecated now. Please use failures instead.
        /// </summary>
        [JsonProperty(PropertyName = "failure_messages")]
        public IList<string> FailureMessages { get; set; }
        /// <summary>
        /// Component type
        /// </summary>
        [JsonProperty(PropertyName = "component_type", Required = Required.AllowNull)]
        public string ComponentType { get; set; }
    }
}
