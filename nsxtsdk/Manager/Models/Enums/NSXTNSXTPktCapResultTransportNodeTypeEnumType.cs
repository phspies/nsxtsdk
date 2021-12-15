// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Type of the transport node
    /// </summary>
    [NSXTProperty(Description: @"Type of the transport node")]
    public enum NSXTPktCapResultTransportNodeTypeEnumType
    {
        [EnumMember(Value = "ESX")]
        ESX = 1,
        [EnumMember(Value = "RHELKVM")]
        RHELKVM = 2,
        [EnumMember(Value = "UBUNTUKVM")]
        UBUNTUKVM = 3,
        [EnumMember(Value = "CENTOSKVM")]
        CENTOSKVM = 4,
        [EnumMember(Value = "RHELCONTAINER")]
        RHELCONTAINER = 5,
        [EnumMember(Value = "CENTOSCONTAINER")]
        CENTOSCONTAINER = 6,
        [EnumMember(Value = "RHELSERVER")]
        RHELSERVER = 7,
        [EnumMember(Value = "UBUNTUSERVER")]
        UBUNTUSERVER = 8,
        [EnumMember(Value = "CENTOSSERVER")]
        CENTOSSERVER = 9,
        [EnumMember(Value = "SLESKVM")]
        SLESKVM = 10,
        [EnumMember(Value = "SLESSERVER")]
        SLESSERVER = 11,
        [EnumMember(Value = "WINDOWSSERVER")]
        WINDOWSSERVER = 12,
        [EnumMember(Value = "RHELSMARTNIC")]
        RHELSMARTNIC = 13,
        [EnumMember(Value = "OELSERVER")]
        OELSERVER = 14,
        [EnumMember(Value = "UBUNTUSMARTNIC")]
        UBUNTUSMARTNIC = 15,
        [EnumMember(Value = "EDGE")]
        EDGE = 16,
        [EnumMember(Value = "PUBLIC_CLOUD_GATEWAY_NODE")]
        PUBLICCLOUDGATEWAYNODE = 17,
        [EnumMember(Value = "OTHERS")]
        OTHERS = 18,
        [EnumMember(Value = "HYPERV")]
        HYPERV = 19,
    }
}
