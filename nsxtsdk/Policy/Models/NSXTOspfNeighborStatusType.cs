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
    /// OSPF Neighbor Status.
    /// </summary>
    [NSXTProperty(Description: @"OSPF Neighbor Status.")]
    public class NSXTOspfNeighborStatusType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "neighbor_status_info")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public IList<NSXTOspfStatusInfoType> NeighborStatusInfo { get; set; }
        /// <summary>
        /// OSPF neighbor address.
        /// </summary>
        [JsonProperty(PropertyName = "neighbor_address")]
        [NSXTProperty(IsRequired: false, Description: @"OSPF neighbor address.")]
        public string? NeighborAddress { get; set; }
    }
}