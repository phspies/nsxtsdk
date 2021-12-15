// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Specifies the algorithm to pick the IP address(es) to bereturned, when multiple entries are configured.This does not apply if num_records_in_response is 0.Default is consistent hash.Enum options - DNS_RECORD_RESPONSE_ROUND_ROBIN,DNS_RECORD_RESPONSE_CONSISTENT_HASH.Default value when not specified in API or module isinterpreted by ALB Controller asDNS_RECORD_RESPONSE_CONSISTENT_HASH.
    /// </summary>
    [NSXTProperty(Description: @"Specifies the algorithm to pick the IP address(es) to bereturned, when multiple entries are configured.This does not apply if num_records_in_response is 0.Default is consistent hash.Enum options - DNS_RECORD_RESPONSE_ROUND_ROBIN,DNS_RECORD_RESPONSE_CONSISTENT_HASH.Default value when not specified in API or module isinterpreted by ALB Controller asDNS_RECORD_RESPONSE_CONSISTENT_HASH.")]
    public enum NSXTAlbdnsInfoAlgorithmEnumType
    {
        [EnumMember(Value = "DNS_RECORD_RESPONSE_ROUND_ROBIN")]
        DNSRECORDRESPONSEROUNDROBIN = 1,
        [EnumMember(Value = "DNS_RECORD_RESPONSE_CONSISTENT_HASH")]
        DNSRECORDRESPONSECONSISTENTHASH = 0,
    }
}
