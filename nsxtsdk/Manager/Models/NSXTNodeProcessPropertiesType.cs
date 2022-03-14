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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTNodeProcessPropertiesType : NSXTResourceType
    {
        /// <summary>
        /// Virtual memory used by process in bytes
        /// </summary>
        public long? MemUsed { get; set; }
        /// <summary>
        /// CPU time (user and system) consumed by process in milliseconds
        /// </summary>
        public long? CpuTime { get; set; }
        /// <summary>
        /// Parent process id
        /// </summary>
        public long? Ppid { get; set; }
        /// <summary>
        /// Process start time expressed in milliseconds since epoch
        /// </summary>
        public long? StartTime { get; set; }
        /// <summary>
        /// Process name
        /// </summary>
        public string? ProcessName { get; set; }
        /// <summary>
        /// Process id
        /// </summary>
        public long? Pid { get; set; }
        /// <summary>
        /// Milliseconds since process started
        /// </summary>
        public long? Uptime { get; set; }
        /// <summary>
        /// Resident set size of process in bytes
        /// </summary>
        public long? MemResident { get; set; }
    }
}
