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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Traffic statistics for IPSec VPN IKE session. Note - Not supported in this release.
    /// </summary>
    [NSXTProperty(Description: @"Traffic statistics for IPSec VPN IKE session. Note - Not supported in this release.")]
    public class NSXTIPSecVPNIKETrafficStatisticsType 
    {
        /// <summary>
        /// Number of packets out.
        /// </summary>
        [JsonProperty(PropertyName = "packets_out")]
        [NSXTProperty(IsRequired: false, Description: @"Number of packets out.")]
        public long? PacketsOut { get; set; }
        /// <summary>
        /// Fail count.
        /// </summary>
        [JsonProperty(PropertyName = "fail_count")]
        [NSXTProperty(IsRequired: false, Description: @"Fail count.")]
        public long? FailCount { get; set; }
        /// <summary>
        /// Number of packets in.
        /// </summary>
        [JsonProperty(PropertyName = "packets_in")]
        [NSXTProperty(IsRequired: false, Description: @"Number of packets in.")]
        public long? PacketsIn { get; set; }
        /// <summary>
        /// Number of bytes out.
        /// </summary>
        [JsonProperty(PropertyName = "bytes_out")]
        [NSXTProperty(IsRequired: false, Description: @"Number of bytes out.")]
        public long? BytesOut { get; set; }
        /// <summary>
        /// Number of bytes in.
        /// </summary>
        [JsonProperty(PropertyName = "bytes_in")]
        [NSXTProperty(IsRequired: false, Description: @"Number of bytes in.")]
        public long? BytesIn { get; set; }
    }
}