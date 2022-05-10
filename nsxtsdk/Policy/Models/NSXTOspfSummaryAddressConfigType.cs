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
    /// OSPF summary address configuration to summarize external routes
    /// </summary>
    [NSXTProperty(Description: @"OSPF summary address configuration to summarize external routes")]
    public class NSXTOspfSummaryAddressConfigType 
    {
        /// <summary>
        /// OSPF Summary address in CIDR format
        /// </summary>
        [JsonProperty(PropertyName = "prefix", Required = Required.AllowNull)]
        public string Prefix { get; set; }
        /// <summary>
        /// Used to filter the advertisement of external routes into the OSPF domain.
        /// Setting this field to "TRUE" will enable the summarization of external routes that are covered by
        /// ip_prefix configuration.
        /// Setting this field to "FALSE" will filter the advertisement of external routes that are covered by
        /// ip_prefix configuration.
        /// </summary>
        [JsonProperty(PropertyName = "advertise")]
        public bool? Advertise { get; set; }
    }
}
