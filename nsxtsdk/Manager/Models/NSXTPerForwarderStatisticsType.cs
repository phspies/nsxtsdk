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
    /// Query statistics counters of a forwarder identified by domain names.
    /// </summary>
    [NSXTProperty(Description: @"Query statistics counters of a forwarder identified by domain names.")]
    public class NSXTPerForwarderStatisticsType 
    {
        /// <summary>
        /// Statistics per upstream server.
        /// </summary>
        [JsonProperty(PropertyName = "upstream_statistics")]
        public IList<NSXTPerUpstreamServerStatisticsType> UpstreamStatistics { get; set; }
        /// <summary>
        /// Domain names configured for the forwarder. Empty if this is the
        /// default forwarder.
        /// </summary>
        [JsonProperty(PropertyName = "domain_names")]
        public IList<string> DomainNames { get; set; }
    }
}
