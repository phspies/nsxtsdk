using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Match conditions are used to match application traffic passing through
        /// load balancers. Multiple match conditions can be specified in one load
        /// balancer rule, each match condition defines a criterion for application
        /// traffic.
        /// If inverse field is set to true, the match result of the condition is
        /// inverted.
        /// If more than one match condition is specified, match strategy determines
        /// if all conditions should match or any one condition should match for the
        /// load balancer rule to be considered a match.
        /// Currently only HTTP messages are supported by load balancer rules.
        /// Each load balancer rule is used at a specific phase of load balancer
        /// processing. Currently three phases are supported, HTTP_REQUEST_REWRITE,
        /// HTTP_FORWARDING and HTTP_RESPONSE_REWRITE.
        /// Each phase supports certain types of match conditions, supported match
        /// conditions in HTTP_REQUEST_REWRITE phase are:
        /// LbHttpRequestMethodCondition
        /// LbHttpRequestUriCondition
        /// LbHttpRequestUriArgumentsCondition
        /// LbHttpRequestVersionCondition
        /// LbHttpRequestHeaderCondition
        /// LbHttpRequestCookieCondition
        /// LbHttpRequestBodyCondition
        /// LbTcpHeaderCondition
        /// LbIpHeaderCondition
        /// LbVariableCondition
        /// LbHttpSslCondition
        /// Supported match conditions in HTTP_FORWARDING phase are:
        /// LbHttpRequestMethodCondition
        /// LbHttpRequestUriCondition
        /// LbHttpRequestUriArgumentsCondition
        /// LbHttpRequestVersionCondition
        /// LbHttpRequestHeaderCondition
        /// LbHttpRequestCookieCondition
        /// LbHttpRequestBodyCondition
        /// LbTcpHeaderCondition
        /// LbIpHeaderCondition
        /// LbVariableCondition
        /// LbHttpSslCondition
        /// LbSslSniCondition
        /// Supported match condition in HTTP_RESPONSE_REWRITE phase is:
        /// LbHttpResponseHeaderCondition
        /// LbHttpRequestMethodCondition
        /// LbHttpRequestUriCondition
        /// LbHttpRequestUriArgumentsCondition
        /// LbHttpRequestVersionCondition
        /// LbHttpRequestHeaderCondition
        /// LbHttpRequestCookieCondition
        /// LbTcpHeaderCondition
        /// LbIpHeaderCondition
        /// LbVariableCondition
        /// LbHttpSslCondition
        /// Supported match condition in HTTP_ACCESS phase is:
        /// LbHttpRequestMethodCondition
        /// LbHttpRequestUriCondition
        /// LbHttpRequestUriArgumentsCondition
        /// LbHttpRequestVersionCondition
        /// LbHttpRequestHeaderCondition
        /// LbHttpRequestCookieCondition
        /// LbHttpRequestBodyCondition
        /// LbTcpHeaderCondition
        /// LbIpHeaderCondition
        /// LbVariableCondition
        /// LbHttpSslCondition
        /// Supported match condition in TRANSPORT phase is:
        /// LbSslSniCondition
    /// </summary>
    [NSXTProperty(Description: @"Match conditions are used to match application traffic passing throughload balancers. Multiple match conditions can be specified in one loadbalancer rule, each match condition defines a criterion for applicationtraffic.If inverse field is set to true, the match result of the condition isinverted.If more than one match condition is specified, match strategy determinesif all conditions should match or any one condition should match for theload balancer rule to be considered a match.Currently only HTTP messages are supported by load balancer rules.Each load balancer rule is used at a specific phase of load balancerprocessing. Currently three phases are supported, HTTP_REQUEST_REWRITE,HTTP_FORWARDING and HTTP_RESPONSE_REWRITE.Each phase supports certain types of match conditions, supported matchconditions in HTTP_REQUEST_REWRITE phase are:LbHttpRequestMethodConditionLbHttpRequestUriConditionLbHttpRequestUriArgumentsConditionLbHttpRequestVersionConditionLbHttpRequestHeaderConditionLbHttpRequestCookieConditionLbHttpRequestBodyConditionLbTcpHeaderConditionLbIpHeaderConditionLbVariableConditionLbHttpSslConditionSupported match conditions in HTTP_FORWARDING phase are:LbHttpRequestMethodConditionLbHttpRequestUriConditionLbHttpRequestUriArgumentsConditionLbHttpRequestVersionConditionLbHttpRequestHeaderConditionLbHttpRequestCookieConditionLbHttpRequestBodyConditionLbTcpHeaderConditionLbIpHeaderConditionLbVariableConditionLbHttpSslConditionLbSslSniConditionSupported match condition in HTTP_RESPONSE_REWRITE phase is:LbHttpResponseHeaderConditionLbHttpRequestMethodConditionLbHttpRequestUriConditionLbHttpRequestUriArgumentsConditionLbHttpRequestVersionConditionLbHttpRequestHeaderConditionLbHttpRequestCookieConditionLbTcpHeaderConditionLbIpHeaderConditionLbVariableConditionLbHttpSslConditionSupported match condition in HTTP_ACCESS phase is:LbHttpRequestMethodConditionLbHttpRequestUriConditionLbHttpRequestUriArgumentsConditionLbHttpRequestVersionConditionLbHttpRequestHeaderConditionLbHttpRequestCookieConditionLbHttpRequestBodyConditionLbTcpHeaderConditionLbIpHeaderConditionLbVariableConditionLbHttpSslConditionSupported match condition in TRANSPORT phase is:LbSslSniCondition")]
    public class NSXTLbRuleConditionType 
    {
        /// <summary>
        /// A flag to indicate whether reverse the match result of this condition
        /// </summary>
        [JsonProperty(PropertyName = "inverse")]
        public bool? Inverse { get; set; }
        /// <summary>
        /// Type of load balancer rule condition
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbRuleConditionTypeEnumType Type { get; set; }
    }
}
