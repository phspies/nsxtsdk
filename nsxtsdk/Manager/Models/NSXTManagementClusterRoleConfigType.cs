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
    public class NSXTManagementClusterRoleConfigType : NSXTClusterRoleConfigType
    {
        public NSXTManagementClusterRoleConfigType()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_cluster_listen_addr")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTServiceEndpointType MgmtClusterListenAddr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "mpa_msg_client_info")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTMsgClientInfoType MpaMsgClientInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "api_listen_addr")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTServiceEndpointType ApiListenAddr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "appliance_connection_info")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTServiceEndpointType ApplianceConnectionInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_plane_listen_addr")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTServiceEndpointType MgmtPlaneListenAddr { get; set; }
    }
}
