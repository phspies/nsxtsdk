// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Pre-defined config settings. Settings could be one of Balanced, High Fidelity, High Security, Custom
    /// </summary>
    [NSXTProperty(Description: @"Pre-defined config settings. Settings could be one of Balanced, High Fidelity, High Security, Custom")]
    public enum NSXTTlsInspectionExternalProfileTlsConfigSettingEnumType
    {
        [EnumMember(Value = "BALANCED")]
        BALANCED = 1,
        [EnumMember(Value = "HIGH_FIDELITY")]
        HIGHFIDELITY = 2,
        [EnumMember(Value = "HIGH_SECURITY")]
        HIGHSECURITY = 3,
        [EnumMember(Value = "CUSTOM")]
        CUSTOM = 4,
    }
}