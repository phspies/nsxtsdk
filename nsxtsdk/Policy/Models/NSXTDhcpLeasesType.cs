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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTDhcpLeasesType : NSXTListResultType
    {
        public NSXTDhcpLeasesType()
        {
        }
        /// <summary>
        /// timestamp of the lease info
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        [NSXTProperty(IsRequired: false, Description: @"timestamp of the lease info")]
        public long? Timestamp { get; set; }
        /// <summary>
        /// The lease info list of the server
        /// </summary>
        [JsonProperty(PropertyName = "leases")]
        [NSXTProperty(IsRequired: false, Description: @"The lease info list of the server")]
        public IList<NSXTDhcpLeasePerIPType> Leases { get; set; }
        /// <summary>
        /// dhcp server uuid
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_server_id")]
        [NSXTProperty(IsRequired: false, Description: @"dhcp server uuid")]
        public string? DhcpServerId { get; set; }
    }
}
