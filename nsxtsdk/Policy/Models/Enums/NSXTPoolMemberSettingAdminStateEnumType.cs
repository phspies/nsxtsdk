// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Member admin state
    /// </summary>
    [NSXTProperty(Description: @"Member admin state")]
    public enum NSXTPoolMemberSettingAdminStateEnumType
    {
        [EnumMember(Value = "ENABLED")]
        ENABLED = 1,
        [EnumMember(Value = "DISABLED")]
        DISABLED = 2,
        [EnumMember(Value = "GRACEFUL_DISABLED")]
        GRACEFULDISABLED = 3,
    }
}
