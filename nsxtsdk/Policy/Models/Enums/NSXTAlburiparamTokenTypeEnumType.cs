// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Token type for constructing the URI.Enum options - URI_TOKEN_TYPE_HOST, URI_TOKEN_TYPE_PATH,URI_TOKEN_TYPE_STRING, URI_TOKEN_TYPE_STRING_GROUP,URI_TOKEN_TYPE_REGEX.
    /// </summary>
    [NSXTProperty(Description: @"Token type for constructing the URI.Enum options - URI_TOKEN_TYPE_HOST, URI_TOKEN_TYPE_PATH,URI_TOKEN_TYPE_STRING, URI_TOKEN_TYPE_STRING_GROUP,URI_TOKEN_TYPE_REGEX.")]
    public enum NSXTAlburiparamTokenTypeEnumType
    {
        [EnumMember(Value = "URI_TOKEN_TYPE_HOST")]
        URITOKENTYPEHOST = 1,
        [EnumMember(Value = "URI_TOKEN_TYPE_PATH")]
        URITOKENTYPEPATH = 2,
        [EnumMember(Value = "URI_TOKEN_TYPE_STRING")]
        URITOKENTYPESTRING = 3,
        [EnumMember(Value = "URI_TOKEN_TYPE_STRING_GROUP")]
        URITOKENTYPESTRINGGROUP = 4,
        [EnumMember(Value = "URI_TOKEN_TYPE_REGEX")]
        URITOKENTYPEREGEX = 5,
    }
}
