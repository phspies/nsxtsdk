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
    /// Load balancer rule actions are used to manipulate application traffic.
        /// Currently load balancer rules can be used at three load balancer processing
        /// phases. Each phase has its own supported type of actions.
        /// Supported actions in HTTP_REQUST_REWRITE phase are:
        /// LBHttpRequestUriRewriteAction
        /// LBHttpRequestHeaderRewriteAction
        /// LBHttpRequestHeaderDeleteAction
        /// LBVariableAssignmentAction
        /// Supported actions in HTTP_FORWARDING phase are:
        /// LBHttpRejectAction
        /// LBHttpRedirectAction
        /// LBSelectPoolAction
        /// LBVariablePersistenceOnAction
        /// LBConnectionDropAction
        /// Supported action in HTTP_RESPONSE_REWRITE phase is:
        /// LBHttpResponseHeaderRewriteAction
        /// LBHttpResponseHeaderDeleteAction
        /// LBVariablePersistenceLearnAction
        /// Supported action in HTTP_ACCESS phase is:
        /// LBJwtAuthAction
        /// LBConnectionDropAction
        /// LBVariableAssignmentAction
        /// Supported action in TRANSPORT phase is:
        /// LBSslModeSelectionAction
        /// LBSelectPoolAction
        /// 
        /// If the match type of an LBRuleCondition field is specified as REGEX and
        /// named capturing groups are used in the specified regular expression. The
        /// groups can be used as variables in LBRuleAction fields.
        /// For example, define a rule with LBHttpRequestUriCondition as match
        /// condition and LBHttpRequestUriRewriteAction as action. Set match_type field
        /// of LBHttpRequestUriCondition to REGEX, and set uri field to
        /// "/news/(?<year>\d+)/(?<month>\d+)/(?<article>.*)".
        /// Set uri field of LBHttpRequestUriRewriteAction to:
        /// "/news/$year-$month/$article"
        /// In uri field of LBHttpRequestUriCondition, the (?<year>\d+),
        /// (?<month>\d+) and (?<article>.*) are named capturing groups,
        /// they define variables named $year, $month and $article respectively. The
        /// defined variables are used in LBHttpRequestUriRewriteAction.
        /// For a matched HTTP request with URI "/news/2017/06/xyz.html", the substring
        /// "2017" is captured in variable $year, "06" is captured in variable $month,
        /// and "xyz.html" is captured in variable $article. The
        /// LBHttpRequestUriRewriteAction will rewrite the URI to:
        /// "/news/2017-06/xyz.html"
        /// A set of built-in variables can be used in LBRuleAction as well. The name
        /// of built-in variables start with underscore, the name of user defined
        /// variables is not allowed to start with underscore.
        /// Following are some of the built-in variables:
        /// $_scheme: Reference the scheme part of matched HTTP messages, could be
        /// "http" or "https".
        /// $_host: Host of matched HTTP messages, for example "www.example.com".
        /// $_server_port: Port part of URI, it is also the port of the server which
        /// accepted a request. Default port is 80 for http and 443 for https.
        /// $_uri: The URI path, for example "/products/sample.html".
        /// $_request_uri: Full original request URI with arguments, for example,
        /// "/products/sample.html?a=b&c=d".
        /// $_args: URI arguments, for instance "a=b&c=d"
        /// $_is_args: "?" if a request has URI arguments, or an empty string
        /// otherwise.
        /// For the full list of built-in variables, please reference the NSX-T
        /// Administrator's Guide.
    /// </summary>
    [NSXTProperty(Description: @"Load balancer rule actions are used to manipulate application traffic.Currently load balancer rules can be used at three load balancer processingphases. Each phase has its own supported type of actions.Supported actions in HTTP_REQUST_REWRITE phase are:  LBHttpRequestUriRewriteAction  LBHttpRequestHeaderRewriteAction  LBHttpRequestHeaderDeleteAction  LBVariableAssignmentActionSupported actions in HTTP_FORWARDING phase are:  LBHttpRejectAction  LBHttpRedirectAction  LBSelectPoolAction  LBVariablePersistenceOnAction  LBConnectionDropActionSupported action in HTTP_RESPONSE_REWRITE phase is:  LBHttpResponseHeaderRewriteAction  LBHttpResponseHeaderDeleteAction  LBVariablePersistenceLearnActionSupported action in HTTP_ACCESS phase is:  LBJwtAuthAction  LBConnectionDropAction  LBVariableAssignmentActionSupported action in TRANSPORT phase is:  LBSslModeSelectionAction  LBSelectPoolActionIf the match type of an LBRuleCondition field is specified as REGEX andnamed capturing groups are used in the specified regular expression. Thegroups can be used as variables in LBRuleAction fields.For example, define a rule with LBHttpRequestUriCondition as matchcondition and LBHttpRequestUriRewriteAction as action. Set match_type fieldof LBHttpRequestUriCondition to REGEX, and set uri field to  &quot;/news/(?&amp;lt;year&amp;gt;\d+)/(?&amp;lt;month&amp;gt;\d+)/(?&amp;lt;article&amp;gt;.*)&quot;.Set uri field of LBHttpRequestUriRewriteAction to:  &quot;/news/$year-$month/$article&quot;In uri field of LBHttpRequestUriCondition, the (?&amp;lt;year&amp;gt;\d+),(?&amp;lt;month&amp;gt;\d+) and (?&amp;lt;article&amp;gt;.*) are named capturing groups,they define variables named $year, $month and $article respectively. Thedefined variables are used in LBHttpRequestUriRewriteAction.For a matched HTTP request with URI &quot;/news/2017/06/xyz.html&quot;, the substring&quot;2017&quot; is captured in variable $year, &quot;06&quot; is captured in variable $month,and &quot;xyz.html&quot; is captured in variable $article. TheLBHttpRequestUriRewriteAction will rewrite the URI to:  &quot;/news/2017-06/xyz.html&quot;A set of built-in variables can be used in LBRuleAction as well. The nameof built-in variables start with underscore, the name of user definedvariables is not allowed to start with underscore.Following are some of the built-in variables:  $_scheme: Reference the scheme part of matched HTTP messages, could be&quot;http&quot; or &quot;https&quot;.  $_host: Host of matched HTTP messages, for example &quot;www.example.com&quot;.  $_server_port: Port part of URI, it is also the port of the server whichaccepted a request. Default port is 80 for http and 443 for https.  $_uri: The URI path, for example &quot;/products/sample.html&quot;.  $_request_uri: Full original request URI with arguments, for example,    &quot;/products/sample.html?a=b&amp;c=d&quot;.  $_args: URI arguments, for instance &quot;a=b&amp;c=d&quot;  $_is_args: &quot;?&quot; if a request has URI arguments, or an empty stringotherwise.For the full list of built-in variables, please reference the NSX-TAdministrator&apos;s Guide.")]
    public class NSXTLBRuleActionType 
    {
        /// <summary>
        /// The property identifies the load balancer rule action type.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbruleActionTypeEnumType Type { get; set; }
    }
}
