// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// This indicates the deployment perimeter, such as a VC cluster or a host.
    /// </summary>
    [NSXTProperty(Description: @"This indicates the deployment perimeter, such as a VC cluster or a host.")]
    public enum NSXTServiceDeploymentPerimeterEnumType
    {
        [EnumMember(Value = "CLUSTER")]
        CLUSTER = 1,
        [EnumMember(Value = "HOST")]
        HOST = 0,
    }
}
