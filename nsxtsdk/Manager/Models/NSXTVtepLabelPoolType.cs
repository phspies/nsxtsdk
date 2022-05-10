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
    public class NSXTVtepLabelPoolType : NSXTManagedResourceType
    {
        /// <summary>
        /// Array of ranges for virtual tunnel endpoint labels
        /// </summary>
        [JsonProperty(PropertyName = "ranges", Required = Required.AllowNull)]
        public IList<NSXTVtepLabelRangeType> Ranges { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "pool_usage")]
        public NSXTVtepLabelPoolUsageType PoolUsage { get; set; }
    }
}
