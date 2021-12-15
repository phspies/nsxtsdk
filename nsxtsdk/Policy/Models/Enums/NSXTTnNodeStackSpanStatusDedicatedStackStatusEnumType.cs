// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Show the dedicated mirror stack health status, if the TN node has the mirrorstack, it will show SUCCESS or it will show FAILED.
    /// </summary>
    [NSXTProperty(Description: @"Show the dedicated mirror stack health status, if the TN node has the mirrorstack, it will show SUCCESS or it will show FAILED.")]
    public enum NSXTTnNodeStackSpanStatusDedicatedStackStatusEnumType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 1,
        [EnumMember(Value = "SUCCESS")]
        SUCCESS = 2,
        [EnumMember(Value = "FAILED")]
        FAILED = 3,
    }
}
