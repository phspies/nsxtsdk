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
    /// Advanced load balancer ProtocolMatch object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer ProtocolMatch object")]
    public class NSXTALBProtocolMatchType 
    {
        /// <summary>
        /// HTTP or HTTPS protocol.
        /// Enum options - HTTP, HTTPS.
        /// </summary>
        [JsonProperty(PropertyName = "protocols", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbprotocolMatchProtocolsEnumType Protocols { get; set; }
        /// <summary>
        /// Criterion to use for protocol matching the HTTP request.
        /// Enum options - IS_IN, IS_NOT_IN.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbprotocolMatchMatchCriteriaEnumType MatchCriteria { get; set; }
    }
}
