// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// The type of the MAC address
    /// </summary>
    [NSXTProperty(Description: @"The type of the MAC address")]
    public enum NSXTSegmentPortMacTableCsvEntryMacTypeEnumType
    {
        [EnumMember(Value = "STATIC")]
        STATIC = 1,
        [EnumMember(Value = "LEARNED")]
        LEARNED = 2,
    }
}