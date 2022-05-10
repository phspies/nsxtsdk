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
    public class NSXTNodeProcessPropertiesType : NSXTResourceType
    {
        /// <summary>
        /// Virtual memory used by process in bytes
        /// </summary>
        [JsonProperty(PropertyName = "mem_used")]
        public long? MemUsed { get; set; }
        /// <summary>
        /// CPU time (user and system) consumed by process in milliseconds
        /// </summary>
        [JsonProperty(PropertyName = "cpu_time")]
        public long? CpuTime { get; set; }
        /// <summary>
        /// Parent process id
        /// </summary>
        [JsonProperty(PropertyName = "ppid")]
        public long? Ppid { get; set; }
        /// <summary>
        /// Process start time expressed in milliseconds since epoch
        /// </summary>
        [JsonProperty(PropertyName = "start_time")]
        public long? StartTime { get; set; }
        /// <summary>
        /// Process name
        /// </summary>
        [JsonProperty(PropertyName = "process_name")]
        public string? ProcessName { get; set; }
        /// <summary>
        /// Process id
        /// </summary>
        [JsonProperty(PropertyName = "pid")]
        public long? Pid { get; set; }
        /// <summary>
        /// Milliseconds since process started
        /// </summary>
        [JsonProperty(PropertyName = "uptime")]
        public long? Uptime { get; set; }
        /// <summary>
        /// Resident set size of process in bytes
        /// </summary>
        [JsonProperty(PropertyName = "mem_resident")]
        public long? MemResident { get; set; }
    }
}
