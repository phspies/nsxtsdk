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
    [JsonInheritanceAttribute("GatewayGeneralSecurityProfile", typeof(NSXTGatewayGeneralSecurityProfileType))]
    [NSXTProperty(Description: @"")]
    public class NSXTGeneralSecurityProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// GatewayGeneralSecurityProfile is used for all Tier0 and Tier1 gateways.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTGeneralSecurityProfileResourceTypeEnumType ResourceType { get; set; }
    }
}
