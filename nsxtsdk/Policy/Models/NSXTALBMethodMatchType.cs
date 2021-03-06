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
    /// Advanced load balancer MethodMatch object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer MethodMatch object")]
    public class NSXTALBMethodMatchType 
    {
        /// <summary>
        /// Configure HTTP method(s).
        /// Enum options - HTTP_METHOD_GET, HTTP_METHOD_HEAD,
        /// HTTP_METHOD_PUT, HTTP_METHOD_DELETE, HTTP_METHOD_POST,
        /// HTTP_METHOD_OPTIONS, HTTP_METHOD_TRACE, HTTP_METHOD_CONNECT,
        /// HTTP_METHOD_PATCH, HTTP_METHOD_PROPFIND,
        /// HTTP_METHOD_PROPPATCH, HTTP_METHOD_MKCOL, HTTP_METHOD_COPY,
        /// HTTP_METHOD_MOVE, HTTP_METHOD_LOCK, HTTP_METHOD_UNLOCK.
        /// Minimum of 1 items required.
        /// Maximum of 16 items allowed.
        /// Allowed in Basic(Allowed values-
        /// HTTP_METHOD_GET,HTTP_METHOD_PUT,HTTP_METHOD_POST,HTTP_METHOD_HEAD,HTTP_METHOD_OPTIONS)
        /// edition, Essentials(Allowed values-
        /// HTTP_METHOD_GET,HTTP_METHOD_PUT,HTTP_METHOD_POST,HTTP_METHOD_HEAD,HTTP_METHOD_OPTIONS)
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "methods", Required = Required.AllowNull)]
        public IList<string> Methods { get; set; }
        /// <summary>
        /// Criterion to use for HTTP method matching the method in the
        /// HTTP request.
        /// Enum options - IS_IN, IS_NOT_IN.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbmethodMatchMatchCriteriaEnumType MatchCriteria { get; set; }
    }
}
