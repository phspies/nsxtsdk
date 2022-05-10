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
    public class NSXTRaDNSConfigType 
    {
        /// <summary>
        /// Lifetime of Domain names in milliseconds
        /// </summary>
        [JsonProperty(PropertyName = "domain_name_lifetime")]
        public long? DomainNameLifetime { get; set; }
        /// <summary>
        /// DNS server.
        /// </summary>
        [JsonProperty(PropertyName = "dns_server")]
        public IList<string> DnsServer { get; set; }
        /// <summary>
        /// Domain name in RA message.
        /// </summary>
        [JsonProperty(PropertyName = "domain_name")]
        public IList<string> DomainName { get; set; }
        /// <summary>
        /// Lifetime of DNS server in milliseconds
        /// </summary>
        [JsonProperty(PropertyName = "dns_server_lifetime")]
        public long? DnsServerLifetime { get; set; }
    }
}
