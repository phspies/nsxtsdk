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
        [NSXTProperty(IsRequired: false, Description: @"BFD peers will be created from all these source addresses to this neighbour.")]
        public IList<string> SourceAddresses { get; set; }
        /// <summary>
        /// If not specified then BFD peer will inherit configuration from the BFD global config.
        /// </summary>
        [JsonProperty(PropertyName = "bfd_config")]
        [NSXTProperty(IsRequired: false, Description: @"If not specified then BFD peer will inherit configuration from the BFD global config.")]
        public NSXTBfdConfigParametersType BfdConfig { get; set; }
        /// <summary>
        /// Indicate BFD peer is enabled or disabled. Default is true.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        [NSXTProperty(IsRequired: false, Description: @"Indicate BFD peer is enabled or disabled. Default is true.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// IP address of BFD peer. This should be same as next hop IP address.
        /// </summary>
        [JsonProperty(PropertyName = "peer_ip_address", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"IP address of BFD peer. This should be same as next hop IP address.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string PeerIpAddress { get; set; }
    }
}
