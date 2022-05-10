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
    public class NSXTNiocProfileType : NSXTBaseHostSwitchProfileType
    {
        /// <summary>
        /// host_infra_traffic_res specifies bandwidth allocation for
        /// various traffic resources.
        /// </summary>
        [JsonProperty(PropertyName = "host_infra_traffic_res")]
        public IList<NSXTResourceAllocationType> HostInfraTrafficRes { get; set; }
        /// <summary>
        /// The enabled property specifies the status of NIOC feature.
        /// When enabled is set to true, NIOC feature is turned on and
        /// the bandwidth allocations specified for the traffic resources
        /// are enforced. When enabled is set to false, NIOC feature
        /// is turned off and no bandwidth allocation is guaranteed.
        /// By default, enabled will be set to true.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
    }
}
