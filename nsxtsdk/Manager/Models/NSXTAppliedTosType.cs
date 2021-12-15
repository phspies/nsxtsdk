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
    /// Entity lists where the profile will be enabled on.
    /// </summary>
    [NSXTProperty(Description: @"Entity lists where the profile will be enabled on.")]
    public class NSXTAppliedTosType 
    {
        /// <summary>
        /// Logical Port List
        /// </summary>
        [JsonProperty(PropertyName = "logical_ports")]
        [NSXTProperty(IsRequired: false, Description: @"Logical Port List")]
        public IList<NSXTResourceReferenceType> LogicalPorts { get; set; }
        /// <summary>
        /// Logical Switch List
        /// </summary>
        [JsonProperty(PropertyName = "logical_switches")]
        [NSXTProperty(IsRequired: false, Description: @"Logical Switch List")]
        public IList<NSXTResourceReferenceType> LogicalSwitches { get; set; }
        /// <summary>
        /// NSGroup List
        /// </summary>
        [JsonProperty(PropertyName = "nsgroups")]
        [NSXTProperty(IsRequired: false, Description: @"NSGroup List")]
        public IList<NSXTResourceReferenceType> Nsgroups { get; set; }
    }
}