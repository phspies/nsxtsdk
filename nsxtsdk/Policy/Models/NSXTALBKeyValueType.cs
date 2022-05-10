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
    /// Advanced load balancer KeyValue object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer KeyValue object")]
    public class NSXTALBKeyValueType 
    {
        /// <summary>
        /// Value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string? Value { get; set; }
        /// <summary>
        /// Key.
        /// </summary>
        [JsonProperty(PropertyName = "key", Required = Required.AllowNull)]
        public string Key { get; set; }
    }
}
