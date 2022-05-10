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
    /// SNMP Service properties
    /// </summary>
    [NSXTProperty(Description: @"SNMP Service properties")]
    public class NSXTSnmpServicePropertiesType 
    {
        /// <summary>
        /// SNMP v3 auth protocol
        /// </summary>
        [JsonProperty(PropertyName = "v3_auth_protocol", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTSnmpServicePropertiesV3AuthProtocolEnumType V3AuthProtocol { get; set; }
        /// <summary>
        /// SNMP v1, v2c community strings
        /// </summary>
        [JsonProperty(PropertyName = "communities")]
        public IList<string> Communities { get; set; }
        /// <summary>
        /// SNMP v3 is configured or not
        /// </summary>
        [JsonProperty(PropertyName = "v3_configured")]
        public bool? V3Configured { get; set; }
        /// <summary>
        /// SNMP v3 private protocol
        /// </summary>
        [JsonProperty(PropertyName = "v3_priv_protocol", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTSnmpServicePropertiesV3PrivProtocolEnumType V3PrivProtocol { get; set; }
        /// <summary>
        /// SNMP v3 users information
        /// </summary>
        [JsonProperty(PropertyName = "v3_users")]
        public IList<NSXTSnmpV3UserType> V3Users { get; set; }
        /// <summary>
        /// SNMP v2 is configured or not
        /// </summary>
        [JsonProperty(PropertyName = "v2_configured")]
        public bool? V2Configured { get; set; }
        /// <summary>
        /// Start when system boots
        /// </summary>
        [JsonProperty(PropertyName = "start_on_boot", Required = Required.AllowNull)]
        public bool StartOnBoot { get; set; }
    }
}
