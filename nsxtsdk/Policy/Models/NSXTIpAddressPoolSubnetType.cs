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
    [JsonConverter(typeof(JsonInheritanceConverter), "resource_type")]
    [JsonInheritanceAttribute("IpAddressPoolBlockSubnet", typeof(NSXTIpAddressPoolBlockSubnetType))]
    [JsonInheritanceAttribute("IpAddressPoolStaticSubnet", typeof(NSXTIpAddressPoolStaticSubnetType))]
    [NSXTProperty(Description: @"")]
    public class NSXTIpAddressPoolSubnetType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Specifies whether the IpAddressPoolSubnet is to be carved out of a IpAddressBlock or will be specified by the user
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIpAddressPoolSubnetResourceTypeEnumType ResourceType { get; set; }
    }
}
