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
    /// Root of the api result set for forming rows.
    /// </summary>
    [NSXTProperty(Description: @"Root of the api result set for forming rows.")]
    public class NSXTRowListFieldType 
    {
        /// <summary>
        /// Short name or alias of row list field, if any. If unspecified, the row list field can be referenced by its index in the
        /// array of row list fields as $<index> (for example, $0).
        /// </summary>
        [JsonProperty(PropertyName = "alias")]
        public string? Alias { get; set; }
        /// <summary>
        /// JSON path to the root of the api result set for forming rows.
        /// </summary>
        [JsonProperty(PropertyName = "path", Required = Required.AllowNull)]
        public string Path { get; set; }
    }
}
