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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTGroupDiscoveryProfileBindingMapType : NSXTProfileBindingMapType
    {
        /// <summary>
        /// Sequence number used to resolve conflicts betweeen two profiles applied on
        /// the same group. Lower sequence number takes higher precedence. Two binding
        /// maps applied to the same profile must have the same sequence number.
        /// User defined sequence numbers range from 1 through 100,000.
        /// System defined sequence numbers range from 100,001 through 200,000.
        /// </summary>
        [JsonProperty(PropertyName = "sequence_number")]
        public long? SequenceNumber { get; set; }
    }
}
