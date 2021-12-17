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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTOspfDatabaseStatusType 
    {
        public NSXTOspfDatabaseStatusType()
        {
        }
        /// <summary>
        /// array of nssa external link of OSPF database
        /// </summary>
        [JsonProperty(PropertyName = "nssa_external_link_states")]
        [NSXTProperty(IsRequired: false, Description: @"array of nssa external link of OSPF database")]
        public IList<NSXTMpOspfExternalLinkStateType> NssaExternalLinkStates { get; set; }
        /// <summary>
        /// array of external link of OSPF database
        /// </summary>
        [JsonProperty(PropertyName = "external_link_states")]
        [NSXTProperty(IsRequired: false, Description: @"array of external link of OSPF database")]
        public IList<NSXTMpOspfExternalLinkStateType> ExternalLinkStates { get; set; }
        /// <summary>
        /// OSPF area id to filter the the OSPF database.
        /// </summary>
        [JsonProperty(PropertyName = "area_id")]
        [NSXTProperty(IsRequired: false, Description: @"OSPF area id to filter the the OSPF database.")]
        public string? AreaId { get; set; }
        /// <summary>
        /// array of link state of OSPF database
        /// </summary>
        [JsonProperty(PropertyName = "router_link_states")]
        [NSXTProperty(IsRequired: false, Description: @"array of link state of OSPF database")]
        public IList<NSXTMpOspfRouterLinkStatesType> RouterLinkStates { get; set; }
        /// <summary>
        /// array of network link state of OSPF database
        /// </summary>
        [JsonProperty(PropertyName = "net_link_states")]
        [NSXTProperty(IsRequired: false, Description: @"array of network link state of OSPF database")]
        public IList<NSXTMpOspfNetworkLinkStatesType> NetLinkStates { get; set; }
        /// <summary>
        /// array of summary link state of OSPF database
        /// </summary>
        [JsonProperty(PropertyName = "summary_link_states")]
        [NSXTProperty(IsRequired: false, Description: @"array of summary link state of OSPF database")]
        public IList<NSXTMpOspfSummaryLinkStatesType> SummaryLinkStates { get; set; }
        /// <summary>
        /// array of ASBR summary link state of OSPF database
        /// </summary>
        [JsonProperty(PropertyName = "asbr_summary_link_states")]
        [NSXTProperty(IsRequired: false, Description: @"array of ASBR summary link state of OSPF database")]
        public IList<NSXTMpOspfSummaryLinkStatesType> AsbrSummaryLinkStates { get; set; }
        /// <summary>
        /// Policy path to edge node.
        /// </summary>
        [JsonProperty(PropertyName = "edge_path")]
        [NSXTProperty(IsRequired: false, Description: @"Policy path to edge node.")]
        public string? EdgePath { get; set; }
    }
}
