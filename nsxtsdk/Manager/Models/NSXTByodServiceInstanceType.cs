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
    public class NSXTByodServiceInstanceType : NSXTBaseServiceInstanceType
    {
        public NSXTByodServiceInstanceType()
        {
            DeploymentMode = test
        }
        /// <summary>
        /// Deployment mode specifies where the partner appliance will be deployed in HA or non-HA i.e standalone mode.
        /// </summary>
        [JsonProperty(PropertyName = "deployment_mode", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Deployment mode specifies where the partner appliance will be deployed in HA or non-HA i.e standalone mode.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTByodServiceInstanceDeploymentModeEnumType DeploymentMode { get; set; }
    }
}
