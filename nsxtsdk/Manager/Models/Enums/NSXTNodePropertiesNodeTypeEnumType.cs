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
    public enum NSXTNodePropertiesNodeTypeEnumType
    {
        [EnumMember(Value = "NSX_MANAGER")]
        NSXManager = 1,
        [EnumMember(Value = "NSX_GLOBAL_MANAGER")]
        NSXGlobalManager = 2,
        [EnumMember(Value = "NSX_EDGE")]
        NSXEdge = 3,
        [EnumMember(Value = "NSX_AUTONOMOUS_EDGE")]
        NSXAutonomousEdge = 4,
        [EnumMember(Value = "NSX_CLOUD_SERVICE_MANAGER")]
        NSXCloudServiceManager = 5,
        [EnumMember(Value = "NSX_PUBLIC_CLOUD_GATEWAY")]
        NSXPublicCloudGateway = 6,
    }
}