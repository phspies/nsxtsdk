using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Advanced load balancer FailAction object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer FailAction object")]
    public class NSXTALBFailActionType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "redirect")]
        public NSXTALBFailActionHTTPRedirectType Redirect { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "local_rsp")]
        public NSXTALBFailActionHTTPLocalResponseType LocalRsp { get; set; }
        /// <summary>
        /// Enables a response to client when pool experiences a
        /// failure.
        /// By default TCP connection is closed.
        /// Enum options - FAIL_ACTION_HTTP_REDIRECT,
        /// FAIL_ACTION_HTTP_LOCAL_RSP, FAIL_ACTION_CLOSE_CONN.
        /// Allowed in Basic(Allowed values-
        /// FAIL_ACTION_CLOSE_CONN,FAIL_ACTION_HTTP_REDIRECT) edition,
        /// Essentials(Allowed values- FAIL_ACTION_CLOSE_CONN) edition,
        /// Enterprise edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as FAIL_ACTION_CLOSE_CONN.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbfailActionTypeEnumType Type { get; set; }
    }
}
