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
    [JsonInheritanceAttribute("IPSecVpnSessionStatisticsNsxT", typeof(NSXTIPSecVpnSessionStatisticsNsxTType))]
    [NSXTProperty(Description: @"")]
    public class NSXTIPSecVpnSessionStatisticsPerEPType : NSXTPolicyRuntimeInfoPerEPType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIpsecVpnSessionStatisticsPerEPResourceTypeEnumType ResourceType { get; set; }
    }
}
