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
    public class NSXTControllerClusterRoleConfigType : NSXTClusterRoleConfigType
    {
        public NSXTControllerClusterRoleConfigType()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "mpa_msg_client_info")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTMsgClientInfoType MpaMsgClientInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "host_msg_client_info")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTMsgClientInfoType HostMsgClientInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "control_plane_listen_addr")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTServiceEndpointType ControlPlaneListenAddr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "control_cluster_listen_addr")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTServiceEndpointType ControlClusterListenAddr { get; set; }
    }
}
