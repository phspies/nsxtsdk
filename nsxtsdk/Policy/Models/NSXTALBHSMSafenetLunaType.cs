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
    /// Advanced load balancer HSMSafenetLuna object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HSMSafenetLuna object")]
    public class NSXTALBHSMSafenetLunaType 
    {
        /// <summary>
        /// Node specific information.
        /// </summary>
        [JsonProperty(PropertyName = "node_info")]
        public IList<NSXTALBHSMSafenetClientInfoType> NodeInfo { get; set; }
        /// <summary>
        /// Set to indicate HA across more than one servers.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "is_ha", Required = Required.AllowNull)]
        public bool IsHa { get; set; }
        /// <summary>
        /// Generated File - server.pem.
        /// </summary>
        [JsonProperty(PropertyName = "server_pem")]
        public string? ServerPem { get; set; }
        /// <summary>
        /// If enabled, dedicated network is used to communicate with
        /// HSM,else, the management network is used.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "use_dedicated_network")]
        public bool? UseDedicatedNetwork { get; set; }
        /// <summary>
        /// Group Number of generated HA Group.
        /// </summary>
        [JsonProperty(PropertyName = "ha_group_num")]
        public long? HaGroupNum { get; set; }
        /// <summary>
        /// SafeNet/Gemalto HSM Servers used for crypto operations.
        /// </summary>
        [JsonProperty(PropertyName = "server")]
        public IList<NSXTALBHSMSafenetLunaServerType> Server { get; set; }
    }
}
