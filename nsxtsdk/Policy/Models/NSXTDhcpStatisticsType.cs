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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTDhcpStatisticsType 
    {
        /// <summary>
        /// The total number of DHCP errors
        /// </summary>
        [JsonProperty(PropertyName = "errors", Required = Required.AllowNull)]
        public long Errors { get; set; }
        /// <summary>
        /// The total number of DHCP RELEASE packets
        /// </summary>
        [JsonProperty(PropertyName = "releases", Required = Required.AllowNull)]
        public long Releases { get; set; }
        /// <summary>
        /// The total number of DHCP INFORM packets
        /// </summary>
        [JsonProperty(PropertyName = "informs", Required = Required.AllowNull)]
        public long Informs { get; set; }
        /// <summary>
        /// The total number of DHCP DECLINE packets
        /// </summary>
        [JsonProperty(PropertyName = "declines", Required = Required.AllowNull)]
        public long Declines { get; set; }
        /// <summary>
        /// dhcp server uuid
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_server_id", Required = Required.AllowNull)]
        public string DhcpServerId { get; set; }
        /// <summary>
        /// The total number of DHCP NACK packets
        /// </summary>
        [JsonProperty(PropertyName = "nacks", Required = Required.AllowNull)]
        public long Nacks { get; set; }
        /// <summary>
        /// The total number of DHCP OFFER packets
        /// </summary>
        [JsonProperty(PropertyName = "offers", Required = Required.AllowNull)]
        public long Offers { get; set; }
        /// <summary>
        /// The total number of DHCP DISCOVER packets
        /// </summary>
        [JsonProperty(PropertyName = "discovers", Required = Required.AllowNull)]
        public long Discovers { get; set; }
        /// <summary>
        /// The total number of DHCP ACK packets
        /// </summary>
        [JsonProperty(PropertyName = "acks", Required = Required.AllowNull)]
        public long Acks { get; set; }
        /// <summary>
        /// timestamp of the statistics
        /// </summary>
        [JsonProperty(PropertyName = "timestamp", Required = Required.AllowNull)]
        public long Timestamp { get; set; }
        /// <summary>
        /// The total number of DHCP REQUEST packets
        /// </summary>
        [JsonProperty(PropertyName = "requests", Required = Required.AllowNull)]
        public long Requests { get; set; }
        /// <summary>
        /// The DHCP ip pool usage statistics
        /// </summary>
        [JsonProperty(PropertyName = "ip_pool_stats")]
        public IList<NSXTDhcpIpPoolUsageType> IpPoolStats { get; set; }
    }
}
