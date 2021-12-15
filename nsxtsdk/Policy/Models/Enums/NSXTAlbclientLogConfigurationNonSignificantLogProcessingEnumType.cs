// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Logs that are neither significant nor filtered, areprocessed by the Logs Analytics system according to thissetting.Enum options - LOGS_PROCESSING_NONE,LOGS_PROCESSING_SYNC_AND_INDEX_ON_DEMAND,LOGS_PROCESSING_AUTO_SYNC_AND_INDEX,LOGS_PROCESSING_AUTO_SYNC_BUT_INDEX_ON_DEMAND.Default value when not specified in API or module isinterpreted by ALB Controller asLOGS_PROCESSING_SYNC_AND_INDEX_ON_DEMAND.
    /// </summary>
    [NSXTProperty(Description: @"Logs that are neither significant nor filtered, areprocessed by the Logs Analytics system according to thissetting.Enum options - LOGS_PROCESSING_NONE,LOGS_PROCESSING_SYNC_AND_INDEX_ON_DEMAND,LOGS_PROCESSING_AUTO_SYNC_AND_INDEX,LOGS_PROCESSING_AUTO_SYNC_BUT_INDEX_ON_DEMAND.Default value when not specified in API or module isinterpreted by ALB Controller asLOGS_PROCESSING_SYNC_AND_INDEX_ON_DEMAND.")]
    public enum NSXTAlbclientLogConfigurationNonSignificantLogProcessingEnumType
    {
        [EnumMember(Value = "LOGS_PROCESSING_NONE")]
        LOGSPROCESSINGNONE = 1,
        [EnumMember(Value = "LOGS_PROCESSING_SYNC_AND_INDEX_ON_DEMAND")]
        LOGSPROCESSINGSYNCANDINDEXONDEMAND = 0,
        [EnumMember(Value = "LOGS_PROCESSING_AUTO_SYNC_AND_INDEX")]
        LOGSPROCESSINGAUTOSYNCANDINDEX = 1,
        [EnumMember(Value = "LOGS_PROCESSING_AUTO_SYNC_BUT_INDEX_ON_DEMAND")]
        LOGSPROCESSINGAUTOSYNCBUTINDEXONDEMAND = 2,
    }
}