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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Contain Mitre attack details like tacticName, tacticUrl, techniqueName and techniqueUrl.
    /// </summary>
    [NSXTProperty(Description: @"Contain Mitre attack details like tacticName, tacticUrl, techniqueName and techniqueUrl.")]
    public class NSXTMitreAttackType 
    {
        public NSXTMitreAttackType()
        {
        }
        /// <summary>
        /// Represents tactic url of attack.
        /// </summary>
        [JsonProperty(PropertyName = "tactic_url")]
        [NSXTProperty(IsRequired: false, Description: @"Represents tactic url of attack.")]
        public string? TacticUrl { get; set; }
        /// <summary>
        /// Represents tactic name of attack.
        /// </summary>
        [JsonProperty(PropertyName = "tactic_name")]
        [NSXTProperty(IsRequired: false, Description: @"Represents tactic name of attack.")]
        public string? TacticName { get; set; }
        /// <summary>
        /// Represents technique name of attack.
        /// </summary>
        [JsonProperty(PropertyName = "technique_name")]
        [NSXTProperty(IsRequired: false, Description: @"Represents technique name of attack.")]
        public string? TechniqueName { get; set; }
        /// <summary>
        /// Represents technique url of attack.
        /// </summary>
        [JsonProperty(PropertyName = "technique_url")]
        [NSXTProperty(IsRequired: false, Description: @"Represents technique url of attack.")]
        public string? TechniqueUrl { get; set; }
    }
}
