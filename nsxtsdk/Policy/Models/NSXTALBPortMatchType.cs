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
    /// Advanced load balancer PortMatch object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer PortMatch object")]
    public class NSXTALBPortMatchType 
    {
        /// <summary>
        /// Listening TCP port(s).
        /// Allowed values are 1-65535.
        /// Minimum of 1 items required.
        /// </summary>
        [JsonProperty(PropertyName = "ports", Required = Required.AllowNull)]
        public long Ports { get; set; }
        /// <summary>
        /// Criterion to use for port matching the HTTP request.
        /// Enum options - IS_IN, IS_NOT_IN.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbportMatchMatchCriteriaEnumType MatchCriteria { get; set; }
    }
}
