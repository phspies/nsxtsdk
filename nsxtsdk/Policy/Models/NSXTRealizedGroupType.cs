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
    [JsonInheritanceAttribute("RealizedSecurityGroup", typeof(NSXTRealizedSecurityGroupType))]
    [JsonInheritanceAttribute("RealizedNSGroup", typeof(NSXTRealizedNSGroupType))]
    [NSXTProperty(Description: @"")]
    public class NSXTRealizedGroupType : NSXTPolicyRealizedResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTRealizedGroupResourceTypeEnumType ResourceType { get; set; }
    }
}
