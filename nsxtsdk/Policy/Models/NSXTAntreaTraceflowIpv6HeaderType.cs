// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Ipv6 header stuffs for Antrea traceflow.
    /// </summary>
    [NSXTProperty(Description: @"Ipv6 header stuffs for Antrea traceflow.")]
    public class NSXTAntreaTraceflowIpv6HeaderType 
    {
        public NSXTAntreaTraceflowIpv6HeaderType()
        {
        }
        /// <summary>
        /// Source ip address in Ipv6Header.
        /// </summary>
        [JsonProperty(PropertyName = "srcIp")]
        [NSXTProperty(IsRequired: false, Description: @"Source ip address in Ipv6Header.")]
        public string? SrcIp { get; set; }
        /// <summary>
        /// Destination ip address in Ipv6Header.
        /// </summary>
        [JsonProperty(PropertyName = "dstIp")]
        [NSXTProperty(IsRequired: false, Description: @"Destination ip address in Ipv6Header.")]
        public string? DstIp { get; set; }
        /// <summary>
        /// Next header setting in Ipv6Header.
        /// </summary>
        [JsonProperty(PropertyName = "nextHeader")]
        [NSXTProperty(IsRequired: false, Description: @"Next header setting in Ipv6Header.")]
        public long? NextHeader { get; set; }
        /// <summary>
        /// Hop limit setting in Ipv6Header.
        /// </summary>
        [JsonProperty(PropertyName = "hopLimit")]
        [NSXTProperty(IsRequired: false, Description: @"Hop limit setting in Ipv6Header.")]
        public long? HopLimit { get; set; }
    }
}