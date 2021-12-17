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
    /// Field Setting Value.
    /// </summary>
    [NSXTProperty(Description: @"Field Setting Value.")]
    public class NSXTFieldSettingValueType 
    {
        public NSXTFieldSettingValueType()
        {
        }
        /// <summary>
        /// Field Setting Value resource type.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Field Setting Value resource type.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTFieldSettingValueResourceTypeEnumType ResourceType { get; set; }
    }
}
