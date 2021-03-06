// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// The current stage of full sync completion for ongoing sync.When Local Manager (LM) receives full sync data from AR, LM startswith workflow to prserve the state and restore the full sync fromwhere it has left off in case of change of leadership of the serviceto different NSX node or LM is restarted.LM starts the full sync workflow with state INITIAL capturing theAR full sync id and data location details. The stage/state transitionfollows the order given belowINITIAL - Full sync startedPROCESSED_FULLSYNC_DATA - Compelted processing the full state data                          provided by ARPRCESSED_DELTAS - Completed processing pending delta changes provided                  by AR.DELETED_STALE_ENTITIES - Completed deletion of all global entities on                         LM that are not in GM anymoreCOMPLETED - Full sync handling is completed on LMERROR - Full sync failed with errors on LM, in which case AR will        re-attempt full sync later point in time for the LMABORTED - Indicates that the full sync cancelled as per user request
    /// </summary>
    [NSXTProperty(Description: @"The current stage of full sync completion for ongoing sync.When Local Manager (LM) receives full sync data from AR, LM startswith workflow to prserve the state and restore the full sync fromwhere it has left off in case of change of leadership of the serviceto different NSX node or LM is restarted.LM starts the full sync workflow with state INITIAL capturing theAR full sync id and data location details. The stage/state transitionfollows the order given belowINITIAL - Full sync startedPROCESSED_FULLSYNC_DATA - Compelted processing the full state data                          provided by ARPRCESSED_DELTAS - Completed processing pending delta changes provided                  by AR.DELETED_STALE_ENTITIES - Completed deletion of all global entities on                         LM that are not in GM anymoreCOMPLETED - Full sync handling is completed on LMERROR - Full sync failed with errors on LM, in which case AR will        re-attempt full sync later point in time for the LMABORTED - Indicates that the full sync cancelled as per user request")]
    public enum NSXTFullSyncStateLastCompletedStageEnumType
    {
        [EnumMember(Value = "INITIAL")]
        INITIAL = 1,
        [EnumMember(Value = "PAUSE_DCNS")]
        PAUSEDCNS = 2,
        [EnumMember(Value = "DELETED_STALE_ENTITIES")]
        DELETEDSTALEENTITIES = 3,
        [EnumMember(Value = "PROCESSED_FULLSYNC_DATA")]
        PROCESSEDFULLSYNCDATA = 4,
        [EnumMember(Value = "PROCESSED_DELTAS")]
        PROCESSEDDELTAS = 5,
        [EnumMember(Value = "UNPAUSE_DCNS")]
        UNPAUSEDCNS = 6,
        [EnumMember(Value = "COMPLETED")]
        COMPLETED = 7,
        [EnumMember(Value = "ERROR")]
        ERROR = 8,
        [EnumMember(Value = "ABORTED")]
        ABORTED = 9,
    }
}
