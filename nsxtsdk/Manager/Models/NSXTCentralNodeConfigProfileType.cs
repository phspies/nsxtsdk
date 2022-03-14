// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

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
        public NSXTSyslogPropertiesType Syslog { get; set; }
        /// <summary>
        /// Timezone to be set for NSX nodes. Only timezone strings listed in the Time Zone database
        /// (https://www.iana.org/time-zones) are allowed.
        /// </summary>
        public string? Timezone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NSXTSnmpPropertiesType Snmp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NSXTNtpPropertiesType Ntp { get; set; }
    }
}
