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
    /// Advanced load balancer HSMThalesNetHsm object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HSMThalesNetHsm object")]
    public class NSXTALBHSMThalesNetHsmType 
    {
        /// <summary>
        /// Priority class of the nethsm in an high availability setup.
        /// 1 is the highest priority and 100 is the lowest priority.
        /// Allowed values are 1-100.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 100.
        /// </summary>
        [JsonProperty(PropertyName = "priority", Required = Required.AllowNull)]
        public long Priority { get; set; }
        /// <summary>
        /// Hash of the key that netHSM device uses to authenticate
        /// itself.
        /// Use Thales anonkneti utility to find the netHSM keyhash.
        /// </summary>
        [JsonProperty(PropertyName = "keyhash", Required = Required.AllowNull)]
        public string Keyhash { get; set; }
        /// <summary>
        /// Local module id of the netHSM device.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "module_id")]
        public long? ModuleId { get; set; }
        /// <summary>
        /// Electronic serial number of the netHSM device.
        /// Use Thales anonkneti utility to find the netHSM ESN.
        /// </summary>
        [JsonProperty(PropertyName = "esn", Required = Required.AllowNull)]
        public string Esn { get; set; }
        /// <summary>
        /// Port at which the netHSM device accepts the connection.
        /// Allowed values are 1-65535.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 9004.
        /// </summary>
        [JsonProperty(PropertyName = "remote_port")]
        public long? RemotePort { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "remote_ip", Required = Required.AllowNull)]
        public NSXTALBIpAddrType RemoteIp { get; set; }
    }
}
