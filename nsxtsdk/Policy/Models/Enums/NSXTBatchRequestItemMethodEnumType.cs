// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// http method type
    /// </summary>
    [NSXTProperty(Description: @"http method type")]
    public enum NSXTBatchRequestItemMethodEnumType
    {
        [EnumMember(Value = "GET")]
        GET = 1,
        [EnumMember(Value = "POST")]
        POST = 2,
        [EnumMember(Value = "PUT")]
        PUT = 3,
        [EnumMember(Value = "DELETE")]
        DELETE = 4,
        [EnumMember(Value = "PATCH")]
        PATCH = 5,
    }
}
