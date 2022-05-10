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
    /// Gateway QoS profile configuration
    /// </summary>
    [NSXTProperty(Description: @"Gateway QoS profile configuration")]
    public class NSXTGatewayQosProfileConfigType 
    {
        /// <summary>
        /// Policy path to gateway QoS profile in ingress direction.
        /// </summary>
        [JsonProperty(PropertyName = "ingress_qos_profile_path")]
        public string? IngressQosProfilePath { get; set; }
        /// <summary>
        /// Policy path to gateway QoS profile in egress direction.
        /// </summary>
        [JsonProperty(PropertyName = "egress_qos_profile_path")]
        public string? EgressQosProfilePath { get; set; }
    }
}
