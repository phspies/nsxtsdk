// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Used to get the mp policy promotion state. If system is under mp to policy promotion, it will be PROMOTION_IN_PROGRESS else PROMOTION_NOT_IN_PROGRESS.State is CANCELLING_PROMOTION, if ongoing promotion is cancelled.
    /// </summary>
    [NSXTProperty(Description: @"Used to get the mp policy promotion state. If system is under mp to policy promotion, it will be PROMOTION_IN_PROGRESS else PROMOTION_NOT_IN_PROGRESS.State is CANCELLING_PROMOTION, if ongoing promotion is cancelled.")]
    public enum NSXTMppolicyPromotionStateMpPolicyPromotionEnumType
    {
        [EnumMember(Value = "PROMOTION_IN_PROGRESS")]
        PROMOTIONINPROGRESS = 1,
        [EnumMember(Value = "CANCELLING_PROMOTION")]
        CANCELLINGPROMOTION = 2,
        [EnumMember(Value = "PROMOTION_NOT_IN_PROGRESS")]
        PROMOTIONNOTINPROGRESS = 3,
        [EnumMember(Value = "CANCEL_FAILED")]
        CANCELFAILED = 4,
    }
}
