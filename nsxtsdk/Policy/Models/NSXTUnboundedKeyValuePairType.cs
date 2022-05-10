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
    /// A key-value pair with no limitations on size
    /// </summary>
    [NSXTProperty(Description: @"A key-value pair with no limitations on size")]
    public class NSXTUnboundedKeyValuePairType 
    {
        /// <summary>
        /// Value
        /// </summary>
        [JsonProperty(PropertyName = "value", Required = Required.AllowNull)]
        public string Value { get; set; }
        /// <summary>
        /// Key
        /// </summary>
        [JsonProperty(PropertyName = "key", Required = Required.AllowNull)]
        public string Key { get; set; }
    }
}
