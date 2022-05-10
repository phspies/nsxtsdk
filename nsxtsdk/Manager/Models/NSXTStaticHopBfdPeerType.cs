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
    public class NSXTStaticHopBfdPeerType : NSXTManagedResourceType
    {
        /// <summary>
        /// BFD peers will be created from all these source addresses to this neighbour.
        /// </summary>
        [JsonProperty(PropertyName = "source_addresses")]
        public IList<string> SourceAddresses { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "bfd_config")]
        public NSXTBfdConfigParametersType BfdConfig { get; set; }
        /// <summary>
        /// Indicate BFD peer is enabled or disabled. Default is true.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// IP address of BFD peer. This should be same as next hop IP address.
        /// </summary>
        [JsonProperty(PropertyName = "peer_ip_address", Required = Required.AllowNull)]
        public string PeerIpAddress { get; set; }
    }
}
