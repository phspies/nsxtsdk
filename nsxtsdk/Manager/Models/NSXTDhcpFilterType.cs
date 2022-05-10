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
    /// DHCP filtering configuration
    /// </summary>
    [NSXTProperty(Description: @"DHCP filtering configuration")]
    public class NSXTDhcpFilterType 
    {
        /// <summary>
        /// Indicates whether DHCP client blocking is enabled
        /// </summary>
        [JsonProperty(PropertyName = "client_block_enabled", Required = Required.AllowNull)]
        public bool ClientBlockEnabled { get; set; }
        /// <summary>
        /// Indiactes whether DHCP v6 client blocking is enabled
        /// </summary>
        [JsonProperty(PropertyName = "v6_client_block_enabled")]
        public bool? V6ClientBlockEnabled { get; set; }
        /// <summary>
        /// Indicates whether DHCP server blocking is enabled
        /// </summary>
        [JsonProperty(PropertyName = "server_block_enabled", Required = Required.AllowNull)]
        public bool ServerBlockEnabled { get; set; }
        /// <summary>
        /// Indiactes whether DHCP V6 server blocking is enabled
        /// </summary>
        [JsonProperty(PropertyName = "v6_server_block_enabled")]
        public bool? V6ServerBlockEnabled { get; set; }
    }
}
