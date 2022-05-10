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
    /// Pre/post-upgrade check failure
    /// </summary>
    [NSXTProperty(Description: @"Pre/post-upgrade check failure")]
    public class NSXTUpgradeCheckFailureType 
    {
        /// <summary>
        /// Component type of the origin of failure
        /// </summary>
        [JsonProperty(PropertyName = "component_type")]
        public string? ComponentType { get; set; }
        /// <summary>
        /// Name of origin of pre/post-upgrade check failure
        /// </summary>
        [JsonProperty(PropertyName = "origin_name")]
        public string? OriginName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public NSXTUpgradeCheckFailureMessageType Message { get; set; }
        /// <summary>
        /// Unique id of origin of pre/post-upgrade check failure
        /// </summary>
        [JsonProperty(PropertyName = "origin_id")]
        public string? OriginId { get; set; }
        /// <summary>
        /// Type of the pre/post-upgrade check failure
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTUpgradeCheckFailureTypeEnumType? Type { get; set; }
        /// <summary>
        /// Type of origin of pre/post-upgrade check failure
        /// </summary>
        [JsonProperty(PropertyName = "origin_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTUpgradeCheckFailureOriginTypeEnumType? OriginType { get; set; }
        /// <summary>
        /// Name of the upgrade group of the origin of failure. Only applicable when
        /// origin_type is UPGRADE_UNIT.
        /// </summary>
        [JsonProperty(PropertyName = "group_name")]
        public string? GroupName { get; set; }
    }
}
