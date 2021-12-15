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
    /// Resource Field Pointer representing the exact value within a policy object.
    /// </summary>
    [NSXTProperty(Description: @"Resource Field Pointer representing the exact value within a policy object.")]
    public class NSXTResourceFieldPointerType 
    {
        /// <summary>
        /// Policy Path referencing a policy object. If not supplied, the field pointer will be applied
        /// to the event source.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        [NSXTProperty(IsRequired: false, Description: @"Policy Path referencing a policy object. If not supplied, the field pointer will be appliedto the event source.")]
        public string? Path { get; set; }
        /// <summary>
        /// Field Pointer referencing the exact field within the policy object.
        /// </summary>
        [JsonProperty(PropertyName = "field_pointer", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Field Pointer referencing the exact field within the policy object.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string FieldPointer { get; set; }
    }
}