// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Type of federation site. It can be GlobalManager or Site.
    /// </summary>
    [NSXTProperty(Description: @"Type of federation site. It can be GlobalManager or Site.")]
    public enum NSXTNsxtSiteFederationSiteTypeEnumType
    {
        [EnumMember(Value = "GLOBALMANAGER")]
        GlobalManager = 1,
        [EnumMember(Value = "SITE")]
        Site = 2,
    }
}