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
    public class NSXTChildTier0DeploymentMapType : NSXTChildPolicyConfigResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "Tier0DeploymentMap", Required = Required.AllowNull)]
        public NSXTTier0DeploymentMapType Tier0DeploymentMap { get; set; }
    }
}
