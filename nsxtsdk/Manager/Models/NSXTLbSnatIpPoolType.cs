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
    public class NSXTLbSnatIpPoolType : NSXTLbSnatTranslationType
    {
        public NSXTLbSnatIpPoolType()
        {
        }
        /// <summary>
        /// If an IP range is specified, the range may contain no more than 64
        /// IP addresses.
        /// </summary>
        [JsonProperty(PropertyName = "ip_addresses", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"If an IP range is specified, the range may contain no more than 64IP addresses.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTLbSnatIpElementType> IpAddresses { get; set; }
    }
}
