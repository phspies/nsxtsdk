// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

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
        [NSXTProperty(IsRequired: true, Description: @"GatewayGeneralSecurityProfile is used for all Tier0 and Tier1 gateways.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTGeneralSecurityProfileResourceTypeEnumType ResourceType { get; set; }
    }
}