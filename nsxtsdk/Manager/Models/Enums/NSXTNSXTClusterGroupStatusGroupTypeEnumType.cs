// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Type of the group
    /// </summary>
    [NSXTProperty(Description: @"Type of the group")]
    public enum NSXTClusterGroupStatusGroupTypeEnumType
    {
        [EnumMember(Value = "MANAGER")]
        MANAGER = 1,
        [EnumMember(Value = "CONTROLLER")]
        CONTROLLER = 2,
        [EnumMember(Value = "POLICY")]
        POLICY = 3,
        [EnumMember(Value = "HTTPS")]
        HTTPS = 4,
        [EnumMember(Value = "DATASTORE")]
        DATASTORE = 5,
        [EnumMember(Value = "CLUSTER_BOOT_MANAGER")]
        CLUSTERBOOTMANAGER = 6,
        [EnumMember(Value = "GLOBAL_MANAGER")]
        GLOBALMANAGER = 7,
        [EnumMember(Value = "ASYNC_REPLICATOR")]
        ASYNCREPLICATOR = 8,
        [EnumMember(Value = "MONITORING")]
        MONITORING = 9,
        [EnumMember(Value = "IDPS_REPORTING")]
        IDPSREPORTING = 10,
        [EnumMember(Value = "CORFU_NONCONFIG")]
        CORFUNONCONFIG = 11,
    }
}