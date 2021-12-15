// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

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
        [NSXTProperty(IsRequired: false, Description: @"Memory allocation in MB.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        public int? MemoryAllocationInMb { get; set; }
        /// <summary>
        /// CPU count.
        /// </summary>
        [JsonProperty(PropertyName = "cpu_count")]
        [NSXTProperty(IsRequired: false, Description: @"CPU count.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        public int? CpuCount { get; set; }
    }
}