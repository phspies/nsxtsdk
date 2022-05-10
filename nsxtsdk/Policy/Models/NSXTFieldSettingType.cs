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
    /// Field Setting.
    /// </summary>
    [NSXTProperty(Description: @"Field Setting.")]
    public class NSXTFieldSettingType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "value", Required = Required.AllowNull)]
        public NSXTFieldSettingValueType Value { get; set; }
        /// <summary>
        /// Field Pointer.
        /// </summary>
        [JsonProperty(PropertyName = "field_pointer", Required = Required.AllowNull)]
        public string FieldPointer { get; set; }
    }
}
