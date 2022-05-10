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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTALBIpAddrGroupType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Configure IP address range(s).
        /// </summary>
        [JsonProperty(PropertyName = "ranges")]
        public IList<NSXTALBIpAddrRangeType> Ranges { get; set; }
        /// <summary>
        /// Configure IP address prefix(es).
        /// </summary>
        [JsonProperty(PropertyName = "prefixes")]
        public IList<NSXTALBIpAddrPrefixType> Prefixes { get; set; }
        /// <summary>
        /// Configure (IP address, port) tuple(s).
        /// </summary>
        [JsonProperty(PropertyName = "ip_ports")]
        public IList<NSXTALBIpAddrPortType> IpPorts { get; set; }
        /// <summary>
        /// Populate IP addresses from tasks of this Marathon app.
        /// </summary>
        [JsonProperty(PropertyName = "marathon_app_name")]
        public string? MarathonAppName { get; set; }
        /// <summary>
        /// Configure IP address(es).
        /// </summary>
        [JsonProperty(PropertyName = "addrs")]
        public IList<NSXTALBIpAddrType> Addrs { get; set; }
        /// <summary>
        /// Populate the IP address ranges from the geo database for
        /// this country.
        /// </summary>
        [JsonProperty(PropertyName = "country_codes")]
        public IList<string> CountryCodes { get; set; }
        /// <summary>
        /// Task port associated with marathon service port.
        /// If Marathon app has multiple service ports, this is
        /// required.
        /// Else, the first task port is used.
        /// </summary>
        [JsonProperty(PropertyName = "marathon_service_port")]
        public long? MarathonServicePort { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
        /// <summary>
        /// Populate IP addresses from members of this Cisco APIC EPG.
        /// </summary>
        [JsonProperty(PropertyName = "apic_epg_name")]
        public string? ApicEpgName { get; set; }
    }
}
