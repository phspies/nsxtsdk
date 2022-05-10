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
    public class NSXTInventoryConfigType 
    {
        /// <summary>
        /// Soft limit on number of compute managers, which can be added, beyond which,
        /// addition of compute managers will result in warning getting logged
        /// </summary>
        [JsonProperty(PropertyName = "compute_managers_soft_limit", Required = Required.AllowNull)]
        public int ComputeManagersSoftLimit { get; set; }
    }
}
