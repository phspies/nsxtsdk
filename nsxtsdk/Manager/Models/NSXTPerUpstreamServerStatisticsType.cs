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
    /// Query statistics counters to an upstream server including successfully
        /// forwarded queries and failed queries.
    /// </summary>
    [NSXTProperty(Description: @"Query statistics counters to an upstream server including successfullyforwarded queries and failed queries.")]
    public class NSXTPerUpstreamServerStatisticsType 
    {
        /// <summary>
        /// Queries failed to forward.
        /// </summary>
        public long? QueriesFailed { get; set; }
        /// <summary>
        /// Upstream server ip
        /// </summary>
        public string? UpstreamServer { get; set; }
        /// <summary>
        /// Queries forwarded successfully
        /// </summary>
        public long? QueriesSucceeded { get; set; }
    }
}
