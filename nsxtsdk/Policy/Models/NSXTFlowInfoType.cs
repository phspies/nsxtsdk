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
    /// Provides details of config flow in federation
        /// Federation has the following flows
        /// - Global Manager to Local Manager (GM -> LM)
        /// - Local Manager to Glocal Manager (LM -> GM)
        /// - Global Manager Active to Glocal Manager Standby (GM -> GM)
        /// - Local Manager to Local Manager (LM -> LM)
    /// </summary>
    [NSXTProperty(Description: @"Provides details of config flow in federationFederation has the following flows- Global Manager to Local Manager (GM -&gt; LM)- Local Manager to Glocal Manager (LM -&gt; GM)- Global Manager Active to Glocal Manager Standby (GM -&gt; GM)- Local Manager to Local Manager (LM -&gt; LM)")]
    public class NSXTFlowInfoType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "cross_site_flow_info")]
        public NSXTCrossSiteFlowInfoType CrossSiteFlowInfo { get; set; }
        /// <summary>
        /// Every flow will have transmitter and receiver queues.
        /// </summary>
        [JsonProperty(PropertyName = "queue_infos")]
        public IList<NSXTFederationQueueInfoType> QueueInfos { get; set; }
        /// <summary>
        /// System identifier for the flow
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// Flow identifier
        /// </summary>
        [JsonProperty(PropertyName = "flow_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTFlowInfoFlowTypeEnumType? FlowType { get; set; }
    }
}
