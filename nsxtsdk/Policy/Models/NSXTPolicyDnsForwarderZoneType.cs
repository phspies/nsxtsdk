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
    public class NSXTPolicyDnsForwarderZoneType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// List of domain names on which conditional forwarding is based. This
        /// field is required if the DNS Zone is being used for a conditional
        /// forwarder. This field will also be used for conditional reverse lookup.
        /// Example 1, if for one of the zones, one of the entries in the fqdn is
        /// example.com, all the DNS requests under the domain example.com will
        /// be served by the corresponding upstream DNS server.
        /// Example 2, if for one of the zones, one of the entries in the fqdn
        /// list is "13.12.30.in-addr.arpa", reverse lookup for 30.12.13.0/24 will
        /// go to the corresponding DNS server.
        /// </summary>
        [JsonProperty(PropertyName = "dns_domain_names")]
        public IList<string> DnsDomainNames { get; set; }
        /// <summary>
        /// Max of 3 DNS servers can be configured
        /// </summary>
        [JsonProperty(PropertyName = "upstream_servers", Required = Required.AllowNull)]
        public IList<string> UpstreamServers { get; set; }
        /// <summary>
        /// The source IP used by the DNS Forwarder zone.
        /// </summary>
        [JsonProperty(PropertyName = "source_ip")]
        public string? SourceIp { get; set; }
    }
}
