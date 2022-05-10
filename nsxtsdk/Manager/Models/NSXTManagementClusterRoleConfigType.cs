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
    public class NSXTManagementClusterRoleConfigType : NSXTClusterRoleConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_cluster_listen_addr")]
        public NSXTServiceEndpointType MgmtClusterListenAddr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "mpa_msg_client_info")]
        public NSXTMsgClientInfoType MpaMsgClientInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "api_listen_addr")]
        public NSXTServiceEndpointType ApiListenAddr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "appliance_connection_info")]
        public NSXTServiceEndpointType ApplianceConnectionInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_plane_listen_addr")]
        public NSXTServiceEndpointType MgmtPlaneListenAddr { get; set; }
    }
}
