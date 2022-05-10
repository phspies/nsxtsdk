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
    /// Capability of a fabric node
    /// </summary>
    [NSXTProperty(Description: @"Capability of a fabric node")]
    public class NSXTNodeCapabilityType 
    {
        /// <summary>
        /// Value of this capability
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string? Value { get; set; }
        /// <summary>
        /// Version of the capability
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public int? Version { get; set; }
        /// <summary>
        /// Description of this capability that can be displayed in UI
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// String that identifies the base capability for all nodes
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string? Key { get; set; }
        /// <summary>
        /// Provider of this capability for the node
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public string? Provider { get; set; }
    }
}
