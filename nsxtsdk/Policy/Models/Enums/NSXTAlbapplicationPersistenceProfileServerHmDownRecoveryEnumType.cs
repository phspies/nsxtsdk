// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Specifies behavior when a persistent server has been markeddown by a health monitor.Enum options - HM_DOWN_PICK_NEW_SERVER,HM_DOWN_ABORT_CONNECTION,HM_DOWN_CONTINUE_PERSISTENT_SERVER.Allowed in Basic(Allowed values- HM_DOWN_PICK_NEW_SERVER)edition, Essentials(Allowed values- HM_DOWN_PICK_NEW_SERVER)edition, Enterprise edition.Default value when not specified in API or module isinterpreted by ALB Controller as HM_DOWN_PICK_NEW_SERVER.
    /// </summary>
    [NSXTProperty(Description: @"Specifies behavior when a persistent server has been markeddown by a health monitor.Enum options - HM_DOWN_PICK_NEW_SERVER,HM_DOWN_ABORT_CONNECTION,HM_DOWN_CONTINUE_PERSISTENT_SERVER.Allowed in Basic(Allowed values- HM_DOWN_PICK_NEW_SERVER)edition, Essentials(Allowed values- HM_DOWN_PICK_NEW_SERVER)edition, Enterprise edition.Default value when not specified in API or module isinterpreted by ALB Controller as HM_DOWN_PICK_NEW_SERVER.")]
    public enum NSXTAlbapplicationPersistenceProfileServerHmDownRecoveryEnumType
    {
        [EnumMember(Value = "HM_DOWN_PICK_NEW_SERVER")]
        HMDOWNPICKNEWSERVER = 1,
        [EnumMember(Value = "HM_DOWN_ABORT_CONNECTION")]
        HMDOWNABORTCONNECTION = 2,
        [EnumMember(Value = "HM_DOWN_CONTINUE_PERSISTENT_SERVER")]
        HMDOWNCONTINUEPERSISTENTSERVER = 3,
    }
}
