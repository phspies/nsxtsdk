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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTKeyValueType 
    {
        public NSXTKeyValueType()
        {
        }
        /// <summary>
        /// Key value.
        /// </summary>
        [JsonProperty(PropertyName = "value", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Key value.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Value { get; set; }
        /// <summary>
        /// Key name.
        /// </summary>
        [JsonProperty(PropertyName = "key", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Key name.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Key { get; set; }
    }
}
