using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Used to specify the local/peer subnets in IPSec VPN Policy rule.
    /// </summary>
    [NSXTProperty(Description: @"Used to specify the local/peer subnets in IPSec VPN Policy rule.")]
    public class NSXTIPSecVPNPolicySubnetType 
    {
        /// <summary>
        /// Subnet used in policy rule.
        /// </summary>
        [JsonProperty(PropertyName = "subnet", Required = Required.AllowNull)]
        public string Subnet { get; set; }
    }
}
