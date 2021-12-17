// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Query statistics counters of a forwarder identified by domain names.
    /// </summary>
    [NSXTProperty(Description: @"Query statistics counters of a forwarder identified by domain names.")]
    public class NSXTPerForwarderStatisticsType 
    {
        public NSXTPerForwarderStatisticsType()
        {
        }
        /// <summary>
        /// Statistics per upstream server.
        /// </summary>
        [JsonProperty(PropertyName = "upstream_statistics")]
        [NSXTProperty(IsRequired: false, Description: @"Statistics per upstream server.")]
        public IList<NSXTPerUpstreamServerStatisticsType> UpstreamStatistics { get; set; }
        /// <summary>
        /// Domain names configured for the forwarder. Empty if this is the
        /// default forwarder.
        /// </summary>
        [JsonProperty(PropertyName = "domain_names")]
        [NSXTProperty(IsRequired: false, Description: @"Domain names configured for the forwarder. Empty if this is thedefault forwarder.")]
        public IList<string> DomainNames { get; set; }
    }
}
