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
    /// The setting is used to add, update or remove pool members from pool.
        /// For static pool members, admin_state, display_name and weight can be
        /// updated.
        /// For dynamic pool members, only admin_state can be updated.
    /// </summary>
    [NSXTProperty(Description: @"The setting is used to add, update or remove pool members from pool.For static pool members, admin_state, display_name and weight can beupdated.For dynamic pool members, only admin_state can be updated.")]
    public class NSXTPoolMemberSettingType 
    {
        /// <summary>
        /// Member admin state
        /// </summary>
        [JsonProperty(PropertyName = "admin_state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPoolMemberSettingAdminStateEnumType? AdminState { get; set; }
        /// <summary>
        /// Pool member IP address
        /// </summary>
        [JsonProperty(PropertyName = "ip_address", Required = Required.AllowNull)]
        public string IpAddress { get; set; }
        /// <summary>
        /// Pool member port number
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public string? Port { get; set; }
        /// <summary>
        /// Only applicable to static pool members. If supplied for a pool defined
        /// by a grouping object, update API would fail.
        /// </summary>
        [JsonProperty(PropertyName = "weight")]
        public long? Weight { get; set; }
        /// <summary>
        /// Only applicable to static pool members. If supplied for a pool defined
        /// by a grouping object, update API would fail.
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
    }
}
