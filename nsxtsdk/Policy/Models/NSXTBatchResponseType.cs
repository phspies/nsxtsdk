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
    /// The reponse to a batch operation
    /// </summary>
    [NSXTProperty(Description: @"The reponse to a batch operation")]
    public class NSXTBatchResponseType 
    {
        /// <summary>
        /// Indicates if any of the APIs failed
        /// </summary>
        [JsonProperty(PropertyName = "has_errors")]
        public bool? HasErrors { get; set; }
        /// <summary>
        /// Optional flag indicating that all items were rolled back even if succeeded initially
        /// </summary>
        [JsonProperty(PropertyName = "rolled_back")]
        public bool? RolledBack { get; set; }
        /// <summary>
        /// Bulk list results
        /// </summary>
        [JsonProperty(PropertyName = "results", Required = Required.AllowNull)]
        public IList<NSXTBatchResponseItemType> Results { get; set; }
    }
}
