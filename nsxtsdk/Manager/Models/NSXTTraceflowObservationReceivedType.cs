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
    public class NSXTTraceflowObservationReceivedType : NSXTTraceflowObservationType
    {
        /// <summary>
        /// The virtual tunnel endpoint label
        /// </summary>
        [JsonProperty(PropertyName = "vtep_label")]
        public long? VtepLabel { get; set; }
        /// <summary>
        /// The name of the uplink the traceflow packet is received on
        /// </summary>
        [JsonProperty(PropertyName = "uplink_name")]
        public string? UplinkName { get; set; }
        /// <summary>
        /// IP address of the destination end of the tunnel
        /// </summary>
        [JsonProperty(PropertyName = "local_ip_address")]
        public string? LocalIpAddress { get; set; }
        /// <summary>
        /// IP address of the source end of the tunnel
        /// </summary>
        [JsonProperty(PropertyName = "remote_ip_address")]
        public string? RemoteIpAddress { get; set; }
    }
}
