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
    /// Advanced load balancer WafConfig object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer WafConfig object")]
    public class NSXTALBWafConfigType 
    {
        /// <summary>
        /// Ignore request body parsing errors due to partial scanning.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "ignore_incomplete_request_body_error")]
        public bool? IgnoreIncompleteRequestBodyError { get; set; }
        /// <summary>
        /// Limit CPU utilization for each regular expression match
        /// when processing rules.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 30000.
        /// </summary>
        [JsonProperty(PropertyName = "regex_match_limit")]
        public long? RegexMatchLimit { get; set; }
        /// <summary>
        /// WAF allowed Content Types.
        /// Maximum of 64 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "allowed_request_content_types")]
        public IList<string> AllowedRequestContentTypes { get; set; }
        /// <summary>
        /// WAF allowed HTTP methods.
        /// Enum options - HTTP_METHOD_GET, HTTP_METHOD_HEAD,
        /// HTTP_METHOD_PUT, HTTP_METHOD_DELETE, HTTP_METHOD_POST,
        /// HTTP_METHOD_OPTIONS, HTTP_METHOD_TRACE, HTTP_METHOD_CONNECT,
        /// HTTP_METHOD_PATCH, HTTP_METHOD_PROPFIND,
        /// HTTP_METHOD_PROPPATCH, HTTP_METHOD_MKCOL, HTTP_METHOD_COPY,
        /// HTTP_METHOD_MOVE, HTTP_METHOD_LOCK, HTTP_METHOD_UNLOCK.
        /// </summary>
        [JsonProperty(PropertyName = "allowed_methods")]
        public IList<string> AllowedMethods { get; set; }
        /// <summary>
        /// The maximum period of time WAF processing is allowed to
        /// take for a single request.
        /// A value of 0 (zero) means no limit and should not be chosen
        /// in production deployments.
        /// It is only used for exceptional situations where crashes of
        /// se_dp processes are acceptable.
        /// The behavior of the system if this time is exceeded depends
        /// on two other configuration settings, the WAF policy mode and
        /// the WAF failure mode.
        /// In WAF policy mode 'Detection', the request is allowed and
        /// flagged for both failure mode 'Closed' and 'Open'.
        /// In enforcement node, 'Closed' means the request is
        /// rejected, 'Open' means the request is allowed and flagged.
        /// Irrespective of these settings, no subsequent WAF rules of
        /// this or other phases will be executed once the maximum
        /// execution time has been exceeded.
        /// Allowed values are 0-5000.
        /// Unit is MILLISECONDS.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 50.
        /// </summary>
        [JsonProperty(PropertyName = "max_execution_time")]
        public long? MaxExecutionTime { get; set; }
        /// <summary>
        /// WAF default action for Response Header Phase.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as
        /// phase:3,deny,status:403,log,auditlog.
        /// </summary>
        [JsonProperty(PropertyName = "response_hdr_default_action")]
        public string? ResponseHdrDefaultAction { get; set; }
        /// <summary>
        /// WAF allowed HTTP Versions.
        /// Enum options - ZERO_NINE, ONE_ZERO, ONE_ONE, TWO_ZERO.
        /// Maximum of 8 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "allowed_http_versions")]
        public IList<string> AllowedHttpVersions { get; set; }
        /// <summary>
        /// WAF Restricted HTTP Headers.
        /// Maximum of 64 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "restricted_headers")]
        public IList<string> RestrictedHeaders { get; set; }
        /// <summary>
        /// WAF default action for Response Body Phase.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as
        /// phase:4,deny,status:403,log,auditlog.
        /// </summary>
        [JsonProperty(PropertyName = "response_body_default_action")]
        public string? ResponseBodyDefaultAction { get; set; }
        /// <summary>
        /// WAF default action for Request Header Phase.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as
        /// phase:1,deny,status:403,log,auditlog.
        /// </summary>
        [JsonProperty(PropertyName = "request_hdr_default_action")]
        public string? RequestHdrDefaultAction { get; set; }
        /// <summary>
        /// WAF Static File Extensions.
        /// GET and HEAD requests with no query args and one of these
        /// extensions are allowed and not checked by the ruleset.
        /// Maximum of 64 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "static_extensions")]
        public IList<string> StaticExtensions { get; set; }
        /// <summary>
        /// Block or flag XML requests referring to External Entities.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "xml_xxe_protection")]
        public bool? XmlXxeProtection { get; set; }
        /// <summary>
        /// Limit depth of recursion for each regular expression match
        /// when processing rules.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 10000.
        /// </summary>
        [JsonProperty(PropertyName = "regex_recursion_limit")]
        public long? RegexRecursionLimit { get; set; }
        /// <summary>
        /// WAF Restricted File Extensions.
        /// Maximum of 256 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "restricted_extensions")]
        public IList<string> RestrictedExtensions { get; set; }
        /// <summary>
        /// HTTP status code used by WAF Positive Security Model when
        /// rejecting a request.
        /// Enum options - HTTP_RESPONSE_CODE_0,
        /// HTTP_RESPONSE_CODE_100, HTTP_RESPONSE_CODE_101,
        /// HTTP_RESPONSE_CODE_200, HTTP_RESPONSE_CODE_201,
        /// HTTP_RESPONSE_CODE_202, HTTP_RESPONSE_CODE_203,
        /// HTTP_RESPONSE_CODE_204, HTTP_RESPONSE_CODE_205,
        /// HTTP_RESPONSE_CODE_206, HTTP_RESPONSE_CODE_300,
        /// HTTP_RESPONSE_CODE_301, HTTP_RESPONSE_CODE_302,
        /// HTTP_RESPONSE_CODE_303, HTTP_RESPONSE_CODE_304,
        /// HTTP_RESPONSE_CODE_305, HTTP_RESPONSE_CODE_307,
        /// HTTP_RESPONSE_CODE_400, HTTP_RESPONSE_CODE_401,
        /// HTTP_RESPONSE_CODE_402...
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as HTTP_RESPONSE_CODE_403.
        /// </summary>
        [JsonProperty(PropertyName = "status_code_for_rejected_requests")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbwafConfigStatusCodeForRejectedRequestsEnumType? StatusCodeForRejectedRequests { get; set; }
        /// <summary>
        /// Argument seperator.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as &.
        /// </summary>
        [JsonProperty(PropertyName = "argument_separator")]
        public string? ArgumentSeparator { get; set; }
        /// <summary>
        /// 0  For Netscape Cookies.
        /// 1  For version 1 cookies.
        /// Allowed values are 0-1.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_format_version")]
        public long? CookieFormatVersion { get; set; }
        /// <summary>
        /// WAF default action for Request Body Phase.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as
        /// phase:2,deny,status:403,log,auditlog.
        /// </summary>
        [JsonProperty(PropertyName = "request_body_default_action")]
        public string? RequestBodyDefaultAction { get; set; }
        /// <summary>
        /// Maximum size for response body scanned by WAF.
        /// Allowed values are 1-32768.
        /// Unit is KB.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 128.
        /// </summary>
        [JsonProperty(PropertyName = "server_response_max_body_size")]
        public long? ServerResponseMaxBodySize { get; set; }
        /// <summary>
        /// Maximum size for the client request body scanned by WAF.
        /// Allowed values are 1-32768.
        /// Unit is KB.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 32.
        /// </summary>
        [JsonProperty(PropertyName = "client_request_max_body_size")]
        public long? ClientRequestMaxBodySize { get; set; }
    }
}
