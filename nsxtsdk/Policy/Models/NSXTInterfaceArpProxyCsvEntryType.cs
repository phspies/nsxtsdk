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
    public class NSXTInterfaceArpProxyCsvEntryType : NSXTCsvRecordType
    {
        /// <summary>
        /// Identifier of connected service on port.
        /// </summary>
        [JsonProperty(PropertyName = "service_id")]
        public string? ServiceId { get; set; }
        /// <summary>
        /// ARP proxy information for a service with ip.
        /// </summary>
        [JsonProperty(PropertyName = "arp_proxy_ip")]
        public string? ArpProxyIp { get; set; }
        /// <summary>
        /// Policy path of gateway interface
        /// </summary>
        [JsonProperty(PropertyName = "interface_path")]
        public string? InterfacePath { get; set; }
    }
}
