// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// BGP community type. It has two types asNormalBGPCommunity BGP normal community which includes well-knowncommunity name as well as community value in range from [1-4294967295]or value in aa:nn format(aa/nn range from 1-65535).LargeBGPCommunity BGP large community which includes community valuein aa:bb:nn format where aa, bb, nn are unsigned integers in the range[1-4294967295].
    /// </summary>
    [NSXTProperty(Description: @"BGP community type. It has two types asNormalBGPCommunity BGP normal community which includes well-knowncommunity name as well as community value in range from [1-4294967295]or value in aa:nn format(aa/nn range from 1-65535).LargeBGPCommunity BGP large community which includes community valuein aa:bb:nn format where aa, bb, nn are unsigned integers in the range[1-4294967295].")]
    public enum NSXTBgpcommunityListCommunityTypeEnumType
    {
        [EnumMember(Value = "NORMALBGPCOMMUNITY")]
        NormalBgpcommunity = 1,
        [EnumMember(Value = "LARGEBGPCOMMUNITY")]
        LargeBgpcommunity = 2,
    }
}
