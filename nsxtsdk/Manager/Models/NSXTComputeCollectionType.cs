using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTComputeCollectionType : NSXTDiscoveredResourceType
    {
        /// <summary>
        /// Id of the compute manager from where this Compute Collection was discovered
        /// </summary>
        [JsonProperty(PropertyName = "origin_id")]
        public string? OriginId { get; set; }
        /// <summary>
        /// Key-Value map of additional specific properties of
        /// compute collection in the Compute Manager
        /// </summary>
        [JsonProperty(PropertyName = "origin_properties")]
        public IList<NSXTKeyValuePairType> OriginProperties { get; set; }
        /// <summary>
        /// External ID of the ComputeCollection in the source Compute manager,
        /// e.g. mo-ref in VC
        /// </summary>
        [JsonProperty(PropertyName = "external_id")]
        public string? ExternalId { get; set; }
        /// <summary>
        /// Id of the owner of compute collection in the Compute Manager
        /// </summary>
        [JsonProperty(PropertyName = "owner_id")]
        public string? OwnerId { get; set; }
        /// <summary>
        /// ComputeCollection type like VC_Cluster. Here the Compute Manager
        /// type prefix would help in differentiating similar named Compute
        /// Collection types from different Compute Managers
        /// </summary>
        [JsonProperty(PropertyName = "origin_type")]
        public string? OriginType { get; set; }
        /// <summary>
        /// Local Id of the compute collection in the Compute Manager
        /// </summary>
        [JsonProperty(PropertyName = "cm_local_id")]
        public string? CmLocalId { get; set; }
    }
}
