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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTTriggerUcUpgradeParametersType 
    {
        public NSXTTriggerUcUpgradeParametersType()
        {
        }
        /// <summary>
        /// Target upgrade coordinator version.
        /// </summary>
        [JsonProperty(PropertyName = "product_version")]
        [NSXTProperty(IsRequired: false, Description: @"Target upgrade coordinator version.")]
        public string? ProductVersion { get; set; }
    }
}