// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Firewall status for a fabric entity or in global context where firewall is supported.
    /// </summary>
    [NSXTProperty(Description: @"Firewall status for a fabric entity or in global context where firewall is supported.")]
    public enum NSXTFirewallStatusGlobalStatusEnumType
    {
        [EnumMember(Value = "DISABLED")]
        DISABLED = 1,
        [EnumMember(Value = "ENABLED")]
        ENABLED = 2,
    }
}