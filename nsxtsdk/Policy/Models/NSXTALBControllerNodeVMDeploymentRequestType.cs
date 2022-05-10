using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTALBControllerNodeVMDeploymentRequestType : NSXTManagedResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "deployment_config", Required = Required.AllowNull)]
        public NSXTALBControllerNodeVMDeploymentConfigType DeploymentConfig { get; set; }
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
        public NSXTALBControllerNodeUserSettingsType UserSettings { get; set; }
        /// <summary>
        /// Specifies the desired "size" of the VM
        /// </summary>
        [JsonProperty(PropertyName = "form_factor")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbcontrollerNodeVmdeploymentRequestFormFactorEnumType? FormFactor { get; set; }
    }
}
