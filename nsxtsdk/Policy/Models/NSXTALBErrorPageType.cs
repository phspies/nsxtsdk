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
    /// Advanced load balancer ErrorPage object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer ErrorPage object")]
    public class NSXTALBErrorPageType 
    {
        /// <summary>
        /// Index of the error page.
        /// </summary>
        [JsonProperty(PropertyName = "index")]
        public long? Index { get; set; }
        /// <summary>
        /// Custom error page body used to sent to the client.
        /// It is a reference to an object of type ErrorPageBody.
        /// </summary>
        [JsonProperty(PropertyName = "error_page_body_path")]
        public string? ErrorPageBodyPath { get; set; }
        /// <summary>
        /// Enable or disable the error page.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "enable")]
        public bool? Enable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "match")]
        public NSXTALBHTTPStatusMatchType Match { get; set; }
        /// <summary>
        /// Redirect sent to client when match.
        /// </summary>
        [JsonProperty(PropertyName = "error_redirect")]
        public string? ErrorRedirect { get; set; }
    }
}
