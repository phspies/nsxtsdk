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
    /// Contains the deployment information for a cluster node VM soon to be
        /// deployed or already deployed by the Manager
    /// </summary>
    [NSXTProperty(Description: @"Contains the deployment information for a cluster node VM soon to bedeployed or already deployed by the Manager")]
    public class NSXTClusterNodeVMDeploymentRequestType 
    {
        public NSXTClusterNodeVMDeploymentRequestType()
        {
            FormFactor = test
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "deployment_config", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTClusterNodeVMDeploymentConfigType DeploymentConfig { get; set; }
        /// <summary>
        /// ID of the VM maintained internally and used to recognize it.
        /// Note: This is automatically generated and cannot be modified.
        /// </summary>
        [JsonProperty(PropertyName = "vm_id")]
        [NSXTProperty(IsRequired: false, Description: @"ID of the VM maintained internally and used to recognize it.Note: This is automatically generated and cannot be modified.")]
        public string? VmId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "user_settings")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTNodeUserSettingsType UserSettings { get; set; }
        /// <summary>
        /// List of cluster node role (or roles) which the VM should take on.
        /// They specify what type (or types) of cluster node which the new VM
        /// should act as.
        /// Currently both CONTROLLER and MANAGER must be provided, since this
        /// permutation is the only one supported now.
        /// </summary>
        [JsonProperty(PropertyName = "roles", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"List of cluster node role (or roles) which the VM should take on.They specify what type (or types) of cluster node which the new VMshould act as.Currently both CONTROLLER and MANAGER must be provided, since thispermutation is the only one supported now.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<string> Roles { get; set; }
        /// <summary>
        /// Specifies the desired "size" of the VM
        /// </summary>
        [JsonProperty(PropertyName = "form_factor")]
        [NSXTProperty(IsRequired: false, Description: @"Specifies the desired &quot;size&quot; of the VM")]
        public NSXTClusterNodeVmdeploymentRequestFormFactorEnumType? FormFactor { get; set; }
    }
}
