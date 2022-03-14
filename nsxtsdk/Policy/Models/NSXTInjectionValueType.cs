// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

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
        public NSXTInjectionValueResourceTypeEnumType ResourceType { get; set; }
    }
}
