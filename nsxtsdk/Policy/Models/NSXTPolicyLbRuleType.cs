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
    public class NSXTPolicyLbRuleType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// This condition is used to match URIs(Uniform Resource Identifier) of
        /// HTTP request messages. The URI field can be specified as a regluar
        /// expression. If an HTTP request message is requesting an URI which
        /// matches specified regular expression, it matches the condition. The
        /// syntax of whole URI looks like this:
        /// scheme:[//[user[:password]@]host[:port]][/path][?query][#fragment]
        /// This condition matches only the path part of entire URI. The path_match
        /// field is used as a regular expression to match URI path of HTTP
        /// requests. For example, to match any URI that has "/image/" or
        /// "/images/", uri field can be specified as: "/image[s]?/". The regular
        /// expressions in load balancer rules use the features common to both
        /// Java regular expressions and Perl Compatible Regular Expressions
        /// (PCREs) with some restrictions. Reference http://www.pcre .org for
        /// PCRE and the NSX-T Administrator's Guide for the restrictions.
        /// Please note, when regular expressions are used in JSON (JavaScript
        /// Object Notation) string, every backslash character (\) needs to be
        /// escaped by one additional backslash character.
        /// </summary>
        [JsonProperty(PropertyName = "path_match")]
        [NSXTProperty(IsRequired: false, Description: @"This condition is used to match URIs(Uniform Resource Identifier) ofHTTP request messages. The URI field can be specified as a regluarexpression. If an HTTP request message is requesting an URI whichmatches specified regular expression, it matches the condition. Thesyntax of whole URI looks like this:scheme:[//[user[:password]@]host[:port]][/path][?query][#fragment]This condition matches only the path part of entire URI. The path_matchfield is used as a regular expression to match URI path of HTTPrequests. For example, to match any URI that has &quot;/image/&quot; or&quot;/images/&quot;, uri field can be specified as: &quot;/image[s]?/&quot;. The regular expressions in load balancer rules use the features common to both Java regular expressions and Perl Compatible Regular Expressions (PCREs) with some restrictions. Reference http://www.pcre .org for PCRE and the NSX-T Administrator&apos;s Guide for the restrictions. Please note, when regular expressions are used in JSON (JavaScript Object Notation) string, every backslash character (\) needs to be escaped by one additional backslash character.")]
        public string? PathMatch { get; set; }
        /// <summary>
        /// This condition is used to match HTTP request messages by the
        /// specific HTTP header field, Host.  The Host request header specifies
        /// the domain name of the server. The supplied Host HTTP header match
        /// condition will be matched as a regular expression.
        /// The regular expressions in load balancer rules use the features
        /// common to both Java regular expressions and Perl Compatible Regular
        /// Expressions (PCREs) with some restrictions. Reference http://www.pcre
        /// .org for PCRE and the NSX-T Administrator's Guide for the
        /// restrictions. Please note, when regular expressions are used in JSON
        /// (JavaScript Object Notation) string, every backslash character (\)
        /// needs to be escaped by one additional backslash character.
        /// </summary>
        [JsonProperty(PropertyName = "host_match")]
        [NSXTProperty(IsRequired: false, Description: @"This condition is used to match HTTP request messages by thespecific HTTP header field, Host.  The Host request header specifiesthe domain name of the server. The supplied Host HTTP header matchcondition will be matched as a regular expression.The regular expressions in load balancer rules use the featurescommon to both Java regular expressions and Perl Compatible RegularExpressions (PCREs) with some restrictions. Reference http://www.pcre.org for PCRE and the NSX-T Administrator&apos;s Guide for therestrictions. Please note, when regular expressions are used in JSON(JavaScript Object Notation) string, every backslash character (\)needs to be escaped by one additional backslash character.")]
        public string? HostMatch { get; set; }
        /// <summary>
        /// The path of PolicyLbVirtualServer to bind to this PolicyLbRule and its
        /// Group
        /// </summary>
        [JsonProperty(PropertyName = "lb_virtual_server")]
        [NSXTProperty(IsRequired: false, Description: @"The path of PolicyLbVirtualServer to bind to this PolicyLbRule and itsGroup")]
        public string? LbVirtualServer { get; set; }
        /// <summary>
        /// This field is used to resolve conflicts between multiple
        /// PolicyLbRules associated with a single PolicyLbVirtualServer and will
        /// be applied numerically or low to high
        /// </summary>
        [JsonProperty(PropertyName = "sequence_number")]
        [NSXTProperty(IsRequired: false, Description: @"This field is used to resolve conflicts between multiplePolicyLbRules associated with a single PolicyLbVirtualServer and willbe applied numerically or low to high")]
        public long? SequenceNumber { get; set; }
        /// <summary>
        /// If more than one match condition is specified, then
        /// matching strategy determines if all conditions should match or any
        /// one condition should match for the LB Rule to be considered a match.
        /// - ALL indicates that both host_match and path_match must match for
        /// this PolicyLbRule to be considered a match
        /// - ANY indicates that either host_match or patch match may match for
        /// this PolicyLbRule to be considered a match
        /// </summary>
        [JsonProperty(PropertyName = "match_strategy")]
        [NSXTProperty(IsRequired: false, Description: @"If more than one match condition is specified, thenmatching strategy determines if all conditions should match or anyone condition should match for the LB Rule to be considered a match.- ALL indicates that both host_match and path_match must match forthis PolicyLbRule to be considered a match- ANY indicates that either host_match or patch match may match forthis PolicyLbRule to be considered a match")]
        [NSXTDefaultProperty(Default: "ANY")]
        public NSXTPolicyLbRuleMatchStrategyEnumType? MatchStrategy { get; set; }
    }
}
