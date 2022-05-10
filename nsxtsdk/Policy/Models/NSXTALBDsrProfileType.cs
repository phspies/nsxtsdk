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
    /// Advanced load balancer DsrProfile object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DsrProfile object")]
    public class NSXTALBDsrProfileType 
    {
        /// <summary>
        /// Encapsulation type to use when DSR is L3.
        /// Enum options - ENCAP_IPINIP.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as ENCAP_IPINIP.
        /// </summary>
        [JsonProperty(PropertyName = "dsr_encap_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbdsrProfileDsrEncapTypeEnumType? DsrEncapType { get; set; }
        /// <summary>
        /// DSR type L2/L3.
        /// Enum options - DSR_TYPE_L2, DSR_TYPE_L3.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as DSR_TYPE_L3.
        /// </summary>
        [JsonProperty(PropertyName = "dsr_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbdsrProfileDsrTypeEnumType? DsrType { get; set; }
    }
}
