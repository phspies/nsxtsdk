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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Contains info used to configure the VM on deployment.
    /// </summary>
    [NSXTProperty(Description: @"Contains info used to configure the VM on deployment.")]
    public class NSXTALBControllerNodeVMDeploymentConfigType 
    {
        public NSXTALBControllerNodeVMDeploymentConfigType()
        {
        }
        /// <summary>
        /// Specifies the config for the platform through which to deploy the VM.
        /// </summary>
        [JsonProperty(PropertyName = "placement_type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Specifies the config for the platform through which to deploy the VM.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTAlbcontrollerNodeVmdeploymentConfigPlacementTypeEnumType PlacementType { get; set; }
    }
}
