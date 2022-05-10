using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Contain Mitre attack details like tacticName, tacticUrl, techniqueName and techniqueUrl.
    /// </summary>
    [NSXTProperty(Description: @"Contain Mitre attack details like tacticName, tacticUrl, techniqueName and techniqueUrl.")]
    public class NSXTMitreAttackType 
    {
        /// <summary>
        /// Represents tactic url of attack.
        /// </summary>
        [JsonProperty(PropertyName = "tactic_url")]
        public string? TacticUrl { get; set; }
        /// <summary>
        /// Represents tactic name of attack.
        /// </summary>
        [JsonProperty(PropertyName = "tactic_name")]
        public string? TacticName { get; set; }
        /// <summary>
        /// Represents technique name of attack.
        /// </summary>
        [JsonProperty(PropertyName = "technique_name")]
        public string? TechniqueName { get; set; }
        /// <summary>
        /// Represents technique url of attack.
        /// </summary>
        [JsonProperty(PropertyName = "technique_url")]
        public string? TechniqueUrl { get; set; }
    }
}
