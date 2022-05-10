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
    public class NSXTCapacityThresholdListType : NSXTManagedResourceType
    {
        /// <summary>
        /// List of capacity thresholds for NSX Objects
        /// </summary>
        [JsonProperty(PropertyName = "capacity_thresholds", Required = Required.AllowNull)]
        public IList<NSXTCapacityThresholdType> CapacityThresholds { get; set; }
    }
}
