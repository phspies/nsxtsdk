// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Both session cookie and persistence cookie are supported,Use LbSessionCookieTime for session cookie time setting,Use LbPersistenceCookieTime for persistence cookie time setting
    /// </summary>
    [NSXTProperty(Description: @"Both session cookie and persistence cookie are supported,Use LbSessionCookieTime for session cookie time setting,Use LbPersistenceCookieTime for persistence cookie time setting")]
    public enum NSXTLbCookieTimeTypeEnumType
    {
        [EnumMember(Value = "LBSESSIONCOOKIETIME")]
        LbSessionCookieTime = 1,
        [EnumMember(Value = "LBPERSISTENCECOOKIETIME")]
        LbPersistenceCookieTime = 2,
    }
}
