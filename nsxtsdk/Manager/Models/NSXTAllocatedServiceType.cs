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
    public class NSXTAllocatedServiceType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "service_reference")]
        public NSXTResourceReferenceType ServiceReference { get; set; }
        /// <summary>
        /// Represents the active or the standby state of the service.
        /// </summary>
        [JsonProperty(PropertyName = "high_availability_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAllocatedServiceHighAvailabilityStatusEnumType? HighAvailabilityStatus { get; set; }
        /// <summary>
        /// Additional properties of a service, say the sub_pool_size and
        /// sub_pool_type for a LoadBalancer.
        /// </summary>
        [JsonProperty(PropertyName = "allocation_details")]
        public IList<NSXTKeyValuePairType> AllocationDetails { get; set; }
    }
}
