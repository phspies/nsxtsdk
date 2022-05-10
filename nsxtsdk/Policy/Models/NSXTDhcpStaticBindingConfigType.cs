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
    [JsonInheritanceAttribute("DhcpV4StaticBindingConfig", typeof(NSXTDhcpV4StaticBindingConfigType))]
    [JsonInheritanceAttribute("DhcpV6StaticBindingConfig", typeof(NSXTDhcpV6StaticBindingConfigType))]
    [NSXTProperty(Description: @"")]
    public class NSXTDhcpStaticBindingConfigType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTDhcpStaticBindingConfigResourceTypeEnumType ResourceType { get; set; }
    }
}
