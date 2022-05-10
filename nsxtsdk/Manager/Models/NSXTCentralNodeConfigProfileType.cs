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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTCentralNodeConfigProfileType : NSXTManagedResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "syslog")]
        public NSXTSyslogPropertiesType Syslog { get; set; }
        /// <summary>
        /// Timezone to be set for NSX nodes. Only timezone strings listed in the Time Zone database
        /// (https://www.iana.org/time-zones) are allowed.
        /// </summary>
        [JsonProperty(PropertyName = "timezone")]
        public string? Timezone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "snmp")]
        public NSXTSnmpPropertiesType Snmp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ntp")]
        public NSXTNtpPropertiesType Ntp { get; set; }
    }
}
