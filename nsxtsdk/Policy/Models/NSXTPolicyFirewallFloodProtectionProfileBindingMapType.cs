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
    public class NSXTPolicyFirewallFloodProtectionProfileBindingMapType : NSXTProfileBindingMapType
    {
        /// <summary>
        /// Sequence number is used to resolve conflicts when two profiles get
        /// applied to a single port. Lower value gets higher precedence. Two
        /// binding maps having the same profile path should have the same sequence
        /// number.
        /// </summary>
        [JsonProperty(PropertyName = "sequence_number", Required = Required.AllowNull)]
        public long SequenceNumber { get; set; }
    }
}
