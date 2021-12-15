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
    public class NSXTVIPSubnetType 
    {
        /// <summary>
        /// Subnet Prefix Length
        /// </summary>
        [JsonProperty(PropertyName = "prefix_length", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Subnet Prefix Length")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(128)]
        [System.ComponentModel.DataAnnotations.Required]
        public long PrefixLength { get; set; }
        /// <summary>
        /// Array of IP address subnets which will be used as floating IP addresses. | These IPs will move and will be owned by
        /// Active node.
        /// </summary>
        [JsonProperty(PropertyName = "active_vip_addresses", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Array of IP address subnets which will be used as floating IP addresses. | These IPs will move and will be owned by Active node.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<string> ActiveVipAddresses { get; set; }
    }
}