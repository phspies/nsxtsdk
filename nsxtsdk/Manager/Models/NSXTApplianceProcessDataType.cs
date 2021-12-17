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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTApplianceProcessDataType : NSXTResourceType
    {
        public NSXTApplianceProcessDataType()
        {
        }
        /// <summary>
        /// Display the total count of process.
        /// </summary>
        [JsonProperty(PropertyName = "top_process_by_cpu_count")]
        [NSXTProperty(IsRequired: false, Description: @"Display the total count of process.")]
        public long? TopProcessByCpuCount { get; set; }
        /// <summary>
        /// Display the appliance name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [NSXTProperty(IsRequired: false, Description: @"Display the appliance name.")]
        public string? Name { get; set; }
        /// <summary>
        /// Display the top process list by memory.
        /// </summary>
        [JsonProperty(PropertyName = "top_process_by_mem_list")]
        [NSXTProperty(IsRequired: false, Description: @"Display the top process list by memory.")]
        public IList<NSXTProcessInformationType> TopProcessByMemList { get; set; }
        /// <summary>
        /// Timestamp of last modification.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        [NSXTProperty(IsRequired: false, Description: @"Timestamp of last modification.")]
        public long? Timestamp { get; set; }
        /// <summary>
        /// Display the total count of process.
        /// </summary>
        [JsonProperty(PropertyName = "top_process_by_mem_count")]
        [NSXTProperty(IsRequired: false, Description: @"Display the total count of process.")]
        public long? TopProcessByMemCount { get; set; }
        /// <summary>
        /// Display the Appliance id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        [NSXTProperty(IsRequired: false, Description: @"Display the Appliance id.")]
        public string? Id { get; set; }
        /// <summary>
        /// Display the top process list by CPU.
        /// </summary>
        [JsonProperty(PropertyName = "top_process_by_cpu_list")]
        [NSXTProperty(IsRequired: false, Description: @"Display the top process list by CPU.")]
        public IList<NSXTProcessInformationType> TopProcessByCpuList { get; set; }
    }
}
