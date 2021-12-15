// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Connection initiation mode used by local endpoint toestablish ike connection with peer site.INITIATOR - In this mode local endpoint initiatestunnel setup and will also respond to incoming tunnelsetup requests from peer gateway.RESPOND_ONLY - In this mode, local endpoint shall onlyrespond to incoming tunnel setup requests. It shall notinitiate the tunnel setup.ON_DEMAND - In this mode local endpoint will initiatetunnel creation once first packet matching the policyrule is received and will also respond to incominginitiation request.
    /// </summary>
    [NSXTProperty(Description: @"Connection initiation mode used by local endpoint toestablish ike connection with peer site.INITIATOR - In this mode local endpoint initiatestunnel setup and will also respond to incoming tunnelsetup requests from peer gateway.RESPOND_ONLY - In this mode, local endpoint shall onlyrespond to incoming tunnel setup requests. It shall notinitiate the tunnel setup.ON_DEMAND - In this mode local endpoint will initiatetunnel creation once first packet matching the policyrule is received and will also respond to incominginitiation request.")]
    public enum NSXTIpsecVpnSessionConnectionInitiationModeEnumType
    {
        [EnumMember(Value = "INITIATOR")]
        INITIATOR = 1,
        [EnumMember(Value = "RESPOND_ONLY")]
        RESPONDONLY = 2,
        [EnumMember(Value = "ON_DEMAND")]
        ONDEMAND = 3,
    }
}