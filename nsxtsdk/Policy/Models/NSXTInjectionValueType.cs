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
    /// Injection Value.
    /// </summary>
    [NSXTProperty(Description: @"Injection Value.")]
    public class NSXTInjectionValueType 
    {
        public NSXTInjectionValueType()
        {
        }
        /// <summary>
        /// Injection Value resource type.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Injection Value resource type.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTInjectionValueResourceTypeEnumType ResourceType { get; set; }
    }
}
