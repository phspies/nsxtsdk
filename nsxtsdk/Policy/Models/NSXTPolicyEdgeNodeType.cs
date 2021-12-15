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
    public class NSXTPolicyEdgeNodeType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// The numerical value of the member index in the edge cluster
        /// that this object represents and to which the edge node connects.
        /// </summary>
        [JsonProperty(PropertyName = "member_index")]
        [NSXTProperty(IsRequired: false, Description: @"The numerical value of the member index in the edge clusterthat this object represents and to which the edge node connects.")]
        public long? MemberIndex { get; set; }
        /// <summary>
        /// UUID of edge node on NSX-T enforcement point.
        /// </summary>
        [JsonProperty(PropertyName = "nsx_id")]
        [NSXTProperty(IsRequired: false, Description: @"UUID of edge node on NSX-T enforcement point.")]
        public string? NsxId { get; set; }
    }
}
