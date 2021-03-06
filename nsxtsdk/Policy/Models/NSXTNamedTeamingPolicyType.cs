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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTNamedTeamingPolicyType : NSXTTeamingPolicyType
    {
        /// <summary>
        /// An uplink teaming policy of a given name defined in UplinkHostSwitchProfile. The names of all NamedTeamingPolicies in an
        /// UplinkHostSwitchProfile must be different, but a name can be shared by different UplinkHostSwitchProfiles. Different
        /// TransportNodes can use different NamedTeamingPolicies having the same name in different UplinkHostSwitchProfiles to
        /// realize an uplink teaming policy on a logical switch. An uplink teaming policy on a logical switch can be any policy
        /// defined by a user; it does not have to be a single type of FAILOVER or LOADBALANCE. It can be a combination of types,
        /// for instance, a user can define a policy with name "MyHybridTeamingPolicy" as "FAILOVER on all ESX TransportNodes and
        /// LOADBALANCE on all KVM TransportNodes". The name is the key of the teaming policy and can not be changed once assigned.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
    }
}
