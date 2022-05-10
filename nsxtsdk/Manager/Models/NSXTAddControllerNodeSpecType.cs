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
    public class NSXTAddControllerNodeSpecType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "mpa_msg_client_info", Required = Required.AllowNull)]
        public NSXTMsgClientInfoType MpaMsgClientInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "host_msg_client_info", Required = Required.AllowNull)]
        public NSXTMsgClientInfoType HostMsgClientInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "clustering_params")]
        public NSXTClusteringInfoType ClusteringParams { get; set; }
        /// <summary>
        /// Only use this if an id for the node already exists with MP. If not specified, then the node_id will be set to a random
        /// id.
        /// </summary>
        [JsonProperty(PropertyName = "node_id")]
        public string? NodeId { get; set; }
        /// <summary>
        /// Deprecated. Do not supply a value for this property.
        /// </summary>
        [JsonProperty(PropertyName = "control_plane_server_certificate")]
        public string? ControlPlaneServerCertificate { get; set; }
        /// <summary>
        /// must be set to AddControllerNodeSpec
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAddControllerNodeSpecTypeEnumType Type { get; set; }
    }
}
