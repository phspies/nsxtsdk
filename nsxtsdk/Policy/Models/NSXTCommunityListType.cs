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
        [NSXTProperty(IsRequired: true, Description: @"List of BGP community entries. Both standard and large communitiesare supported. Standard community format: aa:nn where aa and nn mustbe within the range [1 - 65536]. Large BGP Community format: aa:bb:nnwhere aa (Global Administrator), bb  (Local Data Part 1) and nn (LocalData Part 2) must be within the range [1 - 4294967295]. In additon tonumbered communites (e.g. 3356:2040), predefined communities (NO_EXPORT,NO_ADVERTISE, NO_EXPORT_SUBCONFED) are supported.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<string> Communities { get; set; }
    }
}
