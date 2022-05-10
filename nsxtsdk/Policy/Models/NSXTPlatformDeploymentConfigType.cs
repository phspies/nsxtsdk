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
    public class NSXTPlatformDeploymentConfigType : NSXTCloudNativeDeploymentConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "service_config")]
        public NSXTAdvanceServiceConfigType ServiceConfig { get; set; }
        /// <summary>
        /// From factor in use.
        /// </summary>
        [JsonProperty(PropertyName = "form_factor")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPlatformDeploymentConfigFormFactorEnumType? FormFactor { get; set; }
    }
}
