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
    /// CPU and Memory resource configuration is defined per Edge VM
        /// form factor.
        /// These resources are reserved 100 percent by default with Normal VM
        /// importance. Resource reservation tuning provides a means to optimize
        /// resource utilization and workaround hard resource limits.
        /// This solution should be used as a temporary workaround. It is recommended
        /// to add more resources to the compute cluster and change the reservation
        /// back to 100 percent for optimal performance.
    /// </summary>
    [NSXTProperty(Description: @"CPU and Memory resource configuration is defined per Edge VMform factor.These resources are reserved 100 percent by default with Normal VMimportance. Resource reservation tuning provides a means to optimizeresource utilization and workaround hard resource limits.This solution should be used as a temporary workaround. It is recommendedto add more resources to the compute cluster and change the reservationback to 100 percent for optimal performance.")]
    public class NSXTReservationInfoType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "cpu_reservation")]
        public NSXTCPUReservationType CpuReservation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "memory_reservation")]
        public NSXTMemoryReservationType MemoryReservation { get; set; }
    }
}
