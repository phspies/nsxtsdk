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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTPolicyUrlCategorizationConfigType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// The frequency in minutes at which the updates are downloaded from the
        /// URL categorization cloud service. The minimum allowed value is 5
        /// minutes.
        /// </summary>
        [JsonProperty(PropertyName = "update_frequency")]
        public int? UpdateFrequency { get; set; }
        /// <summary>
        /// The ids of the context profiles that provides the list of categories to
        /// be detected. This field is deprecated. URL Categorization will not be
        /// supported in association with context profiles.
        /// </summary>
        [JsonProperty(PropertyName = "context_profiles")]
        public IList<string> ContextProfiles { get; set; }
        /// <summary>
        /// Property which specifies the enabling/disabling of the feature.
        /// </summary>
        [JsonProperty(PropertyName = "enabled", Required = Required.AllowNull)]
        public bool Enabled { get; set; }
    }
}
