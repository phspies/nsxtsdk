// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// If more than one match condition is specified, thenmatching strategy determines if all conditions should match or anyone condition should match for the LB Rule to be considered a match.- ALL indicates that both host_match and path_match must match forthis LBRule to be considered a match.- ANY indicates that either host_match or patch match may match forthis LBRule to be considered a match.
    /// </summary>
    [NSXTProperty(Description: @"If more than one match condition is specified, thenmatching strategy determines if all conditions should match or anyone condition should match for the LB Rule to be considered a match.- ALL indicates that both host_match and path_match must match forthis LBRule to be considered a match.- ANY indicates that either host_match or patch match may match forthis LBRule to be considered a match.")]
    public enum NSXTLbruleMatchStrategyEnumType
    {
        [EnumMember(Value = "ALL")]
        ALL = 1,
        [EnumMember(Value = "ANY")]
        ANY = 0,
    }
}
