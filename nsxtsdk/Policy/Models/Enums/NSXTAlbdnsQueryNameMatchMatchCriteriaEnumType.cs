// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Criterion to use for string matching the DNS query domainname in the question section.Enum options - BEGINS_WITH, DOES_NOT_BEGIN_WITH, CONTAINS,DOES_NOT_CONTAIN, ENDS_WITH, DOES_NOT_END_WITH, EQUALS,DOES_NOT_EQUAL, REGEX_MATCH, REGEX_DOES_NOT_MATCH.Allowed in Basic(Allowed values-BEGINS_WITH,DOES_NOT_BEGIN_WITH,CONTAINS,DOES_NOT_CONTAIN,ENDS_WITH,DOES_NOT_END_WITH,EQUALS,DOES_NOT_EQUAL)edition, Essentials(Allowed values-BEGINS_WITH,DOES_NOT_BEGIN_WITH,CONTAINS,DOES_NOT_CONTAIN,ENDS_WITH,DOES_NOT_END_WITH,EQUALS,DOES_NOT_EQUAL)edition, Enterprise edition.
    /// </summary>
    [NSXTProperty(Description: @"Criterion to use for string matching the DNS query domainname in the question section.Enum options - BEGINS_WITH, DOES_NOT_BEGIN_WITH, CONTAINS,DOES_NOT_CONTAIN, ENDS_WITH, DOES_NOT_END_WITH, EQUALS,DOES_NOT_EQUAL, REGEX_MATCH, REGEX_DOES_NOT_MATCH.Allowed in Basic(Allowed values-BEGINS_WITH,DOES_NOT_BEGIN_WITH,CONTAINS,DOES_NOT_CONTAIN,ENDS_WITH,DOES_NOT_END_WITH,EQUALS,DOES_NOT_EQUAL)edition, Essentials(Allowed values-BEGINS_WITH,DOES_NOT_BEGIN_WITH,CONTAINS,DOES_NOT_CONTAIN,ENDS_WITH,DOES_NOT_END_WITH,EQUALS,DOES_NOT_EQUAL)edition, Enterprise edition.")]
    public enum NSXTAlbdnsQueryNameMatchMatchCriteriaEnumType
    {
        [EnumMember(Value = "BEGINS_WITH")]
        BEGINSWITH = 1,
        [EnumMember(Value = "DOES_NOT_BEGIN_WITH")]
        DOESNOTBEGINWITH = 2,
        [EnumMember(Value = "CONTAINS")]
        CONTAINS = 3,
        [EnumMember(Value = "DOES_NOT_CONTAIN")]
        DOESNOTCONTAIN = 4,
        [EnumMember(Value = "ENDS_WITH")]
        ENDSWITH = 5,
        [EnumMember(Value = "DOES_NOT_END_WITH")]
        DOESNOTENDWITH = 6,
        [EnumMember(Value = "EQUALS")]
        EQUALS = 7,
        [EnumMember(Value = "DOES_NOT_EQUAL")]
        DOESNOTEQUAL = 8,
        [EnumMember(Value = "REGEX_MATCH")]
        REGEXMATCH = 9,
        [EnumMember(Value = "REGEX_DOES_NOT_MATCH")]
        REGEXDOESNOTMATCH = 10,
    }
}
