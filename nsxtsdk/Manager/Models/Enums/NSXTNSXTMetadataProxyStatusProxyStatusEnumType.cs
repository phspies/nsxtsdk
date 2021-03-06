// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// UP means the metadata proxy is working fine on both transport-nodes(if have);DOWN means the metadata proxy is is down on both transport-nodes(if have),hence the metadata proxy will not repsonse any metadata request;Error means error happens on transport-node(s) or no status is reported fromtransport-node(s). The metadata proxy may be working (or not working);NO_BACK means metadata proxy is working in one of the transport node whilenot in the other transport-node (if have). Hence if the metadata proxy inthe working transport-node goes down, the metadata proxy will go down.
    /// </summary>
    [NSXTProperty(Description: @"UP means the metadata proxy is working fine on both transport-nodes(if have);DOWN means the metadata proxy is is down on both transport-nodes(if have),hence the metadata proxy will not repsonse any metadata request;Error means error happens on transport-node(s) or no status is reported fromtransport-node(s). The metadata proxy may be working (or not working);NO_BACK means metadata proxy is working in one of the transport node whilenot in the other transport-node (if have). Hence if the metadata proxy inthe working transport-node goes down, the metadata proxy will go down.")]
    public enum NSXTMetadataProxyStatusProxyStatusEnumType
    {
        [EnumMember(Value = "UP")]
        UP = 1,
        [EnumMember(Value = "DOWN")]
        DOWN = 2,
        [EnumMember(Value = "ERROR")]
        ERROR = 3,
        [EnumMember(Value = "NO_BACKUP")]
        NOBACKUP = 4,
    }
}
