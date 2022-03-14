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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Represents details of the config flow between sites.
        /// Federation has the following flows
        /// - Global Manager to Local Manager (GM -> LM)
        /// - Local Manager to Glocal Manager (LM -> GM)
        /// - Global Manager Active to Glocal Manager Standby (GM -> GM)
        /// - Local Manager to Local Manager (LM -> LM)
    /// </summary>
    [NSXTProperty(Description: @"Represents details of the config flow between sites.Federation has the following flows- Global Manager to Local Manager (GM -&gt; LM)- Local Manager to Glocal Manager (LM -&gt; GM)- Global Manager Active to Glocal Manager Standby (GM -&gt; GM)- Local Manager to Local Manager (LM -&gt; LM)")]
    public class NSXTCrossSiteFlowInfoType 
    {
        /// <summary>
        /// Overall status of the flow
        /// </summary>
        public NSXTCrossSiteFlowInfoStatusEnumType? Status { get; set; }
        /// <summary>
        /// Timestamp of latency measurement
        /// </summary>
        public long? LatencyMeasuredTs { get; set; }
        /// <summary>
        /// Site id of the destination
        /// </summary>
        public string? ToSiteId { get; set; }
        /// <summary>
        /// Latency from source to destination site in milli seconds
        /// </summary>
        public long? LatencyMillis { get; set; }
        /// <summary>
        /// Source site policy path
        /// </summary>
        public string? FromSitePath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NSXTFullSyncInfoType FullSyncInfo { get; set; }
        /// <summary>
        /// Site id of the source
        /// </summary>
        public string? FromSiteId { get; set; }
        /// <summary>
        /// Destination site policy path
        /// </summary>
        public string? ToSitePath { get; set; }
    }
}
