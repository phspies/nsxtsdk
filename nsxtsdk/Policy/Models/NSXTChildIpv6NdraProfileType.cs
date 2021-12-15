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
    public class NSXTChildIpv6NdraProfileType : NSXTChildPolicyConfigResourceType
    {
        /// <summary>
        /// Contains the actual Ipv6NdraProfile objects
        /// </summary>
        [JsonProperty(PropertyName = "Ipv6NdraProfile", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Contains the actual Ipv6NdraProfile objects")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTIpv6NdraProfileType Ipv6NdraProfile { get; set; }
    }
}
