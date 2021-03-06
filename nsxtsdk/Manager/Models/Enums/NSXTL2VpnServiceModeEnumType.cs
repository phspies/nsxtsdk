// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Specify an L2VPN service mode as SERVER or CLIENT. L2VPN servicein SERVER mode requires user to configure L2VPN session explicitly.L2VPN service in CLIENT mode can use peercode generated from SERVERto configure L2VPN session.
    /// </summary>
    [NSXTProperty(Description: @"Specify an L2VPN service mode as SERVER or CLIENT. L2VPN servicein SERVER mode requires user to configure L2VPN session explicitly.L2VPN service in CLIENT mode can use peercode generated from SERVERto configure L2VPN session.")]
    public enum NSXTL2VpnServiceModeEnumType
    {
        [EnumMember(Value = "SERVER")]
        SERVER = 1,
        [EnumMember(Value = "CLIENT")]
        CLIENT = 2,
    }
}
