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
    /// This indicate component health condition and the reason why not healthy.
    /// </summary>
    [NSXTProperty(Description: @"This indicate component health condition and the reason why not healthy.")]
    public class NSXTComponentConditionItemType 
    {
        /// <summary>
        /// Time unit is millisecond.
        /// </summary>
        [JsonProperty(PropertyName = "last_heartbeat_time")]
        public long? LastHeartbeatTime { get; set; }
        /// <summary>
        /// Indicate healthy or unhealthy.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTComponentConditionItemStatusEnumType? Status { get; set; }
        /// <summary>
        /// Indicate why not healthy.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// Indicate which component condition it is.
        /// </summary>
        [JsonProperty(PropertyName = "condition_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTComponentConditionItemConditionTypeEnumType? ConditionType { get; set; }
        /// <summary>
        /// Additional condition information.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string? Message { get; set; }
    }
}
