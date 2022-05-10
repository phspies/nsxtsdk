using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTPrefixConfigType 
    {
        /// <summary>
        /// Action for the IPPrefix
        /// </summary>
        [JsonProperty(PropertyName = "action", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPrefixConfigActionEnumType Action { get; set; }
        /// <summary>
        /// Greater than or equal to
        /// </summary>
        [JsonProperty(PropertyName = "ge")]
        public long? Ge { get; set; }
        /// <summary>
        /// Less than or equal to
        /// </summary>
        [JsonProperty(PropertyName = "le")]
        public long? Le { get; set; }
        /// <summary>
        /// If absent, the action applies to all addresses.
        /// </summary>
        [JsonProperty(PropertyName = "network")]
        public string? Network { get; set; }
    }
}
