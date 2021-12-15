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
    /// compute collection ID and status connected to VC.
    /// </summary>
    [NSXTProperty(Description: @"compute collection ID and status connected to VC.")]
    public class NSXTIdfwComputeCollectionStatusType 
    {
        /// <summary>
        /// IDFW enabled compute collection status.
        /// </summary>
        [JsonProperty(PropertyName = "compute_collection_status")]
        [NSXTProperty(IsRequired: false, Description: @"IDFW enabled compute collection status.")]
        public IList<NSXTIdfwComputeCollectionConditionType> ComputeCollectionStatus { get; set; }
        /// <summary>
        /// IDFW compute collection ID connected to VC.
        /// </summary>
        [JsonProperty(PropertyName = "compute_collection_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"IDFW compute collection ID connected to VC.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ComputeCollectionId { get; set; }
    }
}