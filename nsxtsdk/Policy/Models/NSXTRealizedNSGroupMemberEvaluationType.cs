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
    public class NSXTRealizedNSGroupMemberEvaluationType : NSXTPolicyRealizedResourceType
    {
        /// <summary>
        /// list of logical ports
        /// </summary>
        [JsonProperty(PropertyName = "logical_ports")]
        public IList<NSXTRealizedLogicalPortType> LogicalPorts { get; set; }
        /// <summary>
        /// list of virtual machines
        /// </summary>
        [JsonProperty(PropertyName = "virtual_machines")]
        public IList<NSXTRealizedVirtualMachineType> VirtualMachines { get; set; }
        /// <summary>
        /// list of logical switches
        /// </summary>
        [JsonProperty(PropertyName = "logical_switches")]
        public IList<NSXTRealizedLogicalSwitchType> LogicalSwitches { get; set; }
        /// <summary>
        /// Count of the members added to this NSGroup
        /// </summary>
        [JsonProperty(PropertyName = "member_count")]
        public long? MemberCount { get; set; }
    }
}
