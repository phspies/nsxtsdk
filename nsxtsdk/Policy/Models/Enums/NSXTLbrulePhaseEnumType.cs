// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Each load balancer rule is used at a specific phase of load balancerprocessing. Currently five phases are supported, HTTP_REQUEST_REWRITE,HTTP_FORWARDING, HTTP_RESPONSE_REWRITE, HTTP_ACCESS and TRANSPORT.When an HTTP request message is received by load balancer, allHTTP_REQUEST_REWRITE rules, if present are executed in the order theyare applied to virtual server. And then if HTTP_FORWARDING rulespresent, only first matching rule&apos;s action is executed, remaining rulesare not checked. HTTP_FORWARDING rules can have only one action. If therequest is forwarded to a backend server and the response goes back toload balancer, all HTTP_RESPONSE_REWRITE rules, if present, are executedin the order they are applied to the virtual server.In HTTP_ACCESS phase, user can define action to control access usingJWT authentication.In TRANSPORT phase, user can define the condition to match SNI in TLSclient hello and define the action to do SSL end-to-end, SSL offloadingor SSL passthrough using a specific load balancer server pool.
    /// </summary>
    [NSXTProperty(Description: @"Each load balancer rule is used at a specific phase of load balancerprocessing. Currently five phases are supported, HTTP_REQUEST_REWRITE,HTTP_FORWARDING, HTTP_RESPONSE_REWRITE, HTTP_ACCESS and TRANSPORT.When an HTTP request message is received by load balancer, allHTTP_REQUEST_REWRITE rules, if present are executed in the order theyare applied to virtual server. And then if HTTP_FORWARDING rulespresent, only first matching rule&apos;s action is executed, remaining rulesare not checked. HTTP_FORWARDING rules can have only one action. If therequest is forwarded to a backend server and the response goes back toload balancer, all HTTP_RESPONSE_REWRITE rules, if present, are executedin the order they are applied to the virtual server.In HTTP_ACCESS phase, user can define action to control access usingJWT authentication.In TRANSPORT phase, user can define the condition to match SNI in TLSclient hello and define the action to do SSL end-to-end, SSL offloadingor SSL passthrough using a specific load balancer server pool.")]
    public enum NSXTLbrulePhaseEnumType
    {
        [EnumMember(Value = "HTTP_REQUEST_REWRITE")]
        HTTPREQUESTREWRITE = 1,
        [EnumMember(Value = "HTTP_FORWARDING")]
        HTTPFORWARDING = 0,
        [EnumMember(Value = "HTTP_RESPONSE_REWRITE")]
        HTTPRESPONSEREWRITE = 1,
        [EnumMember(Value = "HTTP_ACCESS")]
        HTTPACCESS = 2,
        [EnumMember(Value = "TRANSPORT")]
        TRANSPORT = 3,
    }
}
