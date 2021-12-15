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
    public class NSXTDhcpStatisticsType 
    {
        /// <summary>
        /// The total number of DHCP errors
        /// </summary>
        [JsonProperty(PropertyName = "errors", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The total number of DHCP errors")]
        [System.ComponentModel.DataAnnotations.Required]
        public long Errors { get; set; }
        /// <summary>
        /// The total number of DHCP RELEASE packets
        /// </summary>
        [JsonProperty(PropertyName = "releases", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The total number of DHCP RELEASE packets")]
        [System.ComponentModel.DataAnnotations.Required]
        public long Releases { get; set; }
        /// <summary>
        /// The total number of DHCP INFORM packets
        /// </summary>
        [JsonProperty(PropertyName = "informs", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The total number of DHCP INFORM packets")]
        [System.ComponentModel.DataAnnotations.Required]
        public long Informs { get; set; }
        /// <summary>
        /// The total number of DHCP DECLINE packets
        /// </summary>
        [JsonProperty(PropertyName = "declines", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The total number of DHCP DECLINE packets")]
        [System.ComponentModel.DataAnnotations.Required]
        public long Declines { get; set; }
        /// <summary>
        /// dhcp server uuid
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_server_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"dhcp server uuid")]
        [System.ComponentModel.DataAnnotations.Required]
        public string DhcpServerId { get; set; }
        /// <summary>
        /// The total number of DHCP NACK packets
        /// </summary>
        [JsonProperty(PropertyName = "nacks", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The total number of DHCP NACK packets")]
        [System.ComponentModel.DataAnnotations.Required]
        public long Nacks { get; set; }
        /// <summary>
        /// The total number of DHCP OFFER packets
        /// </summary>
        [JsonProperty(PropertyName = "offers", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The total number of DHCP OFFER packets")]
        [System.ComponentModel.DataAnnotations.Required]
        public long Offers { get; set; }
        /// <summary>
        /// The total number of DHCP DISCOVER packets
        /// </summary>
        [JsonProperty(PropertyName = "discovers", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The total number of DHCP DISCOVER packets")]
        [System.ComponentModel.DataAnnotations.Required]
        public long Discovers { get; set; }
        /// <summary>
        /// The total number of DHCP ACK packets
        /// </summary>
        [JsonProperty(PropertyName = "acks", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The total number of DHCP ACK packets")]
        [System.ComponentModel.DataAnnotations.Required]
        public long Acks { get; set; }
        /// <summary>
        /// timestamp of the statistics
        /// </summary>
        [JsonProperty(PropertyName = "timestamp", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"timestamp of the statistics")]
        [System.ComponentModel.DataAnnotations.Required]
        public long Timestamp { get; set; }
        /// <summary>
        /// The total number of DHCP REQUEST packets
        /// </summary>
        [JsonProperty(PropertyName = "requests", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The total number of DHCP REQUEST packets")]
        [System.ComponentModel.DataAnnotations.Required]
        public long Requests { get; set; }
        /// <summary>
        /// The DHCP ip pool usage statistics
        /// </summary>
        [JsonProperty(PropertyName = "ip_pool_stats")]
        [NSXTProperty(IsRequired: false, Description: @"The DHCP ip pool usage statistics")]
        public IList<NSXTDhcpIpPoolUsageType> IpPoolStats { get; set; }
    }
}
