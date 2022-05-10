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
    [JsonInheritanceAttribute("IPSecVpnSessionStatusNsxT", typeof(NSXTIPSecVpnSessionStatusNsxTType))]
    [NSXTProperty(Description: @"")]
    public class NSXTIPSecVpnSessionStatusPerEPType : NSXTPolicyRuntimeInfoPerEPType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIpsecVpnSessionStatusPerEPResourceTypeEnumType ResourceType { get; set; }
    }
}
