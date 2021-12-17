// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// This flag is used to enable/disable admin state on tier-1 service port.If admin_state flag value is not specified then default is UP. When set to UPthen traffic on service port will be enabled and service port is enabled fromrouting perspective. When set to DOWN then traffic on service port will bedisabled and service port is down from routing perspective. This flag isexperimental because it will be used in V2T BYOT migration.
    /// </summary>
    [NSXTProperty(Description: @"This flag is used to enable/disable admin state on tier-1 service port.If admin_state flag value is not specified then default is UP. When set to UPthen traffic on service port will be enabled and service port is enabled fromrouting perspective. When set to DOWN then traffic on service port will bedisabled and service port is down from routing perspective. This flag isexperimental because it will be used in V2T BYOT migration.")]
    public enum NSXTTier1InterfaceAdminStateEnumType
    {
        [EnumMember(Value = "UP")]
        UP = 1,
        [EnumMember(Value = "DOWN")]
        DOWN = 2,
    }
}
