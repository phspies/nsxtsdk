// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Sampling type
    /// </summary>
    [NSXTProperty(Description: @"Sampling type")]
    public enum NSXTSamplingArgumentSamplingTypeEnumType
    {
        [EnumMember(Value = "FIRSTNSAMPLING")]
        FirstNsampling = 1,
        [EnumMember(Value = "PACKETNUMBERSAMPLING")]
        PacketNumberSampling = 2,
        [EnumMember(Value = "INTERVALSAMPLING")]
        IntervalSampling = 3,
    }
}