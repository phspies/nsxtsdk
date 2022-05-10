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
    /// All the types of value extend from this abstract class. This
        /// is present for extensibility.
    /// </summary>
    [NSXTProperty(Description: @"All the types of value extend from this abstract class. Thisis present for extensibility.")]
    public class NSXTConstraintValueType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTConstraintValueResourceTypeEnumType ResourceType { get; set; }
    }
}
