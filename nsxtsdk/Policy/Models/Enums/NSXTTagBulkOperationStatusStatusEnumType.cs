// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Overall status
    /// </summary>
    [NSXTProperty(Description: @"Overall status")]
    public enum NSXTTagBulkOperationStatusStatusEnumType
    {
        [EnumMember(Value = "SUCCESS")]
        Success = 1,
        [EnumMember(Value = "RUNNING")]
        Running = 2,
        [EnumMember(Value = "ERROR")]
        Error = 3,
        [EnumMember(Value = "PENDING")]
        Pending = 4,
    }
}