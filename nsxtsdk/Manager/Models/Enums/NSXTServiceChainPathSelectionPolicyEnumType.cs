// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Path selection policy can be - ANY - Service Insertion is free to redirect to any service path regardless of any load balancing considerations or flow pinning. LOCAL - means to prefer local service insances. REMOTE - preference is to redirect to the SVM co-located on the same host.
    /// </summary>
    [NSXTProperty(Description: @"Path selection policy can be - ANY - Service Insertion is free to redirect to any service path regardless of any load balancing considerations or flow pinning. LOCAL - means to prefer local service insances. REMOTE - preference is to redirect to the SVM co-located on the same host.")]
    public enum NSXTServiceChainPathSelectionPolicyEnumType
    {
        [EnumMember(Value = "ANY")]
        ANY = 1,
        [EnumMember(Value = "LOCAL")]
        LOCAL = 2,
        [EnumMember(Value = "REMOTE")]
        REMOTE = 3,
    }
}
