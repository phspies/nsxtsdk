// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public enum NSXTIpAssignmentSpecResourceTypeEnumType
    {
        [EnumMember(Value = "STATICIPPOOLSPEC")]
        StaticIpPoolSpec = 1,
        [EnumMember(Value = "STATICIPLISTSPEC")]
        StaticIpListSpec = 2,
        [EnumMember(Value = "ASSIGNEDBYDHCP")]
        AssignedByDhcp = 3,
        [EnumMember(Value = "STATICIPMACLISTSPEC")]
        StaticIpMacListSpec = 4,
    }
}
