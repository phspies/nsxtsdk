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
    [JsonInheritanceAttribute("L2VpnSessionRemoteMacNsxT", typeof(NSXTL2VpnSessionRemoteMacNsxTType))]
    [NSXTProperty(Description: @"")]
    public class NSXTL2VpnSessionRemoteMacPerEPType : NSXTPolicyRuntimeInfoPerEPType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTL2VpnSessionRemoteMacPerEPResourceTypeEnumType ResourceType { get; set; }
    }
}
