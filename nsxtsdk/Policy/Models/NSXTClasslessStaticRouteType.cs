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
    /// DHCP classless static route option.
    /// </summary>
    [NSXTProperty(Description: @"DHCP classless static route option.")]
    public class NSXTClasslessStaticRouteType 
    {
        /// <summary>
        /// IP address of next hop of the route.
        /// </summary>
        [JsonProperty(PropertyName = "next_hop", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"IP address of next hop of the route.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string NextHop { get; set; }
        /// <summary>
        /// Destination network in CIDR format.
        /// </summary>
        [JsonProperty(PropertyName = "network", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Destination network in CIDR format.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Network { get; set; }
    }
}