// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Path selection policy can be - ANY - Service Insertion is free to redirect to any service path regardless of any load balancing considerations or flow pinning. LOCAL - Preference to be given to local service insances. REMOTE - Preference to be given to the SVM co-located on the same host. ROUND_ROBIN - All active service paths are hit with equal probability.
    /// </summary>
    [NSXTProperty(Description: @"Path selection policy can be - ANY - Service Insertion is free to redirect to any service path regardless of any load balancing considerations or flow pinning. LOCAL - Preference to be given to local service insances. REMOTE - Preference to be given to the SVM co-located on the same host. ROUND_ROBIN - All active service paths are hit with equal probability.")]
    public enum NSXTPolicyServiceChainPathSelectionPolicyEnumType
    {
        [EnumMember(Value = "ANY")]
        ANY = 1,
        [EnumMember(Value = "LOCAL")]
        LOCAL = 2,
        [EnumMember(Value = "REMOTE")]
        REMOTE = 3,
        [EnumMember(Value = "ROUND_ROBIN")]
        ROUNDROBIN = 4,
    }
}