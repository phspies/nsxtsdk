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
    public class NSXTEdgeNodeDeploymentConfigType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "node_user_settings", Required = Required.AllowNull)]
        public NSXTNodeUserSettingsType NodeUserSettings { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "vm_deployment_config", Required = Required.AllowNull)]
        public NSXTDeploymentConfigType VmDeploymentConfig { get; set; }
        /// <summary>
        /// Supported edge form factor.
        /// </summary>
        [JsonProperty(PropertyName = "form_factor")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTEdgeNodeDeploymentConfigFormFactorEnumType? FormFactor { get; set; }
    }
}
