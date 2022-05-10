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
    /// Describes a process detail informaiton.
    /// </summary>
    [NSXTProperty(Description: @"Describes a process detail informaiton.")]
    public class NSXTProcessInformationType 
    {
        /// <summary>
        /// Display the process id.
        /// </summary>
        [JsonProperty(PropertyName = "process_id")]
        public string? ProcessId { get; set; }
        /// <summary>
        /// The amount of shared memory available to a process, not all of which is typically resident.
        /// It simply reflects memory that could be potentially shared with other processes.
        /// </summary>
        [JsonProperty(PropertyName = "shared_memory_size")]
        public double? SharedMemorySize { get; set; }
        /// <summary>
        /// Display the command line used to start the process.
        /// </summary>
        [JsonProperty(PropertyName = "command")]
        public string? Command { get; set; }
        /// <summary>
        /// A process's currently used share of available physical memory.
        /// </summary>
        [JsonProperty(PropertyName = "memory_usage")]
        public double? MemoryUsage { get; set; }
        /// <summary>
        /// The total amount of virtual memory used by the process.
        /// It includes all code, data and shared libraries plus pages that have been swapped out and pages that have been mapped
        /// but not used.
        /// </summary>
        [JsonProperty(PropertyName = "virtual_memory_size")]
        public double? VirtualMemorySize { get; set; }
        /// <summary>
        /// The non-swapped physical memoery a task is using.
        /// </summary>
        [JsonProperty(PropertyName = "resident_memory_size")]
        public double? ResidentMemorySize { get; set; }
        /// <summary>
        /// A negative nice value means higher priority, whereas a positive nice value means lower priority.
        /// Zero in this field simply means priority will not be adjusted in determining a process's dispatch-ability.
        /// </summary>
        [JsonProperty(PropertyName = "nice_value")]
        public string? NiceValue { get; set; }
        /// <summary>
        /// The process's share of the elapsed CPU time since the last screen update, expressed as a percentage of total CPU time.
        /// </summary>
        [JsonProperty(PropertyName = "cpu_usage")]
        public double? CpuUsage { get; set; }
        /// <summary>
        /// Display the process user.
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public string? User { get; set; }
    }
}
