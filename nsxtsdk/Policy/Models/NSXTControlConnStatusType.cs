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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTControlConnStatusType 
    {
        /// <summary>
        /// Status of the control Node for e.g  UP, DOWN.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTControlConnStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// IP address of the control Node.
        /// </summary>
        [JsonProperty(PropertyName = "control_node_ip")]
        public string? ControlNodeIp { get; set; }
        /// <summary>
        /// Failure status of the control Node for e.g CONNECTION_REFUSED,INCOMPLETE_HOST_CERT.
        /// </summary>
        [JsonProperty(PropertyName = "failure_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTControlConnStatusFailureStatusEnumType? FailureStatus { get; set; }
    }
}
