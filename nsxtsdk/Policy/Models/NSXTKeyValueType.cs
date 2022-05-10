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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTKeyValueType 
    {
        /// <summary>
        /// Key value.
        /// </summary>
        [JsonProperty(PropertyName = "value", Required = Required.AllowNull)]
        public string Value { get; set; }
        /// <summary>
        /// Key name.
        /// </summary>
        [JsonProperty(PropertyName = "key", Required = Required.AllowNull)]
        public string Key { get; set; }
    }
}
