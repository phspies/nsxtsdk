// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// SUCCESS if all the TN&apos;s stack status are SUCCESS,FAILED if some of the TN&apos;s stack status are FAILED.
    /// </summary>
    [NSXTProperty(Description: @"SUCCESS if all the TN&apos;s stack status are SUCCESS,FAILED if some of the TN&apos;s stack status are FAILED.")]
    public enum NSXTMirrorStackStatusListResultOverallStatusEnumType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 1,
        [EnumMember(Value = "SUCCESS")]
        SUCCESS = 2,
        [EnumMember(Value = "FAILED")]
        FAILED = 3,
    }
}
