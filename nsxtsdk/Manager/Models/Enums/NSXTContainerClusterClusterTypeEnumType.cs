// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Type of the container cluster. In case of creating container clusterfirst time, it is expected to pass the valid cluster-type.In case of update, if there is no change in cluster-type, then thisfield can be omitted in the request.
    /// </summary>
    [NSXTProperty(Description: @"Type of the container cluster. In case of creating container clusterfirst time, it is expected to pass the valid cluster-type.In case of update, if there is no change in cluster-type, then thisfield can be omitted in the request.")]
    public enum NSXTContainerClusterClusterTypeEnumType
    {
        [EnumMember(Value = "PAS")]
        PAS = 1,
        [EnumMember(Value = "PKS")]
        PKS = 2,
        [EnumMember(Value = "KUBERNETES")]
        Kubernetes = 3,
        [EnumMember(Value = "OPENSHIFT")]
        Openshift = 4,
        [EnumMember(Value = "WCP")]
        WCP = 5,
        [EnumMember(Value = "WCP_GUEST")]
        WCPGuest = 6,
        [EnumMember(Value = "OTHER")]
        Other = 7,
    }
}
