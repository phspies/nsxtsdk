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
    /// Field Setting Value.
    /// </summary>
    [NSXTProperty(Description: @"Field Setting Value.")]
    public class NSXTFieldSettingValueType 
    {
        /// <summary>
        /// Field Setting Value resource type.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTFieldSettingValueResourceTypeEnumType ResourceType { get; set; }
    }
}
