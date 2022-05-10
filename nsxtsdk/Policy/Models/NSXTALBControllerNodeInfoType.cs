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
    /// Advanced Load Balancer controller node information like node IP and node name.
    /// </summary>
    [NSXTProperty(Description: @"Advanced Load Balancer controller node information like node IP and node name.")]
    public class NSXTALBControllerNodeInfoType 
    {
        /// <summary>
        /// Advanced Load Balancer controller node start time in its local timezone.
        /// </summary>
        [JsonProperty(PropertyName = "node_start_time")]
        public long? NodeStartTime { get; set; }
        /// <summary>
        /// Advanced Load Balancer controller node IP configuration is static or DHCP.
        /// </summary>
        [JsonProperty(PropertyName = "is_dhcp")]
        public bool? IsDhcp { get; set; }
        /// <summary>
        /// Advanced Load Balancer controller node current state in the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "node_state")]
        public string? NodeState { get; set; }
        /// <summary>
        /// Advanced Load Balancer controller node IP.
        /// </summary>
        [JsonProperty(PropertyName = "node_ip")]
        public string? NodeIp { get; set; }
        /// <summary>
        /// ID of the VM maintained internally.
        /// Note: This is automatically generated and cannot be modified.
        /// </summary>
        [JsonProperty(PropertyName = "vm_id")]
        public string? VmId { get; set; }
        /// <summary>
        /// Advanced Load Balancer controller node role in cluster.
        /// </summary>
        [JsonProperty(PropertyName = "node_role")]
        public string? NodeRole { get; set; }
        /// <summary>
        /// Advanced Load Balancer controller node name.
        /// </summary>
        [JsonProperty(PropertyName = "node_name")]
        public string? NodeName { get; set; }
    }
}
