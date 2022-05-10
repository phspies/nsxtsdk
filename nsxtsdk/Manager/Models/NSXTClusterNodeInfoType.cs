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
    public class NSXTClusterNodeInfoType 
    {
        /// <summary>
        /// Node clustering status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTClusterNodeInfoStatusEnumType? Status { get; set; }
        /// <summary>
        /// Messaging client of all entities
        /// </summary>
        [JsonProperty(PropertyName = "msg_clients")]
        public IList<NSXTNodeMessagingClientInfoType> MsgClients { get; set; }
        /// <summary>
        /// Unique identifier of this node
        /// </summary>
        [JsonProperty(PropertyName = "node_uuid")]
        public string? NodeUuid { get; set; }
        /// <summary>
        /// The display name of this node
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// Service endpoint of all entities
        /// </summary>
        [JsonProperty(PropertyName = "entities")]
        public IList<NSXTNodeEntityInfoType> Entities { get; set; }
        /// <summary>
        /// Certificate and thumbprint of all entities
        /// </summary>
        [JsonProperty(PropertyName = "certificates")]
        public IList<NSXTNodeCertificateInfoType> Certificates { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "api_listen_addr")]
        public NSXTServiceEndpointType ApiListenAddr { get; set; }
        /// <summary>
        /// The fqdn of this node
        /// </summary>
        [JsonProperty(PropertyName = "fqdn")]
        public string? Fqdn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "appliance_connection_info")]
        public NSXTServiceEndpointType ApplianceConnectionInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "control_plane_listen_addr")]
        public NSXTServiceEndpointType ControlPlaneListenAddr { get; set; }
    }
}
