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
    public class NSXTVirtualPortgroupType : NSXTDiscoveredResourceType
    {
        /// <summary>
        /// External id of the virtual portgroup
        /// </summary>
        [JsonProperty(PropertyName = "external_id")]
        public string? ExternalId { get; set; }
        /// <summary>
        /// Portgroup type like DistributedVirtualPortgroup
        /// </summary>
        [JsonProperty(PropertyName = "origin_type")]
        public string? OriginType { get; set; }
        /// <summary>
        /// Id of the portgroup, eg. a mo-ref from VC.
        /// </summary>
        [JsonProperty(PropertyName = "cm_local_id")]
        public string? CmLocalId { get; set; }
    }
}
