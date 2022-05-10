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
    public class NSXTRealizedSecurityGroupMemberEvaluationType : NSXTPolicyRealizedResourceType
    {
        /// <summary>
        /// list of virtual machines
        /// </summary>
        [JsonProperty(PropertyName = "virtual_machines")]
        public IList<NSXTRealizedVirtualMachineType> VirtualMachines { get; set; }
        /// <summary>
        /// Count of the members added to this Security Group
        /// </summary>
        [JsonProperty(PropertyName = "member_count")]
        public long? MemberCount { get; set; }
    }
}
