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
    /// OSPF Neighbor Status.
    /// </summary>
    [NSXTProperty(Description: @"OSPF Neighbor Status.")]
    public class NSXTOspfNeighborStatusType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "neighbor_status_info")]
        public IList<NSXTOspfStatusInfoType> NeighborStatusInfo { get; set; }
        /// <summary>
        /// OSPF neighbor address.
        /// </summary>
        [JsonProperty(PropertyName = "neighbor_address")]
        public string? NeighborAddress { get; set; }
    }
}
