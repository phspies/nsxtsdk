// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// State of the BFD session
    /// </summary>
    [NSXTProperty(Description: @"State of the BFD session")]
    public enum NSXTBfdpropertiesStateEnumType
    {
        [EnumMember(Value = "UNKNOWN_STATE")]
        UNKNOWNSTATE = 1,
        [EnumMember(Value = "ADMIN_DOWN")]
        ADMINDOWN = 2,
        [EnumMember(Value = "DOWN")]
        DOWN = 3,
        [EnumMember(Value = "INIT")]
        INIT = 4,
        [EnumMember(Value = "UP")]
        UP = 5,
    }
}
