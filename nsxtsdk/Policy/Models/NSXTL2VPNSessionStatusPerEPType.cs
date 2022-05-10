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
    [JsonInheritanceAttribute("L2VPNSessionStatusNsxT", typeof(NSXTL2VPNSessionStatusNsxTType))]
    [NSXTProperty(Description: @"")]
    public class NSXTL2VPNSessionStatusPerEPType : NSXTPolicyRuntimeInfoPerEPType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTL2VpnsessionStatusPerEPResourceTypeEnumType ResourceType { get; set; }
    }
}
