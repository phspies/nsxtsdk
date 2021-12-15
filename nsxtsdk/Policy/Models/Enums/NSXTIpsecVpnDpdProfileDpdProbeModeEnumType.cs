// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// DPD probe mode is used to query the liveliness of the peer. Two modesare possible:- PERIODIC: is used to query the liveliness of the peer at regularintervals (dpd_probe_interval). It does not take into considerationtraffic coming from the peer.The benefit of this mode over the on-demand mode is earlier detection ofdead peers. However, use of periodic DPD incurs extra overhead. Whencommunicating to large numbers of peers, please consider using on-demandDPD instead.- ON_DEMAND: is used to query the liveliness of the peer by instructingthe local endpoint to send DPD message to a peer if there is traffic tosend to the peer AND the peer was idle for dpd_probe_interval seconds(i.e. there was no traffic from the peer for dpd_probe_interval seconds).
    /// </summary>
    [NSXTProperty(Description: @"DPD probe mode is used to query the liveliness of the peer. Two modesare possible:- PERIODIC: is used to query the liveliness of the peer at regularintervals (dpd_probe_interval). It does not take into considerationtraffic coming from the peer.The benefit of this mode over the on-demand mode is earlier detection ofdead peers. However, use of periodic DPD incurs extra overhead. Whencommunicating to large numbers of peers, please consider using on-demandDPD instead.- ON_DEMAND: is used to query the liveliness of the peer by instructingthe local endpoint to send DPD message to a peer if there is traffic tosend to the peer AND the peer was idle for dpd_probe_interval seconds(i.e. there was no traffic from the peer for dpd_probe_interval seconds).")]
    public enum NSXTIpsecVpnDpdProfileDpdProbeModeEnumType
    {
        [EnumMember(Value = "PERIODIC")]
        PERIODIC = 1,
        [EnumMember(Value = "ON_DEMAND")]
        ONDEMAND = 2,
    }
}