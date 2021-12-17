// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// The traffic_name specifies the infrastructure traffic type and it
        /// must be one of the following system-defined types:
        /// FAULT_TOLERANCE is traffic for failover and recovery.
        /// HBR is traffic for Host based replication.
        /// ISCSI is traffic for Internet Small Computer System Interface.
        /// MANAGEMENT is traffic for host management.
        /// NFS is traffic related to file transfer in network file system.
        /// VDP is traffic for vSphere data protection.
        /// VIRTUAL_MACHINE is traffic generated by virtual machines.
        /// VMOTION is traffic for computing resource migration.
        /// VSAN is traffic generated by virtual storage area network.
        /// The dynamic_res_pool_name provides a name for the resource pool.
        /// It can be any arbitrary string.
        /// Either traffic_name or dynamic_res_pool_name must be set.
        /// If both are specified or omitted, an error will be returned.
    /// </summary>
    [NSXTProperty(Description: @"The traffic_name specifies the infrastructure traffic type and itmust be one of the following system-defined types:FAULT_TOLERANCE is traffic for failover and recovery.HBR is traffic for Host based replication.ISCSI is traffic for Internet Small Computer System Interface.MANAGEMENT is traffic for host management.NFS is traffic related to file transfer in network file system.VDP is traffic for vSphere data protection.VIRTUAL_MACHINE is traffic generated by virtual machines.VMOTION is traffic for computing resource migration.VSAN is traffic generated by virtual storage area network.The dynamic_res_pool_name provides a name for the resource pool.It can be any arbitrary string.Either traffic_name or dynamic_res_pool_name must be set.If both are specified or omitted, an error will be returned.")]
    public class NSXTPolicyHostInfraTrafficTypeType 
    {
        public NSXTPolicyHostInfraTrafficTypeType()
        {
        }
        /// <summary>
        /// Dynamic resource pool traffic name
        /// </summary>
        [JsonProperty(PropertyName = "dynamic_res_pool_name")]
        [NSXTProperty(IsRequired: false, Description: @"Dynamic resource pool traffic name")]
        public string? DynamicResPoolName { get; set; }
        /// <summary>
        /// Traffic types
        /// </summary>
        [JsonProperty(PropertyName = "traffic_name")]
        [NSXTProperty(IsRequired: false, Description: @"Traffic types")]
        public NSXTPolicyHostInfraTrafficTypeTrafficNameEnumType? TrafficName { get; set; }
    }
}