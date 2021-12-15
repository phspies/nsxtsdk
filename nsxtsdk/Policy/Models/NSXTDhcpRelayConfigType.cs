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
    public class NSXTDhcpRelayConfigType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// DHCP server IP addresses for DHCP relay configuration.
        /// Both IPv4 and IPv6 addresses are supported.
        /// </summary>
        [JsonProperty(PropertyName = "server_addresses", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"DHCP server IP addresses for DHCP relay configuration.Both IPv4 and IPv6 addresses are supported.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<string> ServerAddresses { get; set; }
    }
}