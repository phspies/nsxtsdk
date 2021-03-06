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
    public class NSXTCommunityListType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// List of BGP community entries. Both standard and large communities
        /// are supported. Standard community format: aa:nn where aa and nn must
        /// be within the range [1 - 65536]. Large BGP Community format: aa:bb:nn
        /// where aa (Global Administrator), bb  (Local Data Part 1) and nn (Local
        /// Data Part 2) must be within the range [1 - 4294967295]. In additon to
        /// numbered communites (e.g. 3356:2040), predefined communities (NO_EXPORT,
        /// NO_ADVERTISE, NO_EXPORT_SUBCONFED) are supported.
        /// </summary>
        [JsonProperty(PropertyName = "communities", Required = Required.AllowNull)]
        public IList<string> Communities { get; set; }
    }
}
