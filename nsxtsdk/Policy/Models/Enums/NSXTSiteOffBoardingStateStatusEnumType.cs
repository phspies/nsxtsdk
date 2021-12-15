// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Represents site offboarding status.
    /// </summary>
    [NSXTProperty(Description: @"Represents site offboarding status.")]
    public enum NSXTSiteOffBoardingStateStatusEnumType
    {
        [EnumMember(Value = "INITIALIZE_INPROGRESS")]
        INITIALIZEINPROGRESS = 1,
        [EnumMember(Value = "INITIALIZE_FAILED")]
        INITIALIZEFAILED = 2,
        [EnumMember(Value = "INITIALIZE_SUCCESSFUL")]
        INITIALIZESUCCESSFUL = 3,
        [EnumMember(Value = "CLEANUP_INPROGRESS")]
        CLEANUPINPROGRESS = 4,
        [EnumMember(Value = "CLEANUP_FAILED")]
        CLEANUPFAILED = 5,
        [EnumMember(Value = "CLEANUP_SUCCESSFUL")]
        CLEANUPSUCCESSFUL = 6,
        [EnumMember(Value = "REALIZATION_INPROGRESS")]
        REALIZATIONINPROGRESS = 7,
        [EnumMember(Value = "REALIZATION_FAILED")]
        REALIZATIONFAILED = 8,
        [EnumMember(Value = "REALIZATION_SUCCESSFUL")]
        REALIZATIONSUCCESSFUL = 9,
        [EnumMember(Value = "TERMINAL_INPROGRESS")]
        TERMINALINPROGRESS = 10,
        [EnumMember(Value = "TERMINAL_FAILED")]
        TERMINALFAILED = 11,
        [EnumMember(Value = "FAILED")]
        FAILED = 12,
        [EnumMember(Value = "SUCCESSFUL")]
        SUCCESSFUL = 13,
    }
}
