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
    public class NSXTPolicyEdgeNodeType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// The numerical value of the member index in the edge cluster
        /// that this object represents and to which the edge node connects.
        /// </summary>
        [JsonProperty(PropertyName = "member_index")]
        public long? MemberIndex { get; set; }
        /// <summary>
        /// UUID of edge node on NSX-T enforcement point.
        /// </summary>
        [JsonProperty(PropertyName = "nsx_id")]
        public string? NsxId { get; set; }
    }
}
