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
    /// This object contains SNMP v2c target/receiver where SNMP traps/notifications will be sent.
    /// </summary>
    [NSXTProperty(Description: @"This object contains SNMP v2c target/receiver where SNMP traps/notifications will be sent.")]
    public class NSXTSnmpv2cTargetType 
    {
        /// <summary>
        /// Unique non-sensitive community name to identify community.
        /// </summary>
        [JsonProperty(PropertyName = "community_name", Required = Required.AllowNull)]
        public string CommunityName { get; set; }
        /// <summary>
        /// Community string (shared secret). This field is required when adding a community target. When updating a community
        /// target, do not include this field in the request. If this field is present in an update request, it will be considered
        /// as a new value for community string.
        /// </summary>
        [JsonProperty(PropertyName = "community_string")]
        public string? CommunityString { get; set; }
        /// <summary>
        /// SNMP v2c target server's port number.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public long? Port { get; set; }
        /// <summary>
        /// SNMP v2c target server's IP or FQDN.
        /// </summary>
        [JsonProperty(PropertyName = "server", Required = Required.AllowNull)]
        public string Server { get; set; }
    }
}
