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
    /// Describes a process detail informaiton.
    /// </summary>
    [NSXTProperty(Description: @"Describes a process detail informaiton.")]
    public class NSXTProcessInformationType 
    {
        /// <summary>
        /// Display the process id.
        /// </summary>
        [JsonProperty(PropertyName = "process_id")]
        [NSXTProperty(IsRequired: false, Description: @"Display the process id.")]
        public string? ProcessId { get; set; }
        /// <summary>
        /// The amount of shared memory available to a process, not all of which is typically resident.
        /// It simply reflects memory that could be potentially shared with other processes.
        /// </summary>
        [JsonProperty(PropertyName = "shared_memory_size")]
        [NSXTProperty(IsRequired: false, Description: @"The amount of shared memory available to a process, not all of which is typically resident.It simply reflects memory that could be potentially shared with other processes.")]
        public double? SharedMemorySize { get; set; }
        /// <summary>
        /// Display the command line used to start the process.
        /// </summary>
        [JsonProperty(PropertyName = "command")]
        [NSXTProperty(IsRequired: false, Description: @"Display the command line used to start the process.")]
        public string? Command { get; set; }
        /// <summary>
        /// A process's currently used share of available physical memory.
        /// </summary>
        [JsonProperty(PropertyName = "memory_usage")]
        [NSXTProperty(IsRequired: false, Description: @"A process&apos;s currently used share of available physical memory.")]
        public double? MemoryUsage { get; set; }
        /// <summary>
        /// The total amount of virtual memory used by the process.
        /// It includes all code, data and shared libraries plus pages that have been swapped out and pages that have been mapped
        /// but not used.
        /// </summary>
        [JsonProperty(PropertyName = "virtual_memory_size")]
        [NSXTProperty(IsRequired: false, Description: @"The total amount of virtual memory used by the process.It includes all code, data and shared libraries plus pages that have been swapped out and pages that have been mapped but not used.")]
        public double? VirtualMemorySize { get; set; }
        /// <summary>
        /// The non-swapped physical memoery a task is using.
        /// </summary>
        [JsonProperty(PropertyName = "resident_memory_size")]
        [NSXTProperty(IsRequired: false, Description: @"The non-swapped physical memoery a task is using.")]
        public double? ResidentMemorySize { get; set; }
        /// <summary>
        /// A negative nice value means higher priority, whereas a positive nice value means lower priority.
        /// Zero in this field simply means priority will not be adjusted in determining a process's dispatch-ability.
        /// </summary>
        [JsonProperty(PropertyName = "nice_value")]
        [NSXTProperty(IsRequired: false, Description: @"A negative nice value means higher priority, whereas a positive nice value means lower priority.Zero in this field simply means priority will not be adjusted in determining a process&apos;s dispatch-ability.")]
        public string? NiceValue { get; set; }
        /// <summary>
        /// The process's share of the elapsed CPU time since the last screen update, expressed as a percentage of total CPU time.
        /// </summary>
        [JsonProperty(PropertyName = "cpu_usage")]
        [NSXTProperty(IsRequired: false, Description: @"The process&apos;s share of the elapsed CPU time since the last screen update, expressed as a percentage of total CPU time.")]
        public double? CpuUsage { get; set; }
        /// <summary>
        /// Display the process user.
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        [NSXTProperty(IsRequired: false, Description: @"Display the process user.")]
        public string? User { get; set; }
    }
}