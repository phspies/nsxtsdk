// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Global rolled-up restore status value
    /// </summary>
    [NSXTProperty(Description: @"Global rolled-up restore status value")]
    public enum NSXTGlobalRestoreStatusValueEnumType
    {
        [EnumMember(Value = "INITIAL")]
        INITIAL = 1,
        [EnumMember(Value = "SUCCESS")]
        SUCCESS = 2,
        [EnumMember(Value = "FAILED")]
        FAILED = 3,
        [EnumMember(Value = "RUNNING")]
        RUNNING = 4,
        [EnumMember(Value = "SUSPENDED_BY_USER")]
        SUSPENDEDBYUSER = 5,
        [EnumMember(Value = "SUSPENDED_FOR_USER_ACTION")]
        SUSPENDEDFORUSERACTION = 6,
        [EnumMember(Value = "SUSPENDED")]
        SUSPENDED = 7,
        [EnumMember(Value = "ABORTED")]
        ABORTED = 8,
    }
}
