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
    /// This object contains SNMP v3 target/receiver where SNMP traps/notifications will be sent.
    /// </summary>
    [NSXTProperty(Description: @"This object contains SNMP v3 target/receiver where SNMP traps/notifications will be sent.")]
    public class NSXTSnmpv3TargetType 
    {
        /// <summary>
        /// Security level indicates whether SNMP communication involves authentication and privacy protocols for this user. Value
        /// "AUTH_PRIV" indicates both authentication and privacy protocols will be used for SNMP communication.
        /// </summary>
        [JsonProperty(PropertyName = "security_level")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTSnmpv3TargetSecurityLevelEnumType? SecurityLevel { get; set; }
        /// <summary>
        /// SNMP v3 user id used to notify target server. This SNMP v3 user should already be added in this profile.
        /// </summary>
        [JsonProperty(PropertyName = "user_id", Required = Required.AllowNull)]
        public string UserId { get; set; }
        /// <summary>
        /// SNMP v3 target server's port.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public long? Port { get; set; }
        /// <summary>
        /// SNMP v3 target server's IP or FQDN.
        /// </summary>
        [JsonProperty(PropertyName = "server", Required = Required.AllowNull)]
        public string Server { get; set; }
    }
}
