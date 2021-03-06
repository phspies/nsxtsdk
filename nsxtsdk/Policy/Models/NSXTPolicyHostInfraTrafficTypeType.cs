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
        /// <summary>
        /// Dynamic resource pool traffic name
        /// </summary>
        [JsonProperty(PropertyName = "dynamic_res_pool_name")]
        public string? DynamicResPoolName { get; set; }
        /// <summary>
        /// Traffic types
        /// </summary>
        [JsonProperty(PropertyName = "traffic_name")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPolicyHostInfraTrafficTypeTrafficNameEnumType? TrafficName { get; set; }
    }
}
