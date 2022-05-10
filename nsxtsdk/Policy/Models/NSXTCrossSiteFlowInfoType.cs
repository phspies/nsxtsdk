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
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTCrossSiteFlowInfoStatusEnumType? Status { get; set; }
        /// <summary>
        /// Timestamp of latency measurement
        /// </summary>
        [JsonProperty(PropertyName = "latency_measured_ts")]
        public long? LatencyMeasuredTs { get; set; }
        /// <summary>
        /// Site id of the destination
        /// </summary>
        [JsonProperty(PropertyName = "to_site_id")]
        public string? ToSiteId { get; set; }
        /// <summary>
        /// Latency from source to destination site in milli seconds
        /// </summary>
        [JsonProperty(PropertyName = "latency_millis")]
        public long? LatencyMillis { get; set; }
        /// <summary>
        /// Source site policy path
        /// </summary>
        [JsonProperty(PropertyName = "from_site_path")]
        public string? FromSitePath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "full_sync_info")]
        public NSXTFullSyncInfoType FullSyncInfo { get; set; }
        /// <summary>
        /// Site id of the source
        /// </summary>
        [JsonProperty(PropertyName = "from_site_id")]
        public string? FromSiteId { get; set; }
        /// <summary>
        /// Destination site policy path
        /// </summary>
        [JsonProperty(PropertyName = "to_site_path")]
        public string? ToSitePath { get; set; }
    }
}
