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
    public class NSXTEdgeNodeDeploymentConfigType 
    {
        public NSXTEdgeNodeDeploymentConfigType()
        {
            FormFactor = test
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "node_user_settings", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTNodeUserSettingsType NodeUserSettings { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "vm_deployment_config", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTDeploymentConfigType VmDeploymentConfig { get; set; }
        /// <summary>
        /// Supported edge form factor.
        /// </summary>
        [JsonProperty(PropertyName = "form_factor")]
        [NSXTProperty(IsRequired: false, Description: @"Supported edge form factor.")]
        public NSXTEdgeNodeDeploymentConfigFormFactorEnumType? FormFactor { get; set; }
    }
}
