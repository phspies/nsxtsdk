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
    public class NSXTUpgradeUnitGroupInfoType 
    {
        public NSXTUpgradeUnitGroupInfoType()
        {
        }
        /// <summary>
        /// Name of the group
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        [NSXTProperty(IsRequired: false, Description: @"Name of the group")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// Identifier of group
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        [NSXTProperty(IsRequired: false, Description: @"Identifier of group")]
        public string? Id { get; set; }
    }
}
