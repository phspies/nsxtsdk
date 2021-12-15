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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLiveTraceActionConfigType 
    {
        /// <summary>
        /// The trace action config
        /// </summary>
        [JsonProperty(PropertyName = "trace_config")]
        [NSXTProperty(IsRequired: false, Description: @"The trace action config")]
        public NSXTTraceActionConfigType TraceConfig { get; set; }
        /// <summary>
        /// The packet capture action config
        /// </summary>
        [JsonProperty(PropertyName = "pktcap_config")]
        [NSXTProperty(IsRequired: false, Description: @"The packet capture action config")]
        public NSXTPktcapActionConfigType PktcapConfig { get; set; }
        /// <summary>
        /// The count action config
        /// </summary>
        [JsonProperty(PropertyName = "count_config")]
        [NSXTProperty(IsRequired: false, Description: @"The count action config")]
        public NSXTCountActionConfigType CountConfig { get; set; }
    }
}
