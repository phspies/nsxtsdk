// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Compress content automatically or add custom filters todefine compressible content and compression levels.Enum options - AUTO_COMPRESSION, CUSTOM_COMPRESSION.Default value when not specified in API or module isinterpreted by ALB Controller as AUTO_COMPRESSION.
    /// </summary>
    [NSXTProperty(Description: @"Compress content automatically or add custom filters todefine compressible content and compression levels.Enum options - AUTO_COMPRESSION, CUSTOM_COMPRESSION.Default value when not specified in API or module isinterpreted by ALB Controller as AUTO_COMPRESSION.")]
    public enum NSXTAlbcompressionProfileTypeEnumType
    {
        [EnumMember(Value = "AUTO_COMPRESSION")]
        AUTOCOMPRESSION = 1,
        [EnumMember(Value = "CUSTOM_COMPRESSION")]
        CUSTOMCOMPRESSION = 2,
    }
}
