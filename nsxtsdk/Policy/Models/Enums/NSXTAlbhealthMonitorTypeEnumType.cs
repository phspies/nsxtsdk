// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Type of the health monitor.Enum options - HEALTH_MONITOR_PING, HEALTH_MONITOR_TCP,HEALTH_MONITOR_HTTP, HEALTH_MONITOR_HTTPS,HEALTH_MONITOR_EXTERNAL, HEALTH_MONITOR_UDP,HEALTH_MONITOR_DNS, HEALTH_MONITOR_GSLB, HEALTH_MONITOR_SIP,HEALTH_MONITOR_RADIUS, HEALTH_MONITOR_SMTP,HEALTH_MONITOR_SMTPS, HEALTH_MONITOR_POP3,HEALTH_MONITOR_POP3S, HEALTH_MONITOR_IMAP,HEALTH_MONITOR_IMAPS.Allowed in Basic(Allowed values-HEALTH_MONITOR_PING,HEALTH_MONITOR_TCP,HEALTH_MONITOR_UDP,HEALTH_MONITOR_HTTP,HEALTH_MONITOR_HTTPS)edition, Essentials(Allowed values-HEALTH_MONITOR_PING,HEALTH_MONITOR_TCP,HEALTH_MONITOR_UDP)edition, Enterprise edition.
    /// </summary>
    [NSXTProperty(Description: @"Type of the health monitor.Enum options - HEALTH_MONITOR_PING, HEALTH_MONITOR_TCP,HEALTH_MONITOR_HTTP, HEALTH_MONITOR_HTTPS,HEALTH_MONITOR_EXTERNAL, HEALTH_MONITOR_UDP,HEALTH_MONITOR_DNS, HEALTH_MONITOR_GSLB, HEALTH_MONITOR_SIP,HEALTH_MONITOR_RADIUS, HEALTH_MONITOR_SMTP,HEALTH_MONITOR_SMTPS, HEALTH_MONITOR_POP3,HEALTH_MONITOR_POP3S, HEALTH_MONITOR_IMAP,HEALTH_MONITOR_IMAPS.Allowed in Basic(Allowed values-HEALTH_MONITOR_PING,HEALTH_MONITOR_TCP,HEALTH_MONITOR_UDP,HEALTH_MONITOR_HTTP,HEALTH_MONITOR_HTTPS)edition, Essentials(Allowed values-HEALTH_MONITOR_PING,HEALTH_MONITOR_TCP,HEALTH_MONITOR_UDP)edition, Enterprise edition.")]
    public enum NSXTAlbhealthMonitorTypeEnumType
    {
        [EnumMember(Value = "HEALTH_MONITOR_PING")]
        HEALTHMONITORPING = 1,
        [EnumMember(Value = "HEALTH_MONITOR_TCP")]
        HEALTHMONITORTCP = 2,
        [EnumMember(Value = "HEALTH_MONITOR_HTTP")]
        HEALTHMONITORHTTP = 3,
        [EnumMember(Value = "HEALTH_MONITOR_HTTPS")]
        HEALTHMONITORHTTPS = 4,
        [EnumMember(Value = "HEALTH_MONITOR_EXTERNAL")]
        HEALTHMONITOREXTERNAL = 5,
        [EnumMember(Value = "HEALTH_MONITOR_UDP")]
        HEALTHMONITORUDP = 6,
        [EnumMember(Value = "HEALTH_MONITOR_DNS")]
        HEALTHMONITORDNS = 7,
        [EnumMember(Value = "HEALTH_MONITOR_GSLB")]
        HEALTHMONITORGSLB = 8,
        [EnumMember(Value = "HEALTH_MONITOR_SIP")]
        HEALTHMONITORSIP = 9,
        [EnumMember(Value = "HEALTH_MONITOR_RADIUS")]
        HEALTHMONITORRADIUS = 10,
        [EnumMember(Value = "HEALTH_MONITOR_SMTP")]
        HEALTHMONITORSMTP = 11,
        [EnumMember(Value = "HEALTH_MONITOR_SMTPS")]
        HEALTHMONITORSMTPS = 12,
        [EnumMember(Value = "HEALTH_MONITOR_POP3")]
        HEALTHMONITORPOP3 = 13,
        [EnumMember(Value = "HEALTH_MONITOR_POP3S")]
        HEALTHMONITORPOP3S = 14,
        [EnumMember(Value = "HEALTH_MONITOR_IMAP")]
        HEALTHMONITORIMAP = 15,
        [EnumMember(Value = "HEALTH_MONITOR_IMAPS")]
        HEALTHMONITORIMAPS = 16,
    }
}
