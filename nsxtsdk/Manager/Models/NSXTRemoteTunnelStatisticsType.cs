using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTRemoteTunnelStatisticsType 
    {
        /// <summary>
        /// Ip address of remote tunnel destination.
        /// </summary>
        [JsonProperty(PropertyName = "tunnel_destination_address")]
        public string? TunnelDestinationAddress { get; set; }
        /// <summary>
        /// Ip address of remote tunnel source.
        /// </summary>
        [JsonProperty(PropertyName = "tunnel_source_address")]
        public string? TunnelSourceAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "rx")]
        public NSXTInterSitePortCountersType Rx { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "tx")]
        public NSXTInterSitePortCountersType Tx { get; set; }
    }
}
