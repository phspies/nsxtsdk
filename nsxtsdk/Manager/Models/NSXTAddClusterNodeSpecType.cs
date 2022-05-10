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
    public class NSXTAddClusterNodeSpecType 
    {
        /// <summary>
        /// External identifier of the node
        /// </summary>
        [JsonProperty(PropertyName = "external_id")]
        public string? ExternalId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "controller_role_config")]
        public NSXTAddControllerNodeSpecType ControllerRoleConfig { get; set; }
        /// <summary>
        /// Display name for the node
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "mgr_role_config")]
        public NSXTAddManagementNodeSpecType MgrRoleConfig { get; set; }
    }
}
