// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Run pre/post deployment checks.PRE_CHECKS - Run pre-check before deployment.POST_CHECKS - Run post-check after deployment.ABORT_CHECKS - Abort running pre/post deployement checks.
    /// </summary>
    [NSXTProperty(Description: @"Run pre/post deployment checks.PRE_CHECKS - Run pre-check before deployment.POST_CHECKS - Run post-check after deployment.ABORT_CHECKS - Abort running pre/post deployement checks.")]
    public enum NSXTDeploymentChecksActionActionEnumType
    {
        [EnumMember(Value = "PRE_CHECKS")]
        PRECHECKS = 1,
        [EnumMember(Value = "POST_CHECKS")]
        POSTCHECKS = 2,
        [EnumMember(Value = "ABORT_CHECKS")]
        ABORTCHECKS = 3,
    }
}