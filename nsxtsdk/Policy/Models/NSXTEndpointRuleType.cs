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
    public class NSXTEndpointRuleType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// The policy paths of service profiles are listed here. It pecifies what
        /// services are applied on the group. Currently only one is allowed.
        /// </summary>
        [JsonProperty(PropertyName = "service_profiles", Required = Required.AllowNull)]
        public IList<string> ServiceProfiles { get; set; }
        /// <summary>
        /// We need paths as duplicate names may exist for groups under different
        /// domains. In order to specify all groups, use the constant "ANY". This
        /// is case insensitive. If "ANY" is used, it should be the ONLY element
        /// in the group array. Error will be thrown if ANY is used in conjunction
        /// with other values.
        /// </summary>
        [JsonProperty(PropertyName = "groups", Required = Required.AllowNull)]
        public IList<string> Groups { get; set; }
        /// <summary>
        /// This field is used to resolve conflicts between multiple
        /// entries under EndpointPolicy. It will be system default value when not specified
        /// by user.
        /// </summary>
        [JsonProperty(PropertyName = "sequence_number")]
        public int? SequenceNumber { get; set; }
    }
}
