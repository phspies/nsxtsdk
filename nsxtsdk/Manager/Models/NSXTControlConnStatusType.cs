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
    public class NSXTControlConnStatusType 
    {
        /// <summary>
        /// Status of the control Node for e.g  UP, DOWN.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [NSXTProperty(IsRequired: false, Description: @"Status of the control Node for e.g  UP, DOWN.")]
        public NSXTControlConnStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// IP address of the control Node.
        /// </summary>
        [JsonProperty(PropertyName = "control_node_ip")]
        [NSXTProperty(IsRequired: false, Description: @"IP address of the control Node.")]
        public string? ControlNodeIp { get; set; }
        /// <summary>
        /// Failure status of the control Node for e.g CONNECTION_REFUSED,INCOMPLETE_HOST_CERT.
        /// </summary>
        [JsonProperty(PropertyName = "failure_status")]
        [NSXTProperty(IsRequired: false, Description: @"Failure status of the control Node for e.g CONNECTION_REFUSED,INCOMPLETE_HOST_CERT.")]
        public NSXTControlConnStatusFailureStatusEnumType? FailureStatus { get; set; }
    }
}