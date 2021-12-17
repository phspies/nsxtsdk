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
    /// Advanced load balancer KeyValue object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer KeyValue object")]
    public class NSXTALBKeyValueType 
    {
        public NSXTALBKeyValueType()
        {
        }
        /// <summary>
        /// Value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        [NSXTProperty(IsRequired: false, Description: @"Value.")]
        public string? Value { get; set; }
        /// <summary>
        /// Key.
        /// </summary>
        [JsonProperty(PropertyName = "key", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Key.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Key { get; set; }
    }
}
