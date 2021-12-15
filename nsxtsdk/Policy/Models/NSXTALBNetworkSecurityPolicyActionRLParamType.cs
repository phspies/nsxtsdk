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
    /// Advanced load balancer NetworkSecurityPolicyActionRLParam object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer NetworkSecurityPolicyActionRLParam object")]
    public class NSXTALBNetworkSecurityPolicyActionRLParamType 
    {
        /// <summary>
        /// Maximum number of connections or requests or packets per
        /// second.
        /// Allowed values are 1-4294967295.
        /// </summary>
        [JsonProperty(PropertyName = "max_rate", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Maximum number of connections or requests or packets persecond.Allowed values are 1-4294967295.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(4294967295)]
        [System.ComponentModel.DataAnnotations.Required]
        public long MaxRate { get; set; }
        /// <summary>
        /// Maximum number of connections or requests or packets to be
        /// rate limited instantaneously.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "burst_size", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Maximum number of connections or requests or packets to berate limited instantaneously.Default value when not specified in API or module isinterpreted by ALB Controller as 0.")]
        [System.ComponentModel.DataAnnotations.Required]
        [NSXTDefaultProperty(Default: "")]
        public long BurstSize { get; set; }
    }
}
