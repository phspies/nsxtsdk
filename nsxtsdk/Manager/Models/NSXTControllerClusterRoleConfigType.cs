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
    public class NSXTControllerClusterRoleConfigType : NSXTClusterRoleConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "mpa_msg_client_info")]
        public NSXTMsgClientInfoType MpaMsgClientInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "host_msg_client_info")]
        public NSXTMsgClientInfoType HostMsgClientInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "control_plane_listen_addr")]
        public NSXTServiceEndpointType ControlPlaneListenAddr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "control_cluster_listen_addr")]
        public NSXTServiceEndpointType ControlClusterListenAddr { get; set; }
    }
}
