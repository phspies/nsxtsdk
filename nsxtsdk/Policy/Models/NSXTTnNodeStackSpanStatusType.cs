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
    /// List all the TNs spaned in L3PortMirrorSession mirror stack health status.
    /// </summary>
    [NSXTProperty(Description: @"List all the TNs spaned in L3PortMirrorSession mirror stack health status.")]
    public class NSXTTnNodeStackSpanStatusType 
    {
        /// <summary>
        /// For L3PortMirrorSession configured mirror stack, show the TN node friendly
        /// name which spaned in L3PortMirrorSession.
        /// </summary>
        [JsonProperty(PropertyName = "tn_node_name", Required = Required.AllowNull)]
        public string TnNodeName { get; set; }
        /// <summary>
        /// Show the vmknic health status, if the vmknic has been bouned to mirror
        /// stack, it will show SUCCESS or it will show FAILED.
        /// </summary>
        [JsonProperty(PropertyName = "vmknic_status", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTnNodeStackSpanStatusVmknicStatusEnumType VmknicStatus { get; set; }
        /// <summary>
        /// Show the dedicated mirror stack health status, if the TN node has the mirror
        /// stack, it will show SUCCESS or it will show FAILED.
        /// </summary>
        [JsonProperty(PropertyName = "dedicated_stack_status", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTnNodeStackSpanStatusDedicatedStackStatusEnumType DedicatedStackStatus { get; set; }
        /// <summary>
        /// For L3PortMirrorSession configured mirror stack, show the TN node UUID
        /// which spaned in L3PortMirrorSession.
        /// </summary>
        [JsonProperty(PropertyName = "tn_node_id")]
        public string? TnNodeId { get; set; }
        /// <summary>
        /// Give the detail info for mirror stack and vmknic health status.
        /// If the stack or vmknic is FAILED, detail info will tell user reason
        /// why the stauts is FAILED. So that user can correct their configuration.
        /// </summary>
        [JsonProperty(PropertyName = "detail", Required = Required.AllowNull)]
        public string Detail { get; set; }
        /// <summary>
        /// TN miror stack status will be updated periodically, this item
        /// indicates the lastest timestamp of TN node stack status is updated.
        /// </summary>
        [JsonProperty(PropertyName = "last_updated_time", Required = Required.AllowNull)]
        public long LastUpdatedTime { get; set; }
    }
}
