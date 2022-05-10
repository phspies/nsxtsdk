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
    public class NSXTByodServiceInstanceType : NSXTBaseServiceInstanceType
    {
        /// <summary>
        /// Deployment mode specifies where the partner appliance will be deployed in HA or non-HA i.e standalone mode.
        /// </summary>
        [JsonProperty(PropertyName = "deployment_mode", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTByodServiceInstanceDeploymentModeEnumType DeploymentMode { get; set; }
    }
}
