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
    /// Advanced load balancer FailAction object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer FailAction object")]
    public class NSXTALBFailActionType 
    {
        /// <summary>
        /// URL to redirect HTTP requests to when pool experiences a
        /// failure.
        /// </summary>
        [JsonProperty(PropertyName = "redirect")]
        [NSXTProperty(IsRequired: false, Description: @"URL to redirect HTTP requests to when pool experiences afailure.")]
        public NSXTALBFailActionHTTPRedirectType Redirect { get; set; }
        /// <summary>
        /// Local response to HTTP requests when pool experiences a
        /// failure.
        /// </summary>
        [JsonProperty(PropertyName = "local_rsp")]
        [NSXTProperty(IsRequired: false, Description: @"Local response to HTTP requests when pool experiences afailure.")]
        public NSXTALBFailActionHTTPLocalResponseType LocalRsp { get; set; }
        /// <summary>
        /// Enables a response to client when pool experiences a
        /// failure.
        /// By default TCP connection is closed.
        /// Enum options - FAIL_ACTION_HTTP_REDIRECT,
        /// FAIL_ACTION_HTTP_LOCAL_RSP, FAIL_ACTION_CLOSE_CONN,
        /// FAIL_ACTION_BACKUP_POOL.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as FAIL_ACTION_CLOSE_CONN.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Enables a response to client when pool experiences afailure.By default TCP connection is closed.Enum options - FAIL_ACTION_HTTP_REDIRECT,FAIL_ACTION_HTTP_LOCAL_RSP, FAIL_ACTION_CLOSE_CONN,FAIL_ACTION_BACKUP_POOL.Default value when not specified in API or module isinterpreted by ALB Controller as FAIL_ACTION_CLOSE_CONN.")]
        [System.ComponentModel.DataAnnotations.Required]
        [NSXTDefaultProperty(Default: "FAIL_ACTION_CLOSE_CONN")]
        public NSXTAlbfailActionTypeEnumType Type { get; set; }
    }
}