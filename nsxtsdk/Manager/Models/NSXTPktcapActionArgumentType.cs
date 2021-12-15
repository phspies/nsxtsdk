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
    public class NSXTPktcapActionArgumentType 
    {
        /// <summary>
        /// Type of packet capture
        /// </summary>
        [JsonProperty(PropertyName = "pktcap_type")]
        [NSXTProperty(IsRequired: false, Description: @"Type of packet capture")]
        public NSXTPktcapActionArgumentPktcapTypeEnumType? PktcapType { get; set; }
        /// <summary>
        /// Please keep this aligned with trace_config, if you
        /// specify dest_lport at trace_config.
        /// </summary>
        [JsonProperty(PropertyName = "dest_lport")]
        [NSXTProperty(IsRequired: false, Description: @"Please keep this aligned with trace_config, if youspecify dest_lport at trace_config.")]
        public string? DestLport { get; set; }
        /// <summary>
        /// Please keep this aligned with trace_config, if you
        /// specify dest_lport at trace_config.
        /// </summary>
        [JsonProperty(PropertyName = "reverse_filter")]
        [NSXTProperty(IsRequired: false, Description: @"Please keep this aligned with trace_config, if youspecify dest_lport at trace_config.")]
        public NSXTLiveTraceFilterDataType ReverseFilter { get; set; }
    }
}
