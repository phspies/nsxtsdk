// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// ALLOW means connections matching grouping object IP list are allowedand requests not matching grouping object IP list are dropped.DROP means connections matching grouping object IP list are droppedand requests not matching grouping object IP list are allowed.
    /// </summary>
    [NSXTProperty(Description: @"ALLOW means connections matching grouping object IP list are allowedand requests not matching grouping object IP list are dropped.DROP means connections matching grouping object IP list are droppedand requests not matching grouping object IP list are allowed.")]
    public enum NSXTLbaccessListControlActionEnumType
    {
        [EnumMember(Value = "ALLOW")]
        ALLOW = 1,
        [EnumMember(Value = "DROP")]
        DROP = 2,
    }
}
