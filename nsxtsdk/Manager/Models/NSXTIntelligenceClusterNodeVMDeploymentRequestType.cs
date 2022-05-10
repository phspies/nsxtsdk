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
    /// Contains the deployment information for a NSX-Intelligence node VM.
    /// </summary>
    [NSXTProperty(Description: @"Contains the deployment information for a NSX-Intelligence node VM.")]
    public class NSXTIntelligenceClusterNodeVMDeploymentRequestType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "deployment_config", Required = Required.AllowNull)]
        public NSXTIntelligenceClusterNodeVMDeploymentConfigType DeploymentConfig { get; set; }
        /// <summary>
        /// ID of the VM maintained internally.
        /// Note: This is automatically generated and cannot be modified.
        /// </summary>
        [JsonProperty(PropertyName = "vm_id")]
        public string? VmId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "user_settings")]
        public NSXTNodeUserSettingsType UserSettings { get; set; }
        /// <summary>
        /// Specifies the desired "size" of the VM
        /// </summary>
        [JsonProperty(PropertyName = "form_factor")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIntelligenceClusterNodeVmdeploymentRequestFormFactorEnumType? FormFactor { get; set; }
    }
}
