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
    public class NSXTIPInfoType 
    {
        public NSXTIPInfoType()
        {
        }
        /// <summary>
        /// IPv4 Addresses
        /// </summary>
        [JsonProperty(PropertyName = "ip_addresses", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"IPv4 Addresses")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<string> IpAddresses { get; set; }
        /// <summary>
        /// Subnet Prefix Length
        /// </summary>
        [JsonProperty(PropertyName = "prefix_length", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Subnet Prefix Length")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(32)]
        [System.ComponentModel.DataAnnotations.Required]
        public long PrefixLength { get; set; }
    }
}
