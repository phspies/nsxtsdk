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
    public class NSXTALBStringGroupType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Enable the longest match, default is the shortest match.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "longest_match")]
        public bool? LongestMatch { get; set; }
        /// <summary>
        /// Type of StringGroup.
        /// Enum options - SG_TYPE_STRING, SG_TYPE_KEYVAL.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as SG_TYPE_STRING.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbstringGroupTypeEnumType Type { get; set; }
        /// <summary>
        /// Configure Key Value in the string group.
        /// </summary>
        [JsonProperty(PropertyName = "kv")]
        public IList<NSXTALBKeyValueType> Kv { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
    }
}
