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
    public class NSXTRealizedSecurityGroupMemberEvaluationType : NSXTPolicyRealizedResourceType
    {
        /// <summary>
        /// list of virtual machines
        /// </summary>
        [JsonProperty(PropertyName = "virtual_machines")]
        [NSXTProperty(IsRequired: false, Description: @"list of virtual machines")]
        public IList<NSXTRealizedVirtualMachineType> VirtualMachines { get; set; }
        /// <summary>
        /// Count of the members added to this Security Group
        /// </summary>
        [JsonProperty(PropertyName = "member_count")]
        [NSXTProperty(IsRequired: false, Description: @"Count of the members added to this Security Group")]
        public long? MemberCount { get; set; }
    }
}