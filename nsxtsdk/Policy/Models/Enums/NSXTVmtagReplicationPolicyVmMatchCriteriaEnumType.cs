// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Matching criteria used for associating VMs from protected site to VMson recovery sites.- MATCH_NSX_ATTACHMENT_ID : Associate VMs from the protected site and     recovery sites based on NSX attachment ID.- MATCH_BIOS_UUID_NAME : Associate VMs from the protected site and     recovery sites based on (VM BIOS UUID + VM Name).
    /// </summary>
    [NSXTProperty(Description: @"Matching criteria used for associating VMs from protected site to VMson recovery sites.- MATCH_NSX_ATTACHMENT_ID : Associate VMs from the protected site and     recovery sites based on NSX attachment ID.- MATCH_BIOS_UUID_NAME : Associate VMs from the protected site and     recovery sites based on (VM BIOS UUID + VM Name).")]
    public enum NSXTVmtagReplicationPolicyVmMatchCriteriaEnumType
    {
        [EnumMember(Value = "MATCH_NSX_ATTACHMENT_ID")]
        MATCHNSXATTACHMENTID = 1,
        [EnumMember(Value = "MATCH_BIOS_UUID_NAME")]
        MATCHBIOSUUIDNAME = 2,
    }
}
