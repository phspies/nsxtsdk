// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// prefix to be used for api call
    /// </summary>
    [NSXTProperty(Description: @"prefix to be used for api call")]
    public enum NSXTBackupUiFramesInfoApiEndpointEnumType
    {
        [EnumMember(Value = "GLOBAL-MANAGER")]
        GlobalManager = 1,
        [EnumMember(Value = "NSXAPI")]
        Nsxapi = 2,
        [EnumMember(Value = "ICA")]
        Ica = 3,
    }
}
