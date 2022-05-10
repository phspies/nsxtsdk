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
    /// An instance of a datasource configuration.
    /// </summary>
    [NSXTProperty(Description: @"An instance of a datasource configuration.")]
    public class NSXTDefaultFilterValueType 
    {
        /// <summary>
        /// Filter alias.
        /// </summary>
        [JsonProperty(PropertyName = "alias", Required = Required.AllowNull)]
        public string Alias { get; set; }
        /// <summary>
        /// Filter default value.
        /// </summary>
        [JsonProperty(PropertyName = "value", Required = Required.AllowNull)]
        public string Value { get; set; }
    }
}
