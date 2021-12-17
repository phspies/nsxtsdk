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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTRaDNSConfigType 
    {
        public NSXTRaDNSConfigType()
        {
            DomainNameLifetime = test
            DnsServerLifetime = test
        }
        /// <summary>
        /// Lifetime of Domain names in milliseconds
        /// </summary>
        [JsonProperty(PropertyName = "domain_name_lifetime")]
        [NSXTProperty(IsRequired: false, Description: @"Lifetime of Domain names in milliseconds")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(4294967295)]
        public long? DomainNameLifetime { get; set; }
        /// <summary>
        /// DNS server.
        /// </summary>
        [JsonProperty(PropertyName = "dns_server")]
        [NSXTProperty(IsRequired: false, Description: @"DNS server.")]
        public IList<string> DnsServer { get; set; }
        /// <summary>
        /// Domain name in RA message.
        /// </summary>
        [JsonProperty(PropertyName = "domain_name")]
        [NSXTProperty(IsRequired: false, Description: @"Domain name in RA message.")]
        public IList<string> DomainName { get; set; }
        /// <summary>
        /// Lifetime of DNS server in milliseconds
        /// </summary>
        [JsonProperty(PropertyName = "dns_server_lifetime")]
        [NSXTProperty(IsRequired: false, Description: @"Lifetime of DNS server in milliseconds")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(4294967295)]
        public long? DnsServerLifetime { get; set; }
    }
}
