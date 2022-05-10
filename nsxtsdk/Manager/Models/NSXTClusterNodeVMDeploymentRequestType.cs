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
    /// Contains the deployment information for a cluster node VM soon to be
        /// deployed or already deployed by the Manager
    /// </summary>
    [NSXTProperty(Description: @"Contains the deployment information for a cluster node VM soon to bedeployed or already deployed by the Manager")]
    public class NSXTClusterNodeVMDeploymentRequestType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "deployment_config", Required = Required.AllowNull)]
        public NSXTClusterNodeVMDeploymentConfigType DeploymentConfig { get; set; }
        /// <summary>
        /// ID of the VM maintained internally and used to recognize it.
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
        /// List of cluster node role (or roles) which the VM should take on.
        /// They specify what type (or types) of cluster node which the new VM
        /// should act as.
        /// Currently both CONTROLLER and MANAGER must be provided, since this
        /// permutation is the only one supported now.
        /// </summary>
        [JsonProperty(PropertyName = "roles", Required = Required.AllowNull)]
        public IList<string> Roles { get; set; }
        /// <summary>
        /// Specifies the desired "size" of the VM
        /// </summary>
        [JsonProperty(PropertyName = "form_factor")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTClusterNodeVmdeploymentRequestFormFactorEnumType? FormFactor { get; set; }
    }
}
