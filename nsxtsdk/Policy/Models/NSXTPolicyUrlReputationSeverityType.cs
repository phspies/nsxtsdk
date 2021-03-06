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
    public class NSXTPolicyUrlReputationSeverityType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// The maximum reputation for the severity.
        /// </summary>
        [JsonProperty(PropertyName = "max_reputation", Required = Required.AllowNull)]
        public int MaxReputation { get; set; }
        /// <summary>
        /// The minimum reputation for the severity.
        /// </summary>
        [JsonProperty(PropertyName = "min_reputation", Required = Required.AllowNull)]
        public int MinReputation { get; set; }
        /// <summary>
        /// The id of the reputation severity.
        /// </summary>
        [JsonProperty(PropertyName = "reputation_severity_id", Required = Required.AllowNull)]
        public int ReputationSeverityId { get; set; }
        /// <summary>
        /// The name of the severity.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
    }
}
