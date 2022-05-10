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
    /// Amount of memory and CPU allocated to the Edge VM.
    /// </summary>
    [NSXTProperty(Description: @"Amount of memory and CPU allocated to the Edge VM.")]
    public class NSXTResourceAssignmentType 
    {
        /// <summary>
        /// Memory allocation in MB.
        /// </summary>
        [JsonProperty(PropertyName = "memory_allocation_in_mb")]
        public int? MemoryAllocationInMb { get; set; }
        /// <summary>
        /// CPU count.
        /// </summary>
        [JsonProperty(PropertyName = "cpu_count")]
        public int? CpuCount { get; set; }
    }
}
