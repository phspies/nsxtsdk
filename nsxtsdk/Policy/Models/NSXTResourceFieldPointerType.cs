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
        public string? Path { get; set; }
        /// <summary>
        /// Field Pointer referencing the exact field within the policy object.
        /// </summary>
        [JsonProperty(PropertyName = "field_pointer", Required = Required.AllowNull)]
        public string FieldPointer { get; set; }
    }
}
