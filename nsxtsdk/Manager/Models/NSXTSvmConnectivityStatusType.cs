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
    public class NSXTSvmConnectivityStatusType : NSXTDiscoveredResourceType
    {
        /// <summary>
        /// Service name as provided for Anti Malware Solution or as provided for third party Endpoint Protection solution during
        /// service registration.
        /// </summary>
        [JsonProperty(PropertyName = "service_name")]
        public string? ServiceName { get; set; }
        /// <summary>
        /// Solution ID as provided for Anti Malware Solution(AMS) or as provided for third party Endpoint Protection(EPP) solution
        /// during service registration.
        /// </summary>
        [JsonProperty(PropertyName = "solution_id")]
        public string? SolutionId { get; set; }
        /// <summary>
        /// Connectivity status with the deployed Solution VM TRUE  - VM is configured and protected by EPP/AMS Service VM. FALSE -
        /// VM is either not configured for protection or VM is disconnected from EPP/AMS Service VM.
        /// </summary>
        [JsonProperty(PropertyName = "connectivity_status")]
        public bool? ConnectivityStatus { get; set; }
    }
}
