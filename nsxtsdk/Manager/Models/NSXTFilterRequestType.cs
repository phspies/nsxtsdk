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
    /// Filter request parameters
    /// </summary>
    [NSXTProperty(Description: @"Filter request parameters")]
    public class NSXTFilterRequestType 
    {
        /// <summary>
        /// Comma seperated fields to be filtered on
        /// </summary>
        [JsonProperty(PropertyName = "field_names", Required = Required.AllowNull)]
        public string FieldNames { get; set; }
        /// <summary>
        /// Filter value
        /// </summary>
        [JsonProperty(PropertyName = "value", Required = Required.AllowNull)]
        public string Value { get; set; }
        /// <summary>
        /// Set this flag to true to make filtering case-sensitive.
        /// </summary>
        [JsonProperty(PropertyName = "case_sensitive")]
        public bool? CaseSensitive { get; set; }
    }
}
