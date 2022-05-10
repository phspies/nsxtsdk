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
    public class NSXTFailureDomainType : NSXTManagedResourceType
    {
        /// <summary>
        /// Set preference for edge transport node failure domain which will be
        /// considered while doing auto placement of logical router, DHCP and
        /// MDProxy on edge node.
        /// true: For preemptive failover mode, active edge cluster member
        /// allocation preferes this failure domain.
        /// false: For preemptive failover mode, standby edge cluster member
        /// allocation preferes this failure domain.
        /// Default will be unset. It means no explicit preference.
        /// </summary>
        [JsonProperty(PropertyName = "preferred_active_edge_services")]
        public bool? PreferredActiveEdgeServices { get; set; }
    }
}
