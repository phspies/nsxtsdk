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
    /// Entity lists where the profile will be enabled on.
    /// </summary>
    [NSXTProperty(Description: @"Entity lists where the profile will be enabled on.")]
    public class NSXTAppliedTosType 
    {
        /// <summary>
        /// Logical Port List
        /// </summary>
        [JsonProperty(PropertyName = "logical_ports")]
        public IList<NSXTResourceReferenceType> LogicalPorts { get; set; }
        /// <summary>
        /// Logical Switch List
        /// </summary>
        [JsonProperty(PropertyName = "logical_switches")]
        public IList<NSXTResourceReferenceType> LogicalSwitches { get; set; }
        /// <summary>
        /// NSGroup List
        /// </summary>
        [JsonProperty(PropertyName = "nsgroups")]
        public IList<NSXTResourceReferenceType> Nsgroups { get; set; }
    }
}
