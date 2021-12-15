// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// This field specifies the type of replication message TX_VTEP - Transmit replication to all VTEPs TX_MTEP - Transmit replication to all MTEPs RX - Receive replication
    /// </summary>
    [NSXTProperty(Description: @"This field specifies the type of replication message TX_VTEP - Transmit replication to all VTEPs TX_MTEP - Transmit replication to all MTEPs RX - Receive replication")]
    public enum NSXTTraceflowObservationReplicationLogicalReplicationTypeEnumType
    {
        [EnumMember(Value = "TX_VTEP")]
        TXVTEP = 1,
        [EnumMember(Value = "TX_MTEP")]
        TXMTEP = 2,
        [EnumMember(Value = "RX")]
        RX = 3,
    }
}
