// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

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
        public long? PacketsOut { get; set; }
        /// <summary>
        /// Fail count.
        /// </summary>
        public long? FailCount { get; set; }
        /// <summary>
        /// Number of packets in.
        /// </summary>
        public long? PacketsIn { get; set; }
        /// <summary>
        /// Number of bytes out.
        /// </summary>
        public long? BytesOut { get; set; }
        /// <summary>
        /// Number of bytes in.
        /// </summary>
        public long? BytesIn { get; set; }
    }
}
