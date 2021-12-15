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
    /// Used to specify the local/peer subnets in IPSec VPN rule.
    /// </summary>
    [NSXTProperty(Description: @"Used to specify the local/peer subnets in IPSec VPN rule.")]
    public class NSXTIPSecVpnSubnetType 
    {
        /// <summary>
        /// Subnet used in policy rule.
        /// </summary>
        [JsonProperty(PropertyName = "subnet", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Subnet used in policy rule.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Subnet { get; set; }
    }
}
