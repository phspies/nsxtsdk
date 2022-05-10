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
    /// Injection holding a key and a corresponding value.
    /// </summary>
    [NSXTProperty(Description: @"Injection holding a key and a corresponding value.")]
    public class NSXTInjectionType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "value", Required = Required.AllowNull)]
        public NSXTInjectionValueType Value { get; set; }
        /// <summary>
        /// Injection key.
        /// </summary>
        [JsonProperty(PropertyName = "key", Required = Required.AllowNull)]
        public string Key { get; set; }
    }
}
