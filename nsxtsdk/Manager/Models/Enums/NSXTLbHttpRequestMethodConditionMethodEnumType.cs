// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Type of HTTP request method
    /// </summary>
    [NSXTProperty(Description: @"Type of HTTP request method")]
    public enum NSXTLbHttpRequestMethodConditionMethodEnumType
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
