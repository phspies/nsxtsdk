// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Current status of bundle upload.
    /// </summary>
    [NSXTProperty(Description: @"Current status of bundle upload.")]
    public enum NSXTBundleUploadStatusStatusEnumType
    {
        [EnumMember(Value = "UPLOADING")]
        UPLOADING = 1,
        [EnumMember(Value = "VERIFYING")]
        VERIFYING = 2,
        [EnumMember(Value = "SUCCESS")]
        SUCCESS = 3,
        [EnumMember(Value = "FAILED")]
        FAILED = 4,
    }
}
