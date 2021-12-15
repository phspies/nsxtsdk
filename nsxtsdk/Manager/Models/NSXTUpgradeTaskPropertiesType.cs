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
    /// Task properties
    /// </summary>
    [NSXTProperty(Description: @"Task properties")]
    public class NSXTUpgradeTaskPropertiesType 
    {
        /// <summary>
        /// Name of Bundle
        /// </summary>
        [JsonProperty(PropertyName = "bundle_name", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Name of Bundle")]
        [System.ComponentModel.DataAnnotations.Required]
        public string BundleName { get; set; }
        /// <summary>
        /// Step name
        /// </summary>
        [JsonProperty(PropertyName = "step")]
        [NSXTProperty(IsRequired: false, Description: @"Step name")]
        public string? Step { get; set; }
        /// <summary>
        /// Bundle arguments
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        [NSXTProperty(IsRequired: false, Description: @"Bundle arguments")]
        public object? Parameters { get; set; }
    }
}
