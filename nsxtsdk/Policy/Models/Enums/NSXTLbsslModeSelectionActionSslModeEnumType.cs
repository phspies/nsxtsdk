// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// SSL Passthrough: LB establishes a TCP connection with client and anotherconnection with selected backend server. LB won&apos;t inspect the streamdata between client and backend server, but just pass it through.Backend server exchanges SSL connection with client.SSL Offloading: LB terminiates the connections from client, andestablishes SSL connection with it. After receiving the HTTP request,LB connects the selected backend server and talk with it via HTTPwithout SSL. LB estalishes new connection to selected backend serverfor each HTTP request, in case server_keep_alive or multiplexing areNOT configured.SSL End-to-End: LB terminiates the connections from client, andestablishes SSL connection with it. After receiving the HTTP request,LB connects the selected backend server and talk with it via HTTPS.LB estalishes new SSL connection to selected backend server for eachHTTP request, in case server_keep_alive or multiplexing are NOTconfigured.
    /// </summary>
    [NSXTProperty(Description: @"SSL Passthrough: LB establishes a TCP connection with client and anotherconnection with selected backend server. LB won&apos;t inspect the streamdata between client and backend server, but just pass it through.Backend server exchanges SSL connection with client.SSL Offloading: LB terminiates the connections from client, andestablishes SSL connection with it. After receiving the HTTP request,LB connects the selected backend server and talk with it via HTTPwithout SSL. LB estalishes new connection to selected backend serverfor each HTTP request, in case server_keep_alive or multiplexing areNOT configured.SSL End-to-End: LB terminiates the connections from client, andestablishes SSL connection with it. After receiving the HTTP request,LB connects the selected backend server and talk with it via HTTPS.LB estalishes new SSL connection to selected backend server for eachHTTP request, in case server_keep_alive or multiplexing are NOTconfigured.")]
    public enum NSXTLbsslModeSelectionActionSslModeEnumType
    {
        [EnumMember(Value = "SSL_PASSTHROUGH")]
        SSLPASSTHROUGH = 1,
        [EnumMember(Value = "SSL_END_TO_END")]
        SSLENDTOEND = 2,
        [EnumMember(Value = "SSL_OFFLOAD")]
        SSLOFFLOAD = 3,
    }
}
