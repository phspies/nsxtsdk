// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

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
        public IList<NSXTLbPoolType> Pools { get; set; }
        /// <summary>
        /// The persistence profiles are associated to virtual servers
        /// </summary>
        public IList<NSXTLbPersistenceProfileType> PersistenceProfiles { get; set; }
        /// <summary>
        /// The virtual servers which are associated to the given load balancer
        /// service would be included.
        /// </summary>
        public IList<NSXTLbVirtualServerType> VirtualServers { get; set; }
        /// <summary>
        /// The client SSL profiles are associated to virtual servers.
        /// The property is deprecated as NSX-T Load Balancer is deprecated.
        /// </summary>
        public IList<NSXTLbClientSslProfileType> ClientSslProfiles { get; set; }
        /// <summary>
        /// The server SSL profiles are associated to virtual servers.
        /// The property is deprecated as NSX-T Load Balancer is deprecated.
        /// </summary>
        public IList<NSXTLbServerSslProfileType> ServerSslProfiles { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NSXTLbServiceType Service { get; set; }
        /// <summary>
        /// The load balancer rules are associated to virtual servers.
        /// The property is deprecated as NSX-T Load Balancer is deprecated.
        /// </summary>
        public IList<NSXTLbRuleType> Rules { get; set; }
        /// <summary>
        /// The application profiles are associated to virtual servers
        /// </summary>
        public IList<NSXTLbAppProfileType> ApplicationProfiles { get; set; }
        /// <summary>
        /// The load balancer monitors are associated to pools.
        /// The property is deprecated as NSX-T Load Balancer is deprecated.
        /// </summary>
        public IList<NSXTLbMonitorType> Monitors { get; set; }
    }
}
