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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTIpAddressBlockType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Represents a network address and the prefix length which will be associated with a layer-2 broadcast domain. Support
        /// IPv4 and IPv6 CIDR.
        /// </summary>
        [JsonProperty(PropertyName = "cidr", Required = Required.AllowNull)]
        public string Cidr { get; set; }
    }
}
