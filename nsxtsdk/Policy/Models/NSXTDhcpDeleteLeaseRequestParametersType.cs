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
    public class NSXTDhcpDeleteLeaseRequestParametersType 
    {
        public NSXTDhcpDeleteLeaseRequestParametersType()
        {
        }
        /// <summary>
        /// IPv4 or IPv6 address
        /// </summary>
        [JsonProperty(PropertyName = "ip", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"IPv4 or IPv6 address")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Ip { get; set; }
        /// <summary>
        /// A MAC address. Must be 6 pairs of hexadecimal digits, upper or lower case,
        /// separated by colons or dashes. Examples: 01:23:45:67:89:ab, 01-23-45-67-89-AB.
        /// </summary>
        [JsonProperty(PropertyName = "mac", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"A MAC address. Must be 6 pairs of hexadecimal digits, upper or lower case,separated by colons or dashes. Examples: 01:23:45:67:89:ab, 01-23-45-67-89-AB.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Mac { get; set; }
    }
}