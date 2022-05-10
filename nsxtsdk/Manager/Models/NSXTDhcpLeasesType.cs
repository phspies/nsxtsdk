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
    public class NSXTDhcpLeasesType : NSXTListResultType
    {
        /// <summary>
        /// timestamp of the lease info
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public long? Timestamp { get; set; }
        /// <summary>
        /// The lease info list of the server
        /// </summary>
        [JsonProperty(PropertyName = "leases")]
        public IList<NSXTDhcpLeasePerIPType> Leases { get; set; }
        /// <summary>
        /// dhcp server uuid
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_server_id")]
        public string? DhcpServerId { get; set; }
    }
}
