// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Profile type of the ServiceConfig
    /// </summary>
    [NSXTProperty(Description: @"Profile type of the ServiceConfig")]
    public enum NSXTNsxprofileReferenceProfileTypeEnumType
    {
        [EnumMember(Value = "FIREWALLSESSIONTIMERPROFILE")]
        FirewallSessionTimerProfile = 1,
        [EnumMember(Value = "FIREWALLCPUMEMTHRESHOLDSPROFILE")]
        FirewallCpuMemThresholdsProfile = 2,
        [EnumMember(Value = "GISERVICEPROFILE")]
        GiServiceProfile = 3,
        [EnumMember(Value = "FIREWALLFLOODPROTECTIONPROFILE")]
        FirewallFloodProtectionProfile = 4,
        [EnumMember(Value = "FIREWALLDNSPROFILE")]
        FirewallDnsProfile = 5,
        [EnumMember(Value = "LATENCYSTATPROFILE")]
        LatencyStatProfile = 6,
        [EnumMember(Value = "SHAPROFILE")]
        Shaprofile = 7,
        [EnumMember(Value = "IPDISCOVERYSWITCHINGUPMPROFILE")]
        IpDiscoverySwitchingUpmProfile = 8,
        [EnumMember(Value = "SYSTEMHEALTHPLUGINPROFILE")]
        SystemHealthPluginProfile = 9,
        [EnumMember(Value = "GENERALSECURITYSETTINGSPROFILE")]
        GeneralSecuritySettingsProfile = 10,
        [EnumMember(Value = "IPFIXSWITCHUPMPROFILE")]
        IpfixSwitchUpmProfile = 11,
        [EnumMember(Value = "IPFIXCOLLECTORUPMPROFILE")]
        IpfixCollectorUpmProfile = 12,
        [EnumMember(Value = "PACEHOSTCONFIGPROFILE")]
        PaceHostConfigProfile = 13,
        [EnumMember(Value = "COMMONAGENTHOSTCONFIGPROFILE")]
        CommonAgentHostConfigProfile = 14,
    }
}
