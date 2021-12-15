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
    /// BPDU filter configuration
    /// </summary>
    [NSXTProperty(Description: @"BPDU filter configuration")]
    public class NSXTBpduFilterType 
    {
        /// <summary>
        /// Pre-defined list of allowed MAC addresses to be excluded from BPDU filtering
        /// </summary>
        [JsonProperty(PropertyName = "white_list")]
        [NSXTProperty(IsRequired: false, Description: @"Pre-defined list of allowed MAC addresses to be excluded from BPDU filtering")]
        public IList<string> WhiteList { get; set; }
        /// <summary>
        /// Indicates whether BPDU filter is enabled
        /// </summary>
        [JsonProperty(PropertyName = "enabled", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Indicates whether BPDU filter is enabled")]
        [System.ComponentModel.DataAnnotations.Required]
        public bool Enabled { get; set; }
    }
}