// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Specifies Container Network Interface type for container cluster.
    /// </summary>
    [NSXTProperty(Description: @"Specifies Container Network Interface type for container cluster.")]
    public enum NSXTContainerClusterCniTypeEnumType
    {
        [EnumMember(Value = "NCP")]
        NCP = 1,
        [EnumMember(Value = "ANTREA")]
        Antrea = 2,
        [EnumMember(Value = "OTHER")]
        Other = 0,
    }
}
