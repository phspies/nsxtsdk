// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Does site have active GM
    /// </summary>
    [NSXTProperty(Description: @"Does site have active GM")]
    public enum NSXTFederationSiteActiveGmEnumType
    {
        [EnumMember(Value = "ACTIVE")]
        ACTIVE = 1,
        [EnumMember(Value = "STANDBY")]
        STANDBY = 2,
        [EnumMember(Value = "NONE")]
        NONE = 3,
        [EnumMember(Value = "INVALID")]
        INVALID = 4,
    }
}
