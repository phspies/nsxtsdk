using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTTransportNodeProfileType : NSXTManagedResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "host_switch_spec")]
        public NSXTHostSwitchSpecType HostSwitchSpec { get; set; }
        /// <summary>
        /// Transport Node Profiles specify the configuration that is applied to all
        /// hosts in a cluster. The user has the ability to update the configuration
        /// on individual hosts within a cluster which will cause the host configuration
        /// to differ from the Transport Node Profile and results in the host to be
        /// marked as overridden. If a Transport Node Profile is edited or a new
        /// Transport Node Profile is applied on a Transport Node Collection, by default,
        /// the host configuration will be overwritten with the Transport Node Profile
        /// configuration and the overridden flag will be reset to false. This flag
        /// should be used when hosts that are set as overridden should not adopt the
        /// Transport Node Profile configuration when it is being updated or a new one
        /// is applied to the Transport Node Collection. In other words, when this flag is
        /// set to the default value of false and configuration is applied at the cluster
        /// level, the configuration will be applied on all hosts regardless if overridden
        /// or not. When this flag is set to true, all hosts that are set as overridden, i.e.,
        /// have been updated invidivually, will be ignored and the cluster-level configuration
        /// will not be applied.
        /// Note, Transport Node Profiles can be applied on multiple clusters. This field will
        /// dictate the behavior followed by all clusters using this Transport Node Profile.
        /// </summary>
        [JsonProperty(PropertyName = "ignore_overridden_hosts")]
        public bool? IgnoreOverriddenHosts { get; set; }
    }
}
