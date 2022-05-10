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
    /// Statistics counters of the DNS forwarder zone.
    /// </summary>
    [NSXTProperty(Description: @"Statistics counters of the DNS forwarder zone.")]
    public class NSXTNsxTDNSForwarderZoneStatisticsType 
    {
        /// <summary>
        /// Statistics per upstream server.
        /// </summary>
        [JsonProperty(PropertyName = "upstream_statistics")]
        public IList<NSXTNsxTUpstreamServerStatisticsType> UpstreamStatistics { get; set; }
        /// <summary>
        /// Domain names configured for the forwarder. Empty if this is the
        /// default forwarder.
        /// </summary>
        [JsonProperty(PropertyName = "domain_names")]
        public IList<string> DomainNames { get; set; }
    }
}
