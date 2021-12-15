// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// DNS message section for the resource record set.Enum options - DNS_MESSAGE_SECTION_QUESTION,DNS_MESSAGE_SECTION_ANSWER, DNS_MESSAGE_SECTION_AUTHORITY,DNS_MESSAGE_SECTION_ADDITIONAL.Default value when not specified in API or module isinterpreted by ALB Controller as DNS_MESSAGE_SECTION_ANSWER.
    /// </summary>
    [NSXTProperty(Description: @"DNS message section for the resource record set.Enum options - DNS_MESSAGE_SECTION_QUESTION,DNS_MESSAGE_SECTION_ANSWER, DNS_MESSAGE_SECTION_AUTHORITY,DNS_MESSAGE_SECTION_ADDITIONAL.Default value when not specified in API or module isinterpreted by ALB Controller as DNS_MESSAGE_SECTION_ANSWER.")]
    public enum NSXTAlbdnsRuleDnsRrSetSectionEnumType
    {
        [EnumMember(Value = "DNS_MESSAGE_SECTION_QUESTION")]
        DNSMESSAGESECTIONQUESTION = 1,
        [EnumMember(Value = "DNS_MESSAGE_SECTION_ANSWER")]
        DNSMESSAGESECTIONANSWER = 0,
        [EnumMember(Value = "DNS_MESSAGE_SECTION_AUTHORITY")]
        DNSMESSAGESECTIONAUTHORITY = 1,
        [EnumMember(Value = "DNS_MESSAGE_SECTION_ADDITIONAL")]
        DNSMESSAGESECTIONADDITIONAL = 2,
    }
}
