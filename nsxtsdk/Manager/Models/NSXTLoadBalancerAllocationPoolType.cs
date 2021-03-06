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
    public class NSXTLoadBalancerAllocationPoolType : NSXTEdgeClusterMemberAllocationPoolType
    {
        /// <summary>
        /// To address varied customer performance and scalability requirements,
        /// different sizes for load balancer service are supported: SMALL, MEDIUM,
        /// LARGE and XLARGE, each with its own set of resource and performance.
        /// Specify size of load balancer service which you will bind to TIER1
        /// router.
        /// </summary>
        [JsonProperty(PropertyName = "allocation_size", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLoadBalancerAllocationPoolAllocationSizeEnumType AllocationSize { get; set; }
    }
}
