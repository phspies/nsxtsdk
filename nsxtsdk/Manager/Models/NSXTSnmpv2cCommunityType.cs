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
    /// This object contains SNMP v2c community identifier, shared secret and access properties.
    /// </summary>
    [NSXTProperty(Description: @"This object contains SNMP v2c community identifier, shared secret and access properties.")]
    public class NSXTSnmpv2cCommunityType 
    {
        /// <summary>
        /// Access permissions for polling NSX nodes over SNMP v2c.
        /// </summary>
        [JsonProperty(PropertyName = "access")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTSnmpv2cCommunityAccessEnumType? Access { get; set; }
        /// <summary>
        /// Unique, non-sensitive community name to identify community.
        /// </summary>
        [JsonProperty(PropertyName = "community_name", Required = Required.AllowNull)]
        public string CommunityName { get; set; }
        /// <summary>
        /// Community string. This is considered a shared secret and therefore sensitive information. This field is required when
        /// adding a community. When updating a community, do not include this field in the request. If this field is present in an
        /// update request, it will be considered as a new value for community string.
        /// </summary>
        [JsonProperty(PropertyName = "community_string")]
        public string? CommunityString { get; set; }
    }
}
