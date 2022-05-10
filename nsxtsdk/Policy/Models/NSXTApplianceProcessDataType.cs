using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTApplianceProcessDataType : NSXTResourceType
    {
        /// <summary>
        /// Display the total count of process.
        /// </summary>
        [JsonProperty(PropertyName = "top_process_by_cpu_count")]
        public long? TopProcessByCpuCount { get; set; }
        /// <summary>
        /// Display the appliance name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Display the top process list by memory.
        /// </summary>
        [JsonProperty(PropertyName = "top_process_by_mem_list")]
        public IList<NSXTProcessInformationType> TopProcessByMemList { get; set; }
        /// <summary>
        /// Timestamp of last modification.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public long? Timestamp { get; set; }
        /// <summary>
        /// Display the total count of process.
        /// </summary>
        [JsonProperty(PropertyName = "top_process_by_mem_count")]
        public long? TopProcessByMemCount { get; set; }
        /// <summary>
        /// Display the Appliance id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// Display the top process list by CPU.
        /// </summary>
        [JsonProperty(PropertyName = "top_process_by_cpu_list")]
        public IList<NSXTProcessInformationType> TopProcessByCpuList { get; set; }
    }
}
