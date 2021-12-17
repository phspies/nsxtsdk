// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Indicates the fabric node&apos;s LCP&amp;lt;-&amp;gt;CCP channel connectivity status, UP, DOWN, DEGRADED, UNKNOWN.
    /// </summary>
    [NSXTProperty(Description: @"Indicates the fabric node&apos;s LCP&amp;lt;-&amp;gt;CCP channel connectivity status, UP, DOWN, DEGRADED, UNKNOWN.")]
    public enum NSXTNodeStatusLcpConnectivityStatusEnumType
    {
        [EnumMember(Value = "UP")]
        UP = 1,
        [EnumMember(Value = "DOWN")]
        DOWN = 2,
        [EnumMember(Value = "DEGRADED")]
        DEGRADED = 3,
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 0,
    }
}