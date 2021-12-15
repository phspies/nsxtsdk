// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// The health check method for HTTP monitor type.
    /// </summary>
    [NSXTProperty(Description: @"The health check method for HTTP monitor type.")]
    public enum NSXTLbhttpsMonitorProfileRequestMethodEnumType
    {
        [EnumMember(Value = "GET")]
        GET = 1,
        [EnumMember(Value = "OPTIONS")]
        OPTIONS = 2,
        [EnumMember(Value = "POST")]
        POST = 3,
        [EnumMember(Value = "HEAD")]
        HEAD = 4,
        [EnumMember(Value = "PUT")]
        PUT = 5,
    }
}
