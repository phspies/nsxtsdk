// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Specify the global collector type.
    /// </summary>
    [NSXTProperty(Description: @"Specify the global collector type.")]
    public enum NSXTGlobalCollectorConfigCollectorTypeEnumType
    {
        [EnumMember(Value = "VRNI")]
        VRNI = 1,
        [EnumMember(Value = "WAVE_FRONT")]
        WAVEFRONT = 2,
    }
}