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
    /// Short name or alias of a url. It is used to represent the url.
    /// </summary>
    [NSXTProperty(Description: @"Short name or alias of a url. It is used to represent the url.")]
    public class NSXTUrlAliasType 
    {
        /// <summary>
        /// Url to fetch data from.
        /// </summary>
        [JsonProperty(PropertyName = "url", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Url to fetch data from.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Url { get; set; }
        /// <summary>
        /// Short name or alias of url, if any. If not specified, the url can be referenced by its index in the array of urls of the
        /// datasource instance as $<index> (for example, $0).
        /// </summary>
        [JsonProperty(PropertyName = "alias")]
        [NSXTProperty(IsRequired: false, Description: @"Short name or alias of url, if any. If not specified, the url can be referenced by its index in the array of urls of the datasource instance as $&lt;index&gt; (for example, $0).")]
        public string? Alias { get; set; }
        /// <summary>
        /// Search query to be applied, if any. If query string is not provided, it will be ignored.
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        [NSXTProperty(IsRequired: false, Description: @"Search query to be applied, if any. If query string is not provided, it will be ignored.")]
        public string? Query { get; set; }
    }
}
