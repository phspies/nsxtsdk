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
    public class NSXTPolicyFirewallCPUMemThresholdsProfileBindingMapType : NSXTProfileBindingMapType
    {
        /// <summary>
        /// Sequence number is used to resolve conflicts when two profiles get
        /// applied to a single node. Lower value gets higher precedence. Two
        /// binding maps having the same profile path should have the same sequence
        /// number.
        /// </summary>
        [JsonProperty(PropertyName = "sequence_number", Required = Required.AllowNull)]
        public long SequenceNumber { get; set; }
        /// <summary>
        /// References of transport nodes on which the profile intended to
        /// be applied.
        /// </summary>
        [JsonProperty(PropertyName = "transport_nodes")]
        public IList<NSXTPolicyResourceReferenceType> TransportNodes { get; set; }
    }
}
