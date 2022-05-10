using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Used to specify subnets in L3Vpn rule.
    /// </summary>
    [NSXTProperty(Description: @"Used to specify subnets in L3Vpn rule.")]
    public class NSXTL3VpnSubnetType 
    {
        /// <summary>
        /// Subnet used in L3Vpn Rule.
        /// </summary>
        [JsonProperty(PropertyName = "subnet", Required = Required.AllowNull)]
        public string Subnet { get; set; }
    }
}
