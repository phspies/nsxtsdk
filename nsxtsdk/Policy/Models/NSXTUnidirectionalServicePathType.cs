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
    /// Representing either forward or reverse service path for ingress or egress traffic respectively.
    /// </summary>
    [NSXTProperty(Description: @"Representing either forward or reverse service path for ingress or egress traffic respectively.")]
    public class NSXTUnidirectionalServicePathType 
    {
        public NSXTUnidirectionalServicePathType()
        {
        }
        /// <summary>
        /// List of service path hops that constitutes the forward or reverse service path.
        /// </summary>
        [JsonProperty(PropertyName = "hops")]
        [NSXTProperty(IsRequired: false, Description: @"List of service path hops that constitutes the forward or reverse service path.")]
        public IList<NSXTServicePathHopType> Hops { get; set; }
        /// <summary>
        /// Is forward or revserse service path in maintenance mode or not.
        /// </summary>
        [JsonProperty(PropertyName = "in_maintenance_mode")]
        [NSXTProperty(IsRequired: false, Description: @"Is forward or revserse service path in maintenance mode or not.")]
        public bool? InMaintenanceMode { get; set; }
        /// <summary>
        /// The number of times the traffic needs to cross hosts for the given forward or reverse service path.
        /// </summary>
        [JsonProperty(PropertyName = "host_cross_count")]
        [NSXTProperty(IsRequired: false, Description: @"The number of times the traffic needs to cross hosts for the given forward or reverse service path.")]
        public long? HostCrossCount { get; set; }
        /// <summary>
        /// Is forward or revserse service path active or not.
        /// </summary>
        [JsonProperty(PropertyName = "is_active")]
        [NSXTProperty(IsRequired: false, Description: @"Is forward or revserse service path active or not.")]
        public bool? IsActive { get; set; }
        /// <summary>
        /// Unique identifier of one directional service path.
        /// </summary>
        [JsonProperty(PropertyName = "unidir_service_path_id")]
        [NSXTProperty(IsRequired: false, Description: @"Unique identifier of one directional service path.")]
        public long? UnidirServicePathId { get; set; }
    }
}
