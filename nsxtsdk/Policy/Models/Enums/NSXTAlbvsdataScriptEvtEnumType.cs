// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Event triggering execution of datascript.Enum options - VS_DATASCRIPT_EVT_HTTP_REQ,VS_DATASCRIPT_EVT_HTTP_RESP,VS_DATASCRIPT_EVT_HTTP_RESP_DATA,VS_DATASCRIPT_EVT_HTTP_LB_FAILED,VS_DATASCRIPT_EVT_HTTP_REQ_DATA,VS_DATASCRIPT_EVT_HTTP_RESP_FAILED,VS_DATASCRIPT_EVT_HTTP_LB_DONE, VS_DATASCRIPT_EVT_HTTP_AUTH,VS_DATASCRIPT_EVT_HTTP_POST_AUTH,VS_DATASCRIPT_EVT_TCP_CLIENT_ACCEPT,VS_DATASCRIPT_EVT_SSL_HANDSHAKE_DONE,VS_DATASCRIPT_EVT_DNS_REQ, VS_DATASCRIPT_EVT_DNS_RESP,VS_DATASCRIPT_EVT_L4_REQUEST, VS_DATASCRIPT_EVT_L4_RESPONSE,VS_DATASCRIPT_EVT_MAX.Allowed in Basic(Allowed values-VS_DATASCRIPT_EVT_HTTP_REQ) edition, Enterprise edition.
    /// </summary>
    [NSXTProperty(Description: @"Event triggering execution of datascript.Enum options - VS_DATASCRIPT_EVT_HTTP_REQ,VS_DATASCRIPT_EVT_HTTP_RESP,VS_DATASCRIPT_EVT_HTTP_RESP_DATA,VS_DATASCRIPT_EVT_HTTP_LB_FAILED,VS_DATASCRIPT_EVT_HTTP_REQ_DATA,VS_DATASCRIPT_EVT_HTTP_RESP_FAILED,VS_DATASCRIPT_EVT_HTTP_LB_DONE, VS_DATASCRIPT_EVT_HTTP_AUTH,VS_DATASCRIPT_EVT_HTTP_POST_AUTH,VS_DATASCRIPT_EVT_TCP_CLIENT_ACCEPT,VS_DATASCRIPT_EVT_SSL_HANDSHAKE_DONE,VS_DATASCRIPT_EVT_DNS_REQ, VS_DATASCRIPT_EVT_DNS_RESP,VS_DATASCRIPT_EVT_L4_REQUEST, VS_DATASCRIPT_EVT_L4_RESPONSE,VS_DATASCRIPT_EVT_MAX.Allowed in Basic(Allowed values-VS_DATASCRIPT_EVT_HTTP_REQ) edition, Enterprise edition.")]
    public enum NSXTAlbvsdataScriptEvtEnumType
    {
        [EnumMember(Value = "VS_DATASCRIPT_EVT_HTTP_REQ")]
        VSDATASCRIPTEVTHTTPREQ = 1,
        [EnumMember(Value = "VS_DATASCRIPT_EVT_HTTP_RESP")]
        VSDATASCRIPTEVTHTTPRESP = 2,
        [EnumMember(Value = "VS_DATASCRIPT_EVT_HTTP_RESP_DATA")]
        VSDATASCRIPTEVTHTTPRESPDATA = 3,
        [EnumMember(Value = "VS_DATASCRIPT_EVT_HTTP_LB_FAILED")]
        VSDATASCRIPTEVTHTTPLBFAILED = 4,
        [EnumMember(Value = "VS_DATASCRIPT_EVT_HTTP_REQ_DATA")]
        VSDATASCRIPTEVTHTTPREQDATA = 5,
        [EnumMember(Value = "VS_DATASCRIPT_EVT_HTTP_RESP_FAILED")]
        VSDATASCRIPTEVTHTTPRESPFAILED = 6,
        [EnumMember(Value = "VS_DATASCRIPT_EVT_HTTP_LB_DONE")]
        VSDATASCRIPTEVTHTTPLBDONE = 7,
        [EnumMember(Value = "VS_DATASCRIPT_EVT_HTTP_AUTH")]
        VSDATASCRIPTEVTHTTPAUTH = 8,
        [EnumMember(Value = "VS_DATASCRIPT_EVT_HTTP_POST_AUTH")]
        VSDATASCRIPTEVTHTTPPOSTAUTH = 9,
        [EnumMember(Value = "VS_DATASCRIPT_EVT_TCP_CLIENT_ACCEPT")]
        VSDATASCRIPTEVTTCPCLIENTACCEPT = 10,
        [EnumMember(Value = "VS_DATASCRIPT_EVT_SSL_HANDSHAKE_DONE")]
        VSDATASCRIPTEVTSSLHANDSHAKEDONE = 11,
        [EnumMember(Value = "VS_DATASCRIPT_EVT_DNS_REQ")]
        VSDATASCRIPTEVTDNSREQ = 12,
        [EnumMember(Value = "VS_DATASCRIPT_EVT_DNS_RESP")]
        VSDATASCRIPTEVTDNSRESP = 13,
        [EnumMember(Value = "VS_DATASCRIPT_EVT_L4_REQUEST")]
        VSDATASCRIPTEVTL4REQUEST = 14,
        [EnumMember(Value = "VS_DATASCRIPT_EVT_L4_RESPONSE")]
        VSDATASCRIPTEVTL4RESPONSE = 15,
        [EnumMember(Value = "VS_DATASCRIPT_EVT_MAX")]
        VSDATASCRIPTEVTMAX = 16,
    }
}
