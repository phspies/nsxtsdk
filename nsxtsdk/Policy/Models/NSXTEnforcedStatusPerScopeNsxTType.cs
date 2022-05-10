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
    /// NSX-T Detailed Realized Status Per Scope.
    /// </summary>
    [NSXTProperty(Description: @"NSX-T Detailed Realized Status Per Scope.")]
    public class NSXTEnforcedStatusPerScopeNsxTType 
    {
        /// <summary>
        /// Enforced Realized Status Per Scope Resource Type.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTEnforcedStatusPerScopeNsxTResourceTypeEnumType ResourceType { get; set; }
    }
}
