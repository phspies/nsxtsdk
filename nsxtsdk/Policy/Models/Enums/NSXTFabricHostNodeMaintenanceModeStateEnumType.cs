// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Indicates host node&apos;s maintenance mode state. The state is ENTERINGwhen a task to put the host in maintenance-mode is in progress.
    /// </summary>
    [NSXTProperty(Description: @"Indicates host node&apos;s maintenance mode state. The state is ENTERINGwhen a task to put the host in maintenance-mode is in progress.")]
    public enum NSXTFabricHostNodeMaintenanceModeStateEnumType
    {
        [EnumMember(Value = "OFF")]
        OFF = 1,
        [EnumMember(Value = "ENTERING")]
        ENTERING = 2,
        [EnumMember(Value = "ON")]
        ON = 3,
    }
}
