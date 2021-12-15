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
    public class NSXTPolicyArpProxyEntryType 
    {
        /// <summary>
        /// Identifier of connected service on port.
        /// </summary>
        [JsonProperty(PropertyName = "service_id")]
        [NSXTProperty(IsRequired: false, Description: @"Identifier of connected service on port.")]
        public string? ServiceId { get; set; }
        /// <summary>
        /// ARP proxy information for a service with ip.
        /// </summary>
        [JsonProperty(PropertyName = "arp_proxy_ip")]
        [NSXTProperty(IsRequired: false, Description: @"ARP proxy information for a service with ip.")]
        public IList<string> ArpProxyIp { get; set; }
    }
}
