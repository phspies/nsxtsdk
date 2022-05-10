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
    public class NSXTClusterNodeConfigType : NSXTManagedResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "manager_role")]
        public NSXTManagementClusterRoleConfigType ManagerRole { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "controller_role")]
        public NSXTControllerClusterRoleConfigType ControllerRole { get; set; }
        /// <summary>
        /// Internal identifier provided by the node
        /// </summary>
        [JsonProperty(PropertyName = "external_id")]
        public string? ExternalId { get; set; }
        /// <summary>
        /// The IP and port for the appliance management API service on this node
        /// </summary>
        [JsonProperty(PropertyName = "appliance_mgmt_listen_addr")]
        public string? ApplianceMgmtListenAddr { get; set; }
    }
}
