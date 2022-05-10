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
    /// This object contains list of SNMP v3 users used to poll NSX nodes over SNMP and list of SNMP v3 targets used to receive
        /// SNMP traps/notifications from NSX nodes. Users specified in a SNMP v3 target must exist in the list of SNMP v3 users.
    /// </summary>
    [NSXTProperty(Description: @"This object contains list of SNMP v3 users used to poll NSX nodes over SNMP and list of SNMP v3 targets used to receive SNMP traps/notifications from NSX nodes. Users specified in a SNMP v3 target must exist in the list of SNMP v3 users.")]
    public class NSXTSnmpv3PropertiesType 
    {
        /// <summary>
        /// Authentication protocol used for SNMP v3 communication.
        /// </summary>
        [JsonProperty(PropertyName = "auth_protocol")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTSnmpv3PropertiesAuthProtocolEnumType? AuthProtocol { get; set; }
        /// <summary>
        /// Privacy protocol used for SNMP v3 communication.
        /// </summary>
        [JsonProperty(PropertyName = "priv_protocol")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTSnmpv3PropertiesPrivProtocolEnumType? PrivProtocol { get; set; }
        /// <summary>
        /// List of SNMP v3 users allowed to poll NSX nodes over SNMP. Also, users specified in a SNMP v3 target must exist in this
        /// list.
        /// </summary>
        [JsonProperty(PropertyName = "users")]
        public IList<NSXTSnmpV3UserType> Users { get; set; }
        /// <summary>
        /// List of SNMP v3 targets/receivers where SNMP v3 traps/notifications will be sent from NSX nodes.
        /// </summary>
        [JsonProperty(PropertyName = "targets")]
        public IList<NSXTSnmpv3TargetType> Targets { get; set; }
    }
}
