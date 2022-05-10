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
    public class NSXTForwarderZoneType 
    {
        /// <summary>
        /// Ip address of the upstream DNS servers the DNS forwarder accesses.
        /// </summary>
        [JsonProperty(PropertyName = "upstream_servers", Required = Required.AllowNull)]
        public IList<string> UpstreamServers { get; set; }
        /// <summary>
        /// The source ip used by the fowarder of the zone. If no source ip
        /// specified, the ip address of listener of the DNS forwarder will
        /// be used.
        /// </summary>
        [JsonProperty(PropertyName = "source_ip")]
        public string? SourceIp { get; set; }
    }
}
