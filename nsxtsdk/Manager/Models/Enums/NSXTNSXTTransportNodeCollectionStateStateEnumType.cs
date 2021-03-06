// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// If the host preparation or transport node creation is going on forany host then state will be &quot;IN_PROGRESS&quot;.If setting desired state of the transport node failed for any ofthe host then state will be &quot;FAILED_TO_CREATE&quot;If realization of transport node failed for any ofthe host then state will be &quot;FAILED_TO_REALIZE&quot;If Transport node is successfully created for all of the hosts incompute collection then state will be &quot;SUCCESS&quot;You can override the configuration for one or more hosts in thecompute collection by update TN(transport node) request on individualTN. If TN is successfully created for all hosts in compute collectionand one or more hosts have overridden configuration then transport nodecollection state will be &quot;PROFILE_MISMATCH&quot;.
    /// </summary>
    [NSXTProperty(Description: @"If the host preparation or transport node creation is going on forany host then state will be &quot;IN_PROGRESS&quot;.If setting desired state of the transport node failed for any ofthe host then state will be &quot;FAILED_TO_CREATE&quot;If realization of transport node failed for any ofthe host then state will be &quot;FAILED_TO_REALIZE&quot;If Transport node is successfully created for all of the hosts incompute collection then state will be &quot;SUCCESS&quot;You can override the configuration for one or more hosts in thecompute collection by update TN(transport node) request on individualTN. If TN is successfully created for all hosts in compute collectionand one or more hosts have overridden configuration then transport nodecollection state will be &quot;PROFILE_MISMATCH&quot;.")]
    public enum NSXTTransportNodeCollectionStateStateEnumType
    {
        [EnumMember(Value = "FAILED_TO_CREATE")]
        FAILEDTOCREATE = 1,
        [EnumMember(Value = "FAILED_TO_REALIZE")]
        FAILEDTOREALIZE = 2,
        [EnumMember(Value = "IN_PROGRESS")]
        INPROGRESS = 3,
        [EnumMember(Value = "PROFILE_MISMATCH")]
        PROFILEMISMATCH = 4,
        [EnumMember(Value = "SUCCESS")]
        SUCCESS = 5,
    }
}
