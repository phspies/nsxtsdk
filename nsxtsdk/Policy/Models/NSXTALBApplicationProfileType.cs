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
    public class NSXTALBApplicationProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "tcp_app_profile")]
        public NSXTALBTCPApplicationProfileType TcpAppProfile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "dns_service_profile")]
        public NSXTALBDnsServiceApplicationProfileType DnsServiceProfile { get; set; }
        /// <summary>
        /// Specifies which application layer proxy is enabled for the
        /// virtual service.
        /// Enum options - APPLICATION_PROFILE_TYPE_L4,
        /// APPLICATION_PROFILE_TYPE_HTTP,
        /// APPLICATION_PROFILE_TYPE_SYSLOG,
        /// APPLICATION_PROFILE_TYPE_DNS, APPLICATION_PROFILE_TYPE_SSL,
        /// APPLICATION_PROFILE_TYPE_SIP.
        /// Allowed in Basic(Allowed values-
        /// APPLICATION_PROFILE_TYPE_L4,APPLICATION_PROFILE_TYPE_HTTP)
        /// edition, Essentials(Allowed values-
        /// APPLICATION_PROFILE_TYPE_L4) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbapplicationProfileTypeEnumType Type { get; set; }
        /// <summary>
        /// Specifies if destination IP and port needs to be preserved
        /// for backend connection.
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "preserve_dest_ip_port")]
        public bool? PreserveDestIpPort { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "sip_service_profile")]
        public NSXTALBSipServiceApplicationProfileType SipServiceProfile { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
        /// <summary>
        /// Specifies if we need to preserve client port while
        /// preserving client IP for backend connections.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "preserve_client_port")]
        public bool? PreserveClientPort { get; set; }
        /// <summary>
        /// Checksum of application profiles.
        /// Internally set by cloud connector.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_config_cksum")]
        public string? CloudConfigCksum { get; set; }
        /// <summary>
        /// Name of the application profile creator.
        /// </summary>
        [JsonProperty(PropertyName = "created_by")]
        public string? CreatedBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "dos_rl_profile")]
        public NSXTALBDosRateLimitProfileType DosRlProfile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "http_profile")]
        public NSXTALBHTTPApplicationProfileType HttpProfile { get; set; }
        /// <summary>
        /// Specifies if client IP needs to be preserved for backend
        /// connection.
        /// Not compatible with Connection Multiplexing.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "preserve_client_ip")]
        public bool? PreserveClientIp { get; set; }
    }
}
