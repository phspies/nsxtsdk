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
    /// Advanced load balancer DnsServiceApplicationProfile object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DnsServiceApplicationProfile object")]
    public class NSXTALBDnsServiceApplicationProfileType 
    {
        public NSXTALBDnsServiceApplicationProfileType()
        {
            DnsOverTcpEnabled = test
            EcsStrippingEnabled = test
            NegativeCachingTtl = test
            AaaaEmptyResponse = test
            NumDnsIp = test
            ErrorResponse = test
            Ttl = test
            Edns = test
            AdminEmail = test
        }
        /// <summary>
        /// Enable DNS query/response over TCP.
        /// This enables analytics for pass-through queries as well.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "dns_over_tcp_enabled")]
        [NSXTProperty(IsRequired: false, Description: @"Enable DNS query/response over TCP.This enables analytics for pass-through queries as well.Default value when not specified in API or module isinterpreted by ALB Controller as true.")]
        public bool? DnsOverTcpEnabled { get; set; }
        /// <summary>
        /// Specifies the IP address prefix length to use in the EDNS
        /// client subnet (ECS) option.
        /// When the incoming request does not have any ECS option and
        /// the prefix length is specified, an ECS option is inserted in
        /// the request passed to upstream server.
        /// If the incoming request already has an ECS option, the
        /// prefix length (and correspondingly the address) in the ECS
        /// option is updated, with the minimum of the prefix length
        /// present in the incoming and the configured prefix length,
        /// before passing the request to upstream server.
        /// Allowed values are 1-32.
        /// </summary>
        [JsonProperty(PropertyName = "edns_client_subnet_prefix_len")]
        [NSXTProperty(IsRequired: false, Description: @"Specifies the IP address prefix length to use in the EDNSclient subnet (ECS) option.When the incoming request does not have any ECS option andthe prefix length is specified, an ECS option is inserted inthe request passed to upstream server.If the incoming request already has an ECS option, theprefix length (and correspondingly the address) in the ECSoption is updated, with the minimum of the prefix lengthpresent in the incoming and the configured prefix length,before passing the request to upstream server.Allowed values are 1-32.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(32)]
        public long? EdnsClientSubnetPrefixLen { get; set; }
        /// <summary>
        /// The <domain-name>  of the name server that was the original
        /// or primary source of data for this zone.
        /// This field is used in SOA records (mname) pertaining to all
        /// domain names specified as authoritative domain names.
        /// If not configured, domain name is used as name server in
        /// SOA response.
        /// </summary>
        [JsonProperty(PropertyName = "name_server")]
        [NSXTProperty(IsRequired: false, Description: @"The &lt;domain-name&gt;  of the name server that was the originalor primary source of data for this zone.This field is used in SOA records (mname) pertaining to alldomain names specified as authoritative domain names.If not configured, domain name is used as name server inSOA response.")]
        public string? NameServer { get; set; }
        /// <summary>
        /// Enable stripping of EDNS client subnet (ecs) option towards
        /// client if DNS service inserts ecs option in the DNS query
        /// towards upstream servers.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "ecs_stripping_enabled")]
        [NSXTProperty(IsRequired: false, Description: @"Enable stripping of EDNS client subnet (ecs) option towardsclient if DNS service inserts ecs option in the DNS querytowards upstream servers.Default value when not specified in API or module isinterpreted by ALB Controller as true.")]
        public bool? EcsStrippingEnabled { get; set; }
        /// <summary>
        /// Subdomain names serviced by this Virtual Service.
        /// These are configured as Ends-With semantics.
        /// Maximum of 100 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "domain_names")]
        [NSXTProperty(IsRequired: false, Description: @"Subdomain names serviced by this Virtual Service.These are configured as Ends-With semantics.Maximum of 100 items allowed.")]
        public IList<string> DomainNames { get; set; }
        /// <summary>
        /// Specifies the TTL value (in seconds) for SOA (Start of
        /// Authority) (corresponding to a authoritative domain owned by
        /// this DNS Virtual Service) record's minimum TTL served by the
        /// DNS Virtual Service.
        /// Allowed values are 0-86400.
        /// Unit is SEC.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 30.
        /// </summary>
        [JsonProperty(PropertyName = "negative_caching_ttl")]
        [NSXTProperty(IsRequired: false, Description: @"Specifies the TTL value (in seconds) for SOA (Start ofAuthority) (corresponding to a authoritative domain owned bythis DNS Virtual Service) record&apos;s minimum TTL served by theDNS Virtual Service.Allowed values are 0-86400.Unit is SEC.Default value when not specified in API or module isinterpreted by ALB Controller as 30.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(86400)]
        public long? NegativeCachingTtl { get; set; }
        /// <summary>
        /// Respond to AAAA queries with empty response when there are
        /// only IPV4 records.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "aaaa_empty_response")]
        [NSXTProperty(IsRequired: false, Description: @"Respond to AAAA queries with empty response when there areonly IPV4 records.Default value when not specified in API or module isinterpreted by ALB Controller as true.")]
        public bool? AaaaEmptyResponse { get; set; }
        /// <summary>
        /// Specifies the number of IP addresses returned by the DNS
        /// Service.
        /// Enter 0 to return all IP addresses.
        /// Allowed values are 1-20.
        /// Special values are 0- 'Return all IP addresses'.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 1.
        /// </summary>
        [JsonProperty(PropertyName = "num_dns_ip")]
        [NSXTProperty(IsRequired: false, Description: @"Specifies the number of IP addresses returned by the DNSService.Enter 0 to return all IP addresses.Allowed values are 1-20.Special values are 0- &apos;Return all IP addresses&apos;.Default value when not specified in API or module isinterpreted by ALB Controller as 1.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(20)]
        public long? NumDnsIp { get; set; }
        /// <summary>
        /// Drop or respond to client when the DNS service encounters
        /// an error processing a client query.
        /// By default, such a request is dropped without any response,
        /// or passed through to a passthrough pool, if configured.
        /// When set to respond, an appropriate response is sent to
        /// client, e.g.
        /// NXDOMAIN response for non-existent records, empty NOERROR
        /// response for unsupported queries, etc.
        /// Enum options - DNS_ERROR_RESPONSE_ERROR,
        /// DNS_ERROR_RESPONSE_NONE.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as DNS_ERROR_RESPONSE_NONE.
        /// </summary>
        [JsonProperty(PropertyName = "error_response")]
        [NSXTProperty(IsRequired: false, Description: @"Drop or respond to client when the DNS service encountersan error processing a client query.By default, such a request is dropped without any response,or passed through to a passthrough pool, if configured.When set to respond, an appropriate response is sent toclient, e.g.NXDOMAIN response for non-existent records, empty NOERRORresponse for unsupported queries, etc.Enum options - DNS_ERROR_RESPONSE_ERROR,DNS_ERROR_RESPONSE_NONE.Default value when not specified in API or module isinterpreted by ALB Controller as DNS_ERROR_RESPONSE_NONE.")]
        public NSXTAlbdnsServiceApplicationProfileErrorResponseEnumType? ErrorResponse { get; set; }
        /// <summary>
        /// Specifies the TTL value (in seconds) for records served by
        /// DNS Service.
        /// Allowed values are 0-86400.
        /// Unit is SEC.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 30.
        /// </summary>
        [JsonProperty(PropertyName = "ttl")]
        [NSXTProperty(IsRequired: false, Description: @"Specifies the TTL value (in seconds) for records served byDNS Service.Allowed values are 0-86400.Unit is SEC.Default value when not specified in API or module isinterpreted by ALB Controller as 30.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(86400)]
        public long? Ttl { get; set; }
        /// <summary>
        /// Enable DNS service to be aware of EDNS (Extension mechanism
        /// for DNS).
        /// EDNS extensions are parsed and shown in logs.
        /// For GSLB services, the EDNS client subnet option can be
        /// used to influence Load Balancing.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "edns")]
        [NSXTProperty(IsRequired: false, Description: @"Enable DNS service to be aware of EDNS (Extension mechanismfor DNS).EDNS extensions are parsed and shown in logs.For GSLB services, the EDNS client subnet option can beused to influence Load Balancing.Default value when not specified in API or module isinterpreted by ALB Controller as true.")]
        public bool? Edns { get; set; }
        /// <summary>
        /// Email address of the administrator responsible for this
        /// zone.
        /// This field is used in SOA records (rname) pertaining to all
        /// domain names specified as authoritative domain names.
        /// If not configured, the default value 'hostmaster' is used
        /// in SOA responses.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as hostmaster.
        /// </summary>
        [JsonProperty(PropertyName = "admin_email")]
        [NSXTProperty(IsRequired: false, Description: @"Email address of the administrator responsible for thiszone.This field is used in SOA records (rname) pertaining to alldomain names specified as authoritative domain names.If not configured, the default value &apos;hostmaster&apos; is usedin SOA responses.Default value when not specified in API or module isinterpreted by ALB Controller as hostmaster.")]
        public string? AdminEmail { get; set; }
        /// <summary>
        /// DNS zones hosted on this Virtual Service.
        /// Maximum of 100 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "dns_zones")]
        [NSXTProperty(IsRequired: false, Description: @"DNS zones hosted on this Virtual Service.Maximum of 100 items allowed.")]
        public IList<NSXTALBDnsZoneType> DnsZones { get; set; }
    }
}
