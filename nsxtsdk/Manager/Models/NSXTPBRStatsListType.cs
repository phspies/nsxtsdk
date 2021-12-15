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
    public class NSXTPBRStatsListType : NSXTListResultType
    {
        /// <summary>
        /// PBR section identifier.
        /// </summary>
        [JsonProperty(PropertyName = "section_id")]
        [NSXTProperty(IsRequired: false, Description: @"PBR section identifier.")]
        public string? SectionId { get; set; }
        /// <summary>
        /// List of rule statistics.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        [NSXTProperty(IsRequired: false, Description: @"List of rule statistics.")]
        public IList<NSXTPBRStatsType> Results { get; set; }
    }
}
