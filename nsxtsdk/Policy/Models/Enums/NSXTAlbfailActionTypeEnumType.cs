// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Enables a response to client when pool experiences afailure.By default TCP connection is closed.Enum options - FAIL_ACTION_HTTP_REDIRECT,FAIL_ACTION_HTTP_LOCAL_RSP, FAIL_ACTION_CLOSE_CONN.Allowed in Basic(Allowed values-FAIL_ACTION_CLOSE_CONN,FAIL_ACTION_HTTP_REDIRECT) edition,Essentials(Allowed values- FAIL_ACTION_CLOSE_CONN) edition,Enterprise edition.Default value when not specified in API or module isinterpreted by ALB Controller as FAIL_ACTION_CLOSE_CONN.
    /// </summary>
    [NSXTProperty(Description: @"Enables a response to client when pool experiences afailure.By default TCP connection is closed.Enum options - FAIL_ACTION_HTTP_REDIRECT,FAIL_ACTION_HTTP_LOCAL_RSP, FAIL_ACTION_CLOSE_CONN.Allowed in Basic(Allowed values-FAIL_ACTION_CLOSE_CONN,FAIL_ACTION_HTTP_REDIRECT) edition,Essentials(Allowed values- FAIL_ACTION_CLOSE_CONN) edition,Enterprise edition.Default value when not specified in API or module isinterpreted by ALB Controller as FAIL_ACTION_CLOSE_CONN.")]
    public enum NSXTAlbfailActionTypeEnumType
    {
        [EnumMember(Value = "FAIL_ACTION_HTTP_REDIRECT")]
        FAILACTIONHTTPREDIRECT = 1,
        [EnumMember(Value = "FAIL_ACTION_HTTP_LOCAL_RSP")]
        FAILACTIONHTTPLOCALRSP = 2,
        [EnumMember(Value = "FAIL_ACTION_CLOSE_CONN")]
        FAILACTIONCLOSECONN = 0,
    }
}
