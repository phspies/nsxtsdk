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
    [JsonInheritanceAttribute("RealizedNSService", typeof(NSXTRealizedNSServiceType))]
    [NSXTProperty(Description: @"")]
    public class NSXTRealizedServiceType : NSXTPolicyRealizedResourceType
    {
        /// <summary>
        /// Realized services
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTRealizedServiceResourceTypeEnumType ResourceType { get; set; }
    }
}
