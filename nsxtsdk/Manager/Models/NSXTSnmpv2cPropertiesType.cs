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
    /// This object contains list of SNMP v2c communities used to poll NSX nodes over SNMP and list of SNMP v2c targets used to
        /// receive SNMP traps/notifications from NSX nodes.
    /// </summary>
    [NSXTProperty(Description: @"This object contains list of SNMP v2c communities used to poll NSX nodes over SNMP and list of SNMP v2c targets used to receive SNMP traps/notifications from NSX nodes.")]
    public class NSXTSnmpv2cPropertiesType 
    {
        /// <summary>
        /// List of SNMP v2c communities allowed to poll NSX nodes over SNMP v2c.
        /// </summary>
        [JsonProperty(PropertyName = "communities")]
        public IList<NSXTSnmpv2cCommunityType> Communities { get; set; }
        /// <summary>
        /// List of SNMP v2c targets/receivers where SNMP v2c traps/notifications will be sent from NSX nodes.
        /// </summary>
        [JsonProperty(PropertyName = "targets")]
        public IList<NSXTSnmpv2cTargetType> Targets { get; set; }
    }
}
