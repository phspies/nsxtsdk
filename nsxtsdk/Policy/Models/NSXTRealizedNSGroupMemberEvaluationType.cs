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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTRealizedNSGroupMemberEvaluationType : NSXTPolicyRealizedResourceType
    {
        /// <summary>
        /// list of logical ports
        /// </summary>
        [JsonProperty(PropertyName = "logical_ports")]
        [NSXTProperty(IsRequired: false, Description: @"list of logical ports")]
        public IList<NSXTRealizedLogicalPortType> LogicalPorts { get; set; }
        /// <summary>
        /// list of virtual machines
        /// </summary>
        [JsonProperty(PropertyName = "virtual_machines")]
        [NSXTProperty(IsRequired: false, Description: @"list of virtual machines")]
        public IList<NSXTRealizedVirtualMachineType> VirtualMachines { get; set; }
        /// <summary>
        /// list of logical switches
        /// </summary>
        [JsonProperty(PropertyName = "logical_switches")]
        [NSXTProperty(IsRequired: false, Description: @"list of logical switches")]
        public IList<NSXTRealizedLogicalSwitchType> LogicalSwitches { get; set; }
        /// <summary>
        /// Count of the members added to this NSGroup
        /// </summary>
        [JsonProperty(PropertyName = "member_count")]
        [NSXTProperty(IsRequired: false, Description: @"Count of the members added to this NSGroup")]
        public long? MemberCount { get; set; }
    }
}