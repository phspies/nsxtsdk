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
    public class NSXTEdgeClusterMemberAllocationPoolType 
    {
        /// <summary>
        /// Types of logical router allocation pool based on services
        /// </summary>
        [JsonProperty(PropertyName = "allocation_pool_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTEdgeClusterMemberAllocationPoolAllocationPoolTypeEnumType AllocationPoolType { get; set; }
    }
}
