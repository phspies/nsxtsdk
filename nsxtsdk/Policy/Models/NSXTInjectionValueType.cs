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
    /// Injection Value.
    /// </summary>
    [NSXTProperty(Description: @"Injection Value.")]
    public class NSXTInjectionValueType 
    {
        /// <summary>
        /// Injection Value resource type.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTInjectionValueResourceTypeEnumType ResourceType { get; set; }
    }
}
