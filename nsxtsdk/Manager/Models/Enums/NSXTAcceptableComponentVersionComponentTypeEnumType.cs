// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Node type
    /// </summary>
    [NSXTProperty(Description: @"Node type")]
    public enum NSXTAcceptableComponentVersionComponentTypeEnumType
    {
        [EnumMember(Value = "HOST")]
        HOST = 1,
        [EnumMember(Value = "EDGE")]
        EDGE = 2,
        [EnumMember(Value = "CCP")]
        CCP = 3,
        [EnumMember(Value = "MP")]
        MP = 4,
    }
}