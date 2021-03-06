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
    /// Provides monitoring information for all flows in federation from the
        /// given site where the API is invoked. For example - monitoring information
        /// from Global Manager doesn't provide details of Local Manager to Local Manager
        /// flows. Similary, LocalManager will not provide Global Manager ACTIVE to
        /// Global Manager STANDBY flow details.
    /// </summary>
    [NSXTProperty(Description: @"Provides monitoring information for all flows in federation from thegiven site where the API is invoked. For example - monitoring informationfrom Global Manager doesn&apos;t provide details of Local Manager to Local Managerflows. Similary, LocalManager will not provide Global Manager ACTIVE toGlobal Manager STANDBY flow details.")]
    public class NSXTMonitoringInfoType 
    {
        /// <summary>
        /// All errors occurred while gathering monitoring info
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<NSXTMonitoringErrorType> Errors { get; set; }
        /// <summary>
        /// Monitoring information of flows in federation
        /// </summary>
        [JsonProperty(PropertyName = "flow_info")]
        public IList<NSXTFlowInfoType> FlowInfo { get; set; }
    }
}
