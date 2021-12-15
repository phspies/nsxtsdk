// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// The operation state of live trace.IN_PROGRESS - collecting the session results.FINISHED - session results collect complete.PARTIAL_FINISHED - some ssession results may be lost.CANCELED - session cancelled by exception.TIMEOUT - session result is incomplete until timeout.
    /// </summary>
    [NSXTProperty(Description: @"The operation state of live trace.IN_PROGRESS - collecting the session results.FINISHED - session results collect complete.PARTIAL_FINISHED - some ssession results may be lost.CANCELED - session cancelled by exception.TIMEOUT - session result is incomplete until timeout.")]
    public enum NSXTLiveTraceStatusOperationStateEnumType
    {
        [EnumMember(Value = "IN_PROGRESS")]
        INPROGRESS = 1,
        [EnumMember(Value = "FINISHED")]
        FINISHED = 2,
        [EnumMember(Value = "PARTIAL_FINISHED")]
        PARTIALFINISHED = 3,
        [EnumMember(Value = "CANCELED")]
        CANCELED = 4,
        [EnumMember(Value = "TIMEOUT")]
        TIMEOUT = 5,
    }
}
