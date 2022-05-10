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
    /// Contains info used to configure the VM on deployment
    /// </summary>
    [NSXTProperty(Description: @"Contains info used to configure the VM on deployment")]
    public class NSXTClusterNodeVMDeploymentConfigType 
    {
        /// <summary>
        /// Specifies the config for the platform through which to deploy the VM
        /// </summary>
        [JsonProperty(PropertyName = "placement_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTClusterNodeVmdeploymentConfigPlacementTypeEnumType PlacementType { get; set; }
    }
}
