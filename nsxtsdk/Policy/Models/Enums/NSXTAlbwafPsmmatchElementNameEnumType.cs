// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// The variable specification.For example ARGS or REQUEST_COOKIES.This can be a scalar like PATH_INFO.Enum options - WAF_VARIABLE_ARGS, WAF_VARIABLE_ARGS_GET,WAF_VARIABLE_ARGS_POST, WAF_VARIABLE_ARGS_NAMES,WAF_VARIABLE_REQUEST_COOKIES, WAF_VARIABLE_QUERY_STRING,WAF_VARIABLE_REQUEST_BASENAME, WAF_VARIABLE_REQUEST_URI,WAF_VARIABLE_PATH_INFO.
    /// </summary>
    [NSXTProperty(Description: @"The variable specification.For example ARGS or REQUEST_COOKIES.This can be a scalar like PATH_INFO.Enum options - WAF_VARIABLE_ARGS, WAF_VARIABLE_ARGS_GET,WAF_VARIABLE_ARGS_POST, WAF_VARIABLE_ARGS_NAMES,WAF_VARIABLE_REQUEST_COOKIES, WAF_VARIABLE_QUERY_STRING,WAF_VARIABLE_REQUEST_BASENAME, WAF_VARIABLE_REQUEST_URI,WAF_VARIABLE_PATH_INFO.")]
    public enum NSXTAlbwafPsmmatchElementNameEnumType
    {
        [EnumMember(Value = "WAF_VARIABLE_ARGS")]
        WAFVARIABLEARGS = 1,
        [EnumMember(Value = "WAF_VARIABLE_ARGS_GET")]
        WAFVARIABLEARGSGET = 2,
        [EnumMember(Value = "WAF_VARIABLE_ARGS_POST")]
        WAFVARIABLEARGSPOST = 3,
        [EnumMember(Value = "WAF_VARIABLE_ARGS_NAMES")]
        WAFVARIABLEARGSNAMES = 4,
        [EnumMember(Value = "WAF_VARIABLE_REQUEST_COOKIES")]
        WAFVARIABLEREQUESTCOOKIES = 5,
        [EnumMember(Value = "WAF_VARIABLE_QUERY_STRING")]
        WAFVARIABLEQUERYSTRING = 6,
        [EnumMember(Value = "WAF_VARIABLE_REQUEST_BASENAME")]
        WAFVARIABLEREQUESTBASENAME = 7,
        [EnumMember(Value = "WAF_VARIABLE_REQUEST_URI")]
        WAFVARIABLEREQUESTURI = 8,
        [EnumMember(Value = "WAF_VARIABLE_PATH_INFO")]
        WAFVARIABLEPATHINFO = 9,
    }
}
