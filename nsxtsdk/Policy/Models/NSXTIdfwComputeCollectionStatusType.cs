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
    /// compute collection ID and status connected to VC.
    /// </summary>
    [NSXTProperty(Description: @"compute collection ID and status connected to VC.")]
    public class NSXTIdfwComputeCollectionStatusType 
    {
        /// <summary>
        /// IDFW enabled compute collection status.
        /// </summary>
        [JsonProperty(PropertyName = "compute_collection_status")]
        public IList<NSXTIdfwComputeCollectionConditionType> ComputeCollectionStatus { get; set; }
        /// <summary>
        /// IDFW compute collection ID connected to VC.
        /// </summary>
        [JsonProperty(PropertyName = "compute_collection_id", Required = Required.AllowNull)]
        public string ComputeCollectionId { get; set; }
    }
}
