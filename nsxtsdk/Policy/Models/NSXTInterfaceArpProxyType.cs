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
    public class NSXTInterfaceArpProxyType : NSXTListResultType
    {
        /// <summary>
        /// Array of ARP proxy table entries
        /// </summary>
        [JsonProperty(PropertyName = "arp_proxy_entries")]
        public IList<NSXTPolicyArpProxyEntryType> ArpProxyEntries { get; set; }
        /// <summary>
        /// Policy path of gateway interface
        /// </summary>
        [JsonProperty(PropertyName = "interface_path")]
        public string? InterfacePath { get; set; }
    }
}
