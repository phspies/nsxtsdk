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
    /// Advanced load balancer ConnPoolProperties object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer ConnPoolProperties object")]
    public class NSXTALBConnPoolPropertiesType 
    {
        /// <summary>
        /// Connection life timeout.
        /// Allowed in Basic(Allowed values- 600000) edition,
        /// Essentials(Allowed values- 600000) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 600000.
        /// </summary>
        [JsonProperty(PropertyName = "upstream_connpool_conn_life_tmo")]
        public long? UpstreamConnpoolConnLifeTmo { get; set; }
        /// <summary>
        /// Maximum number of connections a server can cache.
        /// Special values are 0- 'unlimited'.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "upstream_connpool_server_max_cache")]
        public long? UpstreamConnpoolServerMaxCache { get; set; }
        /// <summary>
        /// Maximum number of times a connection can be reused.
        /// Special values are 0- 'unlimited'.
        /// Allowed in Basic(Allowed values- 0) edition,
        /// Essentials(Allowed values- 0) edition, Enterprise edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "upstream_connpool_conn_max_reuse")]
        public long? UpstreamConnpoolConnMaxReuse { get; set; }
        /// <summary>
        /// Connection idle timeout.
        /// Allowed in Basic(Allowed values- 60000) edition,
        /// Essentials(Allowed values- 60000) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 60000.
        /// </summary>
        [JsonProperty(PropertyName = "upstream_connpool_conn_idle_tmo")]
        public long? UpstreamConnpoolConnIdleTmo { get; set; }
    }
}
