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
    /// Advanced load balancer IpAddrRange object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer IpAddrRange object")]
    public class NSXTALBIpAddrRangeType 
    {
        /// <summary>
        /// Starting IP address of the range.
        /// </summary>
        [JsonProperty(PropertyName = "begin", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Starting IP address of the range.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrType Begin { get; set; }
        /// <summary>
        /// Ending IP address of the range.
        /// </summary>
        [JsonProperty(PropertyName = "end", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Ending IP address of the range.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrType End { get; set; }
    }
}