// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Resource Type of Enforcement Point Connection Info.
    /// </summary>
    [NSXTProperty(Description: @"Resource Type of Enforcement Point Connection Info.")]
    public enum NSXTEnforcementPointConnectionInfoResourceTypeEnumType
    {
        [EnumMember(Value = "NSXTCONNECTIONINFO")]
        NsxtconnectionInfo = 1,
        [EnumMember(Value = "NSXVCONNECTIONINFO")]
        NsxvconnectionInfo = 2,
        [EnumMember(Value = "CVXCONNECTIONINFO")]
        CvxConnectionInfo = 3,
        [EnumMember(Value = "AVICONNECTIONINFO")]
        AviConnectionInfo = 4,
    }
}
