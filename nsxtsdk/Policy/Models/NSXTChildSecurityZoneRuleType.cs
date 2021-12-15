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
    [NSXTProperty(Description: @"")]
    public class NSXTChildSecurityZoneRuleType : NSXTChildPolicyConfigResourceType
    {
        /// <summary>
        /// Contains the actual SecurityZoneRule object.
        /// </summary>
        [JsonProperty(PropertyName = "SecurityZoneRule", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Contains the actual SecurityZoneRule object.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTSecurityZoneRuleType SecurityZoneRule { get; set; }
    }
}