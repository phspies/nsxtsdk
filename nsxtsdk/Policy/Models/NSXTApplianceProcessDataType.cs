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
        public long? TopProcessByCpuCount { get; set; }
        /// <summary>
        /// Display the appliance name.
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Display the top process list by memory.
        /// </summary>
        public IList<NSXTProcessInformationType> TopProcessByMemList { get; set; }
        /// <summary>
        /// Timestamp of last modification.
        /// </summary>
        public long? Timestamp { get; set; }
        /// <summary>
        /// Display the total count of process.
        /// </summary>
        public long? TopProcessByMemCount { get; set; }
        /// <summary>
        /// Display the Appliance id.
        /// </summary>
        public string? Id { get; set; }
        /// <summary>
        /// Display the top process list by CPU.
        /// </summary>
        public IList<NSXTProcessInformationType> TopProcessByCpuList { get; set; }
    }
}
