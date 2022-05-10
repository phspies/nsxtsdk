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
    /// Information related to OVF file.
    /// </summary>
    [NSXTProperty(Description: @"Information related to OVF file.")]
    public class NSXTOvfInfoType 
    {
        /// <summary>
        /// Version of the OVF.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string? Version { get; set; }
        /// <summary>
        /// Name of OVF file.
        /// </summary>
        [JsonProperty(PropertyName = "ovf_name")]
        public string? OvfName { get; set; }
    }
}
