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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Root of the api result set for forming rows.
    /// </summary>
    [NSXTProperty(Description: @"Root of the api result set for forming rows.")]
    public class NSXTRowListFieldType 
    {
        public NSXTRowListFieldType()
        {
        }
        /// <summary>
        /// Short name or alias of row list field, if any. If unspecified, the row list field can be referenced by its index in the
        /// array of row list fields as $<index> (for example, $0).
        /// </summary>
        [JsonProperty(PropertyName = "alias")]
        [NSXTProperty(IsRequired: false, Description: @"Short name or alias of row list field, if any. If unspecified, the row list field can be referenced by its index in the array of row list fields as $&lt;index&gt; (for example, $0).")]
        public string? Alias { get; set; }
        /// <summary>
        /// JSON path to the root of the api result set for forming rows.
        /// </summary>
        [JsonProperty(PropertyName = "path", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"JSON path to the root of the api result set for forming rows.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Path { get; set; }
    }
}
