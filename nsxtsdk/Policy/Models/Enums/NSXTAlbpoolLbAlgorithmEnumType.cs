// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// The load balancing algorithm will pick a server within thepool&apos;s list of available servers.Values LB_ALGORITHM_NEAREST_SERVER andLB_ALGORITHM_TOPOLOGY are only allowed for GSLB pool.Enum options - LB_ALGORITHM_LEAST_CONNECTIONS,LB_ALGORITHM_ROUND_ROBIN, LB_ALGORITHM_FASTEST_RESPONSE,LB_ALGORITHM_CONSISTENT_HASH, LB_ALGORITHM_LEAST_LOAD,LB_ALGORITHM_FEWEST_SERVERS, LB_ALGORITHM_RANDOM,LB_ALGORITHM_FEWEST_TASKS, LB_ALGORITHM_NEAREST_SERVER,LB_ALGORITHM_CORE_AFFINITY, LB_ALGORITHM_TOPOLOGY.Allowed in Basic(Allowed values-LB_ALGORITHM_LEAST_CONNECTIONS,LB_ALGORITHM_ROUND_ROBIN,LB_ALGORITHM_CONSISTENT_HASH)edition, Essentials(Allowed values-LB_ALGORITHM_LEAST_CONNECTIONS,LB_ALGORITHM_ROUND_ROBIN,LB_ALGORITHM_CONSISTENT_HASH)edition, Enterprise edition.Default value when not specified in API or module isinterpreted by ALB Controller asLB_ALGORITHM_LEAST_CONNECTIONS.
    /// </summary>
    [NSXTProperty(Description: @"The load balancing algorithm will pick a server within thepool&apos;s list of available servers.Values LB_ALGORITHM_NEAREST_SERVER andLB_ALGORITHM_TOPOLOGY are only allowed for GSLB pool.Enum options - LB_ALGORITHM_LEAST_CONNECTIONS,LB_ALGORITHM_ROUND_ROBIN, LB_ALGORITHM_FASTEST_RESPONSE,LB_ALGORITHM_CONSISTENT_HASH, LB_ALGORITHM_LEAST_LOAD,LB_ALGORITHM_FEWEST_SERVERS, LB_ALGORITHM_RANDOM,LB_ALGORITHM_FEWEST_TASKS, LB_ALGORITHM_NEAREST_SERVER,LB_ALGORITHM_CORE_AFFINITY, LB_ALGORITHM_TOPOLOGY.Allowed in Basic(Allowed values-LB_ALGORITHM_LEAST_CONNECTIONS,LB_ALGORITHM_ROUND_ROBIN,LB_ALGORITHM_CONSISTENT_HASH)edition, Essentials(Allowed values-LB_ALGORITHM_LEAST_CONNECTIONS,LB_ALGORITHM_ROUND_ROBIN,LB_ALGORITHM_CONSISTENT_HASH)edition, Enterprise edition.Default value when not specified in API or module isinterpreted by ALB Controller asLB_ALGORITHM_LEAST_CONNECTIONS.")]
    public enum NSXTAlbpoolLbAlgorithmEnumType
    {
        [EnumMember(Value = "LB_ALGORITHM_LEAST_CONNECTIONS")]
        LBALGORITHMLEASTCONNECTIONS = 1,
        [EnumMember(Value = "LB_ALGORITHM_ROUND_ROBIN")]
        LBALGORITHMROUNDROBIN = 2,
        [EnumMember(Value = "LB_ALGORITHM_FASTEST_RESPONSE")]
        LBALGORITHMFASTESTRESPONSE = 3,
        [EnumMember(Value = "LB_ALGORITHM_CONSISTENT_HASH")]
        LBALGORITHMCONSISTENTHASH = 4,
        [EnumMember(Value = "LB_ALGORITHM_LEAST_LOAD")]
        LBALGORITHMLEASTLOAD = 5,
        [EnumMember(Value = "LB_ALGORITHM_FEWEST_SERVERS")]
        LBALGORITHMFEWESTSERVERS = 6,
        [EnumMember(Value = "LB_ALGORITHM_RANDOM")]
        LBALGORITHMRANDOM = 7,
        [EnumMember(Value = "LB_ALGORITHM_FEWEST_TASKS")]
        LBALGORITHMFEWESTTASKS = 8,
        [EnumMember(Value = "LB_ALGORITHM_NEAREST_SERVER")]
        LBALGORITHMNEARESTSERVER = 9,
        [EnumMember(Value = "LB_ALGORITHM_CORE_AFFINITY")]
        LBALGORITHMCOREAFFINITY = 10,
        [EnumMember(Value = "LB_ALGORITHM_TOPOLOGY")]
        LBALGORITHMTOPOLOGY = 11,
    }
}
