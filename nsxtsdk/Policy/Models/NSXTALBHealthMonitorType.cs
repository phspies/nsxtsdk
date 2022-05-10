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
    public class NSXTALBHealthMonitorType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "https_monitor")]
        public NSXTALBHealthMonitorHttpType HttpsMonitor { get; set; }
        /// <summary>
        /// A valid response from the server is expected within the
        /// receive timeout window.
        /// This timeout must be less than the send interval.
        /// If server status is regularly flapping up and down,
        /// consider increasing this value.
        /// Allowed values are 1-2400.
        /// Unit is SEC.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 4.
        /// </summary>
        [JsonProperty(PropertyName = "receive_timeout")]
        public long? ReceiveTimeout { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "radius_monitor")]
        public NSXTALBHealthMonitorRadiusType RadiusMonitor { get; set; }
        /// <summary>
        /// Frequency, in seconds, that monitors are sent to a server.
        /// Allowed values are 1-3600.
        /// Unit is SEC.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 10.
        /// </summary>
        [JsonProperty(PropertyName = "send_interval")]
        public long? SendInterval { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "udp_monitor")]
        public NSXTALBHealthMonitorUdpType UdpMonitor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "http_monitor")]
        public NSXTALBHealthMonitorHttpType HttpMonitor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "imap_monitor")]
        public NSXTALBHealthMonitorImapType ImapMonitor { get; set; }
        /// <summary>
        /// Number of continuous successful health checks before server
        /// is marked up.
        /// Allowed values are 1-50.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 2.
        /// </summary>
        [JsonProperty(PropertyName = "successful_checks")]
        public long? SuccessfulChecks { get; set; }
        /// <summary>
        /// Use this port instead of the port defined for the server in
        /// the Pool.
        /// If the monitor succeeds to this port, the load balanced
        /// traffic will still be sent to the port of the server defined
        /// within the Pool.
        /// Allowed values are 1-65535.
        /// Special values are 0 - 'Use server port'.
        /// </summary>
        [JsonProperty(PropertyName = "monitor_port")]
        public long? MonitorPort { get; set; }
        /// <summary>
        /// By default, multiple instances of the same healthmonitor to
        /// the same server are suppressed intelligently.
        /// In rare cases, the monitor may have specific constructs
        /// that go beyond the server keys (ip, port, etc.) during which
        /// such suppression is not desired.
        /// Use this knob to allow duplicates.
        /// Allowed in Basic(Allowed values- true) edition,
        /// Essentials(Allowed values- true) edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "allow_duplicate_monitors")]
        public bool? AllowDuplicateMonitors { get; set; }
        /// <summary>
        /// During addition of a server or healthmonitors or during
        /// bootup, Avi performs sequential health checks rather than
        /// waiting for send-interval to kick in, to mark the server up
        /// as soon as possible.
        /// This knob may be used to turn this feature off.
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "disable_quickstart")]
        public bool? DisableQuickstart { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "dns_monitor")]
        public NSXTALBHealthMonitorDNSType DnsMonitor { get; set; }
        /// <summary>
        /// This field describes the object's replication scope.
        /// If the field is set to false, then the object is visible
        /// within the controller-cluster and its associated
        /// service-engines.
        /// If the field is set to true, then the object is replicated
        /// across the federation.
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "is_federated")]
        public bool? IsFederated { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "smtp_monitor")]
        public NSXTALBHealthMonitorSmtpType SmtpMonitor { get; set; }
        /// <summary>
        /// Number of continuous failed health checks before the server
        /// is marked down.
        /// Allowed values are 1-50.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 2.
        /// </summary>
        [JsonProperty(PropertyName = "failed_checks")]
        public long? FailedChecks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "tcp_monitor")]
        public NSXTALBHealthMonitorTcpType TcpMonitor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "authentication")]
        public NSXTALBHealthMonitorAuthInfoType Authentication { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "pop3_monitor")]
        public NSXTALBHealthMonitorPop3Type Pop3Monitor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "pop3s_monitor")]
        public NSXTALBHealthMonitorPop3Type Pop3sMonitor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "smtps_monitor")]
        public NSXTALBHealthMonitorSmtpType SmtpsMonitor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "external_monitor")]
        public NSXTALBHealthMonitorExternalType ExternalMonitor { get; set; }
        /// <summary>
        /// Type of the health monitor.
        /// Enum options - HEALTH_MONITOR_PING, HEALTH_MONITOR_TCP,
        /// HEALTH_MONITOR_HTTP, HEALTH_MONITOR_HTTPS,
        /// HEALTH_MONITOR_EXTERNAL, HEALTH_MONITOR_UDP,
        /// HEALTH_MONITOR_DNS, HEALTH_MONITOR_GSLB, HEALTH_MONITOR_SIP,
        /// HEALTH_MONITOR_RADIUS, HEALTH_MONITOR_SMTP,
        /// HEALTH_MONITOR_SMTPS, HEALTH_MONITOR_POP3,
        /// HEALTH_MONITOR_POP3S, HEALTH_MONITOR_IMAP,
        /// HEALTH_MONITOR_IMAPS.
        /// Allowed in Basic(Allowed values-
        /// HEALTH_MONITOR_PING,HEALTH_MONITOR_TCP,HEALTH_MONITOR_UDP,HEALTH_MONITOR_HTTP,HEALTH_MONITOR_HTTPS)
        /// edition, Essentials(Allowed values-
        /// HEALTH_MONITOR_PING,HEALTH_MONITOR_TCP,HEALTH_MONITOR_UDP)
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbhealthMonitorTypeEnumType Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "imaps_monitor")]
        public NSXTALBHealthMonitorImapType ImapsMonitor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "sip_monitor")]
        public NSXTALBHealthMonitorSIPType SipMonitor { get; set; }
    }
}
