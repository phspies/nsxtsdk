// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// UP means that all primary members are in UP status.PARTIALLY_UP means that some(not all) primary members are in UPstatus, the number of these active members is larger or equal tocertain number(min_active_members) which is defined in LbPool.When there are no backup members which are in the UP status, thenumber(min_active_members) would be ignored.PRIMARY_DOWN means that less than certain(min_active_members) primarymembers are in UP status but backup members are in UP status,connections to this pool would be dispatched to backup members.DOWN means that all primary and backup members are DOWN.DETACHED means that the pool is not bound to any virtual server.UNKNOWN means that the pool is not associated to any enabled virtualservers, or no status reported from transport-nodes, the associatedload balancer service may be working(or not working).
    /// </summary>
    [NSXTProperty(Description: @"UP means that all primary members are in UP status.PARTIALLY_UP means that some(not all) primary members are in UPstatus, the number of these active members is larger or equal tocertain number(min_active_members) which is defined in LbPool.When there are no backup members which are in the UP status, thenumber(min_active_members) would be ignored.PRIMARY_DOWN means that less than certain(min_active_members) primarymembers are in UP status but backup members are in UP status,connections to this pool would be dispatched to backup members.DOWN means that all primary and backup members are DOWN.DETACHED means that the pool is not bound to any virtual server.UNKNOWN means that the pool is not associated to any enabled virtualservers, or no status reported from transport-nodes, the associatedload balancer service may be working(or not working).")]
    public enum NSXTLbPoolStatusStatusEnumType
    {
        [EnumMember(Value = "UP")]
        UP = 1,
        [EnumMember(Value = "PARTIALLY_UP")]
        PARTIALLYUP = 2,
        [EnumMember(Value = "PRIMARY_DOWN")]
        PRIMARYDOWN = 3,
        [EnumMember(Value = "DOWN")]
        DOWN = 4,
        [EnumMember(Value = "DETACHED")]
        DETACHED = 5,
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 6,
    }
}
