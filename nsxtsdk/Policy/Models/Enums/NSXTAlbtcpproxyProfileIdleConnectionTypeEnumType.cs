// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Controls the behavior of idle connections.Enum options - KEEP_ALIVE, CLOSE_IDLE.Default value when not specified in API or module isinterpreted by ALB Controller as KEEP_ALIVE.
    /// </summary>
    [NSXTProperty(Description: @"Controls the behavior of idle connections.Enum options - KEEP_ALIVE, CLOSE_IDLE.Default value when not specified in API or module isinterpreted by ALB Controller as KEEP_ALIVE.")]
    public enum NSXTAlbtcpproxyProfileIdleConnectionTypeEnumType
    {
        [EnumMember(Value = "KEEP_ALIVE")]
        KEEPALIVE = 1,
        [EnumMember(Value = "CLOSE_IDLE")]
        CLOSEIDLE = 2,
    }
}