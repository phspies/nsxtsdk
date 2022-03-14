// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Describes the capacity and current usage of virtual servers, pools, pool
        /// members for the given load balancer service.
    /// </summary>
    [NSXTProperty(Description: @"Describes the capacity and current usage of virtual servers, pools, poolmembers for the given load balancer service.")]
    public class NSXTLbServiceUsageType 
    {
        /// <summary>
        /// Pool capacity means maximum number of pools which could be configured
        /// in the given load balancer service.
        /// </summary>
        public long? PoolCapacity { get; set; }
        /// <summary>
        /// The size of load balancer service
        /// </summary>
        public NSXTLbServiceUsageServiceSizeEnumType? ServiceSize { get; set; }
        /// <summary>
        /// The severity calculation is based on the largest usage percentage from
        /// virtual servers, pools, pool members and rules for one load balancer
        /// service.
        /// </summary>
        public NSXTLbServiceUsageSeverityEnumType? Severity { get; set; }
        /// <summary>
        /// Pool member capacity means maximum number of pool members which could
        /// be configured in the given load balancer service.
        /// </summary>
        public long? PoolMemberCapacity { get; set; }
        /// <summary>
        /// The current number of virtual servers which have been configured in the
        /// given load balancer service.
        /// </summary>
        public long? CurrentVirtualServerCount { get; set; }
        /// <summary>
        /// The usage percentage is the largest usage percentage from virtual
        /// servers, pools and pool members for the load balancer service. If the
        /// property relax_scale_validation is set as true for LbService, it is
        /// possible that the value is larger than 100.0. For example, if SMALL LBS
        /// is deployed on MEDIUM edge node and configured with MEDIUM LBS virtual
        /// server scale number, LBS usage percentage is shown larger than 100.0.
        /// </summary>
        public double? UsagePercentage { get; set; }
        /// <summary>
        /// UUID of load balancer service
        /// </summary>
        public string? ServiceId { get; set; }
        /// <summary>
        /// The current number of pools which have been configured in the given load
        /// balancer service.
        /// </summary>
        public long? CurrentPoolCount { get; set; }
        /// <summary>
        /// Virtual server capacity means maximum number of virtual servers which
        /// could be configured in the given load balancer service.
        /// </summary>
        public long? VirtualServerCapacity { get; set; }
        /// <summary>
        /// The current number of pool members which have been configured in the
        /// given load balancer service.
        /// </summary>
        public long? CurrentPoolMemberCount { get; set; }
    }
}
