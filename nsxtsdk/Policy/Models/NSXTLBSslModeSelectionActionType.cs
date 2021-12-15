// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLBSslModeSelectionActionType : NSXTLBRuleActionType
    {
        /// <summary>
        /// SSL Passthrough: LB establishes a TCP connection with client and another
        /// connection with selected backend server. LB won't inspect the stream
        /// data between client and backend server, but just pass it through.
        /// Backend server exchanges SSL connection with client.
        /// SSL Offloading: LB terminiates the connections from client, and
        /// establishes SSL connection with it. After receiving the HTTP request,
        /// LB connects the selected backend server and talk with it via HTTP
        /// without SSL. LB estalishes new connection to selected backend server
        /// for each HTTP request, in case server_keep_alive or multiplexing are
        /// NOT configured.
        /// SSL End-to-End: LB terminiates the connections from client, and
        /// establishes SSL connection with it. After receiving the HTTP request,
        /// LB connects the selected backend server and talk with it via HTTPS.
        /// LB estalishes new SSL connection to selected backend server for each
        /// HTTP request, in case server_keep_alive or multiplexing are NOT
        /// configured.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_mode", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"SSL Passthrough: LB establishes a TCP connection with client and anotherconnection with selected backend server. LB won&apos;t inspect the streamdata between client and backend server, but just pass it through.Backend server exchanges SSL connection with client.SSL Offloading: LB terminiates the connections from client, andestablishes SSL connection with it. After receiving the HTTP request,LB connects the selected backend server and talk with it via HTTPwithout SSL. LB estalishes new connection to selected backend serverfor each HTTP request, in case server_keep_alive or multiplexing areNOT configured.SSL End-to-End: LB terminiates the connections from client, andestablishes SSL connection with it. After receiving the HTTP request,LB connects the selected backend server and talk with it via HTTPS.LB estalishes new SSL connection to selected backend server for eachHTTP request, in case server_keep_alive or multiplexing are NOTconfigured.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTLbsslModeSelectionActionSslModeEnumType SslMode { get; set; }
    }
}