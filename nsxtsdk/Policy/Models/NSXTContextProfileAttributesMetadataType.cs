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
    /// Key value structure for holding metadata of context profile attributes
    /// </summary>
    [NSXTProperty(Description: @"Key value structure for holding metadata of context profile attributes")]
    public class NSXTContextProfileAttributesMetadataType 
    {
        /// <summary>
        /// Value for metadata key
        /// </summary>
        [JsonProperty(PropertyName = "value", Required = Required.AllowNull)]
        public string Value { get; set; }
        /// <summary>
        /// Key for metadata
        /// </summary>
        [JsonProperty(PropertyName = "key", Required = Required.AllowNull)]
        public string Key { get; set; }
    }
}
