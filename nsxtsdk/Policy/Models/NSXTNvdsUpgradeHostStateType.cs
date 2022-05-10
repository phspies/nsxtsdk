using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTNvdsUpgradeHostStateType : NSXTManagedResourceType
    {
        /// <summary>
        /// Details of the N-VDS upgrade state on the host
        /// </summary>
        [JsonProperty(PropertyName = "state_details")]
        public IList<string> StateDetails { get; set; }
        /// <summary>
        /// TransportNode identifier
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string? Host { get; set; }
        /// <summary>
        /// This field returns current stage of Migration task. Here is a sequence
        /// of stages the task cycles through,
        /// TN_MIGRATION_TASK_IN_QUEUE
        /// RETRIEVE_SAVED_CONFIG,
        /// TN_VALIDATE,
        /// VMS_RETRIVAL,
        /// VMS_UNREGISTRATION,
        /// TN_STATELESS_WAIT_FOR_HP,
        /// DETACH_TNP,
        /// TNP_WAIT,
        /// TN_SEND_HS_MIGRATION_MSG,
        /// TN_ADD_HOST_TO_VDS,
        /// TN_UPDATE,
        /// TN_UPDATE_WAIT,
        /// TN_DELETE,
        /// TN_DELETE_WAIT,
        /// FN_DELETE_WAIT,
        /// TN_RECONFIG_HOST,
        /// TN_CREATE,
        /// TN_CREATE_WAIT,
        /// UPDATE_TNP_AND_APPLY,
        /// TN_EXIT_MM,
        /// VMS_REGISTRATION,
        /// VMS_REGISTRATION_WAIT,
        /// TN_MIGRATION_COMPLETED
        /// Depending on the type of host (stateful, stateless, Sddc, etc.) migration
        /// task may not cycle through all stages but in will follow above sequence.
        /// If stage is TN_MIGRATION_COMPLETED refer to field overall_state for SUCCESS
        /// or UPGRADE_FAILURE and state_details for details on same.
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_stage")]
        public string? UpgradeStage { get; set; }
        /// <summary>
        /// Overall state of N-VDSes on the TransportNodes
        /// </summary>
        [JsonProperty(PropertyName = "overall_state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNvdsUpgradeHostStateOverallStateEnumType? OverallState { get; set; }
        /// <summary>
        /// DiscoveredNode identifier
        /// </summary>
        [JsonProperty(PropertyName = "dn_ext_id")]
        public string? DnExtId { get; set; }
        /// <summary>
        /// TransportNode ip address
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        public string? IpAddress { get; set; }
    }
}
