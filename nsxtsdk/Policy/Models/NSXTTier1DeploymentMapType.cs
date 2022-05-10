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
    public class NSXTTier1DeploymentMapType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Path of enforcement point on which Tier-1 shall be deployed.
        /// </summary>
        [JsonProperty(PropertyName = "enforcement_point", Required = Required.AllowNull)]
        public string EnforcementPoint { get; set; }
    }
}
