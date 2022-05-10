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
    public class NSXTUpgradeStatusType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "host_status")]
        public NSXTHostUpgradeStatusType HostStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ccp_status")]
        public NSXTCCPUpgradeStatusType CcpStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "edge_status")]
        public NSXTEdgeUpgradeStatusType EdgeStatus { get; set; }
        /// <summary>
        /// Status of upgrade
        /// </summary>
        [JsonProperty(PropertyName = "overall_upgrade_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTUpgradeStatusOverallUpgradeStatusEnumType? OverallUpgradeStatus { get; set; }
        /// <summary>
        /// List of component statuses
        /// </summary>
        [JsonProperty(PropertyName = "component_status")]
        public IList<NSXTComponentUpgradeStatusType> ComponentStatus { get; set; }
    }
}
