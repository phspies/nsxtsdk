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
    /// Result of prechecks run for onboarding standby Global Manager or remote
        /// site. The checks include NSX version compatibility with active Global
        /// Manager, Round Trip Time (RTT), etc. Note that some of checks like RTT are
        /// soft limits.
    /// </summary>
    [NSXTProperty(Description: @"Result of prechecks run for onboarding standby Global Manager or remotesite. The checks include NSX version compatibility with active GlobalManager, Round Trip Time (RTT), etc. Note that some of checks like RTT aresoft limits.")]
    public class NSXTCompatibilityCheckResultType 
    {
        /// <summary>
        /// Round trip time to the remote Site or Global Manager from active
        /// Global Manager.
        /// </summary>
        [JsonProperty(PropertyName = "rtt")]
        public long? Rtt { get; set; }
        /// <summary>
        /// Flag to indicate if remote Site NSX version is compatible with active
        /// Global Manager.
        /// </summary>
        [JsonProperty(PropertyName = "version_compatible")]
        public bool? VersionCompatible { get; set; }
        /// <summary>
        /// Remote Site NSX version.
        /// </summary>
        [JsonProperty(PropertyName = "nsx_version")]
        public string? NsxVersion { get; set; }
        /// <summary>
        /// Flag to indicate if RTT to remote Site exceeds the recommended limit.
        /// </summary>
        [JsonProperty(PropertyName = "rtt_exceeded")]
        public bool? RttExceeded { get; set; }
        /// <summary>
        /// Local Site NSX version where active Global Mananger is running.
        /// </summary>
        [JsonProperty(PropertyName = "local_nsx_version")]
        public string? LocalNsxVersion { get; set; }
    }
}
