// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Type of the resource on which this expression is evaluated
    /// </summary>
    [NSXTProperty(Description: @"Type of the resource on which this expression is evaluated")]
    public enum NSXTNsgroupSimpleExpressionTargetTypeEnumType
    {
        [EnumMember(Value = "NSGROUP")]
        Nsgroup = 1,
        [EnumMember(Value = "IPSET")]
        Ipset = 2,
        [EnumMember(Value = "MACSET")]
        Macset = 3,
        [EnumMember(Value = "LOGICALSWITCH")]
        LogicalSwitch = 4,
        [EnumMember(Value = "LOGICALPORT")]
        LogicalPort = 5,
        [EnumMember(Value = "VIRTUALMACHINE")]
        VirtualMachine = 6,
        [EnumMember(Value = "DIRECTORYGROUP")]
        DirectoryGroup = 7,
        [EnumMember(Value = "VIRTUALNETWORKINTERFACE")]
        VirtualNetworkInterface = 8,
        [EnumMember(Value = "TRANSPORTNODE")]
        TransportNode = 9,
        [EnumMember(Value = "CLOUDNATIVESERVICEINSTANCE")]
        CloudNativeServiceInstance = 10,
        [EnumMember(Value = "PHYSICALSERVER")]
        PhysicalServer = 11,
        [EnumMember(Value = "LOGICALROUTER")]
        LogicalRouter = 12,
        [EnumMember(Value = "LOGICALROUTERPORT")]
        LogicalRouterPort = 13,
    }
}
