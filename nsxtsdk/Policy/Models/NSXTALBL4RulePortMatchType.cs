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
    /// Advanced load balancer L4RulePortMatch object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer L4RulePortMatch object")]
    public class NSXTALBL4RulePortMatchType 
    {
        /// <summary>
        /// Range of TCP/UDP port numbers of the Virtual Service.
        /// </summary>
        [JsonProperty(PropertyName = "port_ranges")]
        public IList<NSXTALBPortRangeType> PortRanges { get; set; }
        /// <summary>
        /// Virtual Service's listening port(s).
        /// Allowed values are 1-65535.
        /// </summary>
        [JsonProperty(PropertyName = "ports")]
        public long? Ports { get; set; }
        /// <summary>
        /// Criterion to use for Virtual Service port matching.
        /// Enum options - IS_IN, IS_NOT_IN.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTALBL4RulePortMatchMatchCriteriaEnumType MatchCriteria { get; set; }
    }
}
