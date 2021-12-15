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
    /// Subnet specification for interface connectivity
    /// </summary>
    [NSXTProperty(Description: @"Subnet specification for interface connectivity")]
    public class NSXTInterfaceSubnetType 
    {
        /// <summary>
        /// IP addresses assigned to interface
        /// </summary>
        [JsonProperty(PropertyName = "ip_addresses", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"IP addresses assigned to interface")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<string> IpAddresses { get; set; }
        /// <summary>
        /// Subnet prefix length
        /// </summary>
        [JsonProperty(PropertyName = "prefix_len", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Subnet prefix length")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(128)]
        [System.ComponentModel.DataAnnotations.Required]
        public long PrefixLen { get; set; }
    }
}