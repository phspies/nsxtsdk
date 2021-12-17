// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// the present realized maintenance mode state
    /// </summary>
    [NSXTProperty(Description: @"the present realized maintenance mode state")]
    public enum NSXTTransportNodeStateMaintenanceModeStateEnumType
    {
        [EnumMember(Value = "ENTERING")]
        ENTERING = 1,
        [EnumMember(Value = "ENABLED")]
        ENABLED = 2,
        [EnumMember(Value = "EXITING")]
        EXITING = 3,
        [EnumMember(Value = "DISABLED")]
        DISABLED = 4,
    }
}
