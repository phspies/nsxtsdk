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
    /// Traffic statistics for IPSec VPN Ike session.
        /// Note - Not supported in this release.
    /// </summary>
    [NSXTProperty(Description: @"Traffic statistics for IPSec VPN Ike session.Note - Not supported in this release.")]
    public class NSXTIPSecVpnIkeTrafficStatisticsType 
    {
        /// <summary>
        /// Number of packets out.
        /// </summary>
        [JsonProperty(PropertyName = "packets_out")]
        public long? PacketsOut { get; set; }
        /// <summary>
        /// Fail count.
        /// </summary>
        [JsonProperty(PropertyName = "fail_count")]
        public long? FailCount { get; set; }
        /// <summary>
        /// Number of packets in.
        /// </summary>
        [JsonProperty(PropertyName = "packets_in")]
        public long? PacketsIn { get; set; }
        /// <summary>
        /// Number of bytes out.
        /// </summary>
        [JsonProperty(PropertyName = "bytes_out")]
        public long? BytesOut { get; set; }
        /// <summary>
        /// Number of bytes in.
        /// </summary>
        [JsonProperty(PropertyName = "bytes_in")]
        public long? BytesIn { get; set; }
    }
}
