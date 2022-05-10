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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTBGPCommunityListType : NSXTManagedResourceType
    {
        /// <summary>
        /// Array of BGP communities
        /// </summary>
        [JsonProperty(PropertyName = "communities", Required = Required.AllowNull)]
        public IList<string> Communities { get; set; }
        /// <summary>
        /// Logical router id
        /// </summary>
        [JsonProperty(PropertyName = "logical_router_id")]
        public string? LogicalRouterId { get; set; }
        /// <summary>
        /// BGP community type. It has two types as
        /// NormalBGPCommunity BGP normal community which includes well-known
        /// community name as well as community value in range from [1-4294967295]
        /// or value in aa:nn format(aa/nn range from 1-65535).
        /// LargeBGPCommunity BGP large community which includes community value
        /// in aa:bb:nn format where aa, bb, nn are unsigned integers in the range
        /// [1-4294967295].
        /// </summary>
        [JsonProperty(PropertyName = "community_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTBgpcommunityListCommunityTypeEnumType? CommunityType { get; set; }
    }
}
