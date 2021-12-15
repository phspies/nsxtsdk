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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// The information for a given load balancer service could be used for
        /// debugging and troubleshooting. It includes load balancer service,
        /// associated virtual servers, associated pools, associated profiles such as
        /// persistence, SSL, application, associated monitors and associated rules.
    /// </summary>
    [NSXTProperty(Description: @"The information for a given load balancer service could be used fordebugging and troubleshooting. It includes load balancer service,associated virtual servers, associated pools, associated profiles such aspersistence, SSL, application, associated monitors and associated rules.")]
    public class NSXTLbServiceDebugInfoType 
    {
        /// <summary>
        /// The pools which are associated to the given load balancer service would
        /// be included. The pools could be defined in virtual server default pool,
        /// sorry pool or load balancer rule action.
        /// </summary>
        [JsonProperty(PropertyName = "pools")]
        [NSXTProperty(IsRequired: false, Description: @"The pools which are associated to the given load balancer service wouldbe included. The pools could be defined in virtual server default pool,sorry pool or load balancer rule action.")]
        public IList<NSXTLbPoolType> Pools { get; set; }
        /// <summary>
        /// The persistence profiles are associated to virtual servers
        /// </summary>
        [JsonProperty(PropertyName = "persistence_profiles")]
        [NSXTProperty(IsRequired: false, Description: @"The persistence profiles are associated to virtual servers")]
        public IList<NSXTLbPersistenceProfileType> PersistenceProfiles { get; set; }
        /// <summary>
        /// The virtual servers which are associated to the given load balancer
        /// service would be included.
        /// </summary>
        [JsonProperty(PropertyName = "virtual_servers")]
        [NSXTProperty(IsRequired: false, Description: @"The virtual servers which are associated to the given load balancerservice would be included.")]
        public IList<NSXTLbVirtualServerType> VirtualServers { get; set; }
        /// <summary>
        /// The client SSL profiles are associated to virtual servers
        /// </summary>
        [JsonProperty(PropertyName = "client_ssl_profiles")]
        [NSXTProperty(IsRequired: false, Description: @"The client SSL profiles are associated to virtual servers")]
        public IList<NSXTLbClientSslProfileType> ClientSslProfiles { get; set; }
        /// <summary>
        /// The server SSL profiles are associated to virtual servers
        /// </summary>
        [JsonProperty(PropertyName = "server_ssl_profiles")]
        [NSXTProperty(IsRequired: false, Description: @"The server SSL profiles are associated to virtual servers")]
        public IList<NSXTLbServerSslProfileType> ServerSslProfiles { get; set; }
        /// <summary>
        /// Load balancer service setting for a given load balancer service
        /// identifier.
        /// </summary>
        [JsonProperty(PropertyName = "service")]
        [NSXTProperty(IsRequired: false, Description: @"Load balancer service setting for a given load balancer serviceidentifier.")]
        public NSXTLbServiceType Service { get; set; }
        /// <summary>
        /// The load balancer rules are associated to virtual servers
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        [NSXTProperty(IsRequired: false, Description: @"The load balancer rules are associated to virtual servers")]
        public IList<NSXTLbRuleType> Rules { get; set; }
        /// <summary>
        /// The application profiles are associated to virtual servers
        /// </summary>
        [JsonProperty(PropertyName = "application_profiles")]
        [NSXTProperty(IsRequired: false, Description: @"The application profiles are associated to virtual servers")]
        public IList<NSXTLbAppProfileType> ApplicationProfiles { get; set; }
        /// <summary>
        /// The load balancer monitors are associated to pools.
        /// </summary>
        [JsonProperty(PropertyName = "monitors")]
        [NSXTProperty(IsRequired: false, Description: @"The load balancer monitors are associated to pools.")]
        public IList<NSXTLbMonitorType> Monitors { get; set; }
    }
}
