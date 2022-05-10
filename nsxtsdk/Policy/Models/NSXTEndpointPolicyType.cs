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
    public class NSXTEndpointPolicyType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Endpoint Rules that are a part of this EndpointPolicy
        /// </summary>
        [JsonProperty(PropertyName = "endpoint_rules")]
        public IList<NSXTEndpointRuleType> EndpointRules { get; set; }
        /// <summary>
        /// This field is used to resolve conflicts between maps
        /// across domains.
        /// </summary>
        [JsonProperty(PropertyName = "sequence_number")]
        public int? SequenceNumber { get; set; }
    }
}
