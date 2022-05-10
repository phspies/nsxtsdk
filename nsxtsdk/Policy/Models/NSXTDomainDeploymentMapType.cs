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
    public class NSXTDomainDeploymentMapType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Path of enforcement point on which domain shall be enforced.
        /// </summary>
        [JsonProperty(PropertyName = "enforcement_point_path", Required = Required.AllowNull)]
        public string EnforcementPointPath { get; set; }
    }
}
