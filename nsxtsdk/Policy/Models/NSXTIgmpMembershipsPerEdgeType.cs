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
    public class NSXTIgmpMembershipsPerEdgeType : NSXTListResultType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "igmp_memberships")]
        public IList<NSXTIgmpMembershipType> IgmpMemberships { get; set; }
        /// <summary>
        /// Policy path to edge node.
        /// </summary>
        [JsonProperty(PropertyName = "edge_path", Required = Required.AllowNull)]
        public string EdgePath { get; set; }
    }
}
