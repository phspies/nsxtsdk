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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTPolicyIgmpProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// The query response interval(seconds) is the maximum amount of time that can elapse between
        /// when the querier router sends a host-query message and when it receives a response
        /// from a host. Configuring this interval allows admins to adjust the burstiness of
        /// IGMP messages on the subnet; larger values make the traffic less bursty, as host
        /// responses are spread out over a larger interval.
        /// 
        /// The number of seconds represented by the query_max_response_time must be less than the query_interval.
        /// </summary>
        [JsonProperty(PropertyName = "query_max_response_time")]
        [NSXTProperty(IsRequired: false, Description: @"The query response interval(seconds) is the maximum amount of time that can elapse betweenwhen the querier router sends a host-query message and when it receives a responsefrom a host. Configuring this interval allows admins to adjust the burstiness ofIGMP messages on the subnet; larger values make the traffic less bursty, as hostresponses are spread out over a larger interval.The number of seconds represented by the query_max_response_time must be less than the query_interval.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(25)]
        [NSXTDefaultProperty(Default: "")]
        public long? QueryMaxResponseTime { get; set; }
        /// <summary>
        /// Interval(seconds) between general IGMP host-query messages.
        /// </summary>
        [JsonProperty(PropertyName = "query_interval")]
        [NSXTProperty(IsRequired: false, Description: @"Interval(seconds) between general IGMP host-query messages.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(1800)]
        [NSXTDefaultProperty(Default: "")]
        public long? QueryInterval { get; set; }
        /// <summary>
        /// The Robustness Variable allows tuning for the expected packet loss on a subnet.
        /// If a subnet is expected to be lossy, the Robustness Variable may be increased.
        /// IGMP is robust to (Robustness Variable-1) packet losses.
        /// The Robustness Variable must not be zero, and SHOULD NOT be one.
        /// </summary>
        [JsonProperty(PropertyName = "robustness_variable")]
        [NSXTProperty(IsRequired: false, Description: @"The Robustness Variable allows tuning for the expected packet loss on a subnet.If a subnet is expected to be lossy, the Robustness Variable may be increased.IGMP is robust to (Robustness Variable-1) packet losses.The Robustness Variable must not be zero, and SHOULD NOT be one.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(255)]
        [NSXTDefaultProperty(Default: "")]
        public long? RobustnessVariable { get; set; }
        /// <summary>
        /// Max Response Time inserted into Group-Specific Queries sent in response to Leave Group messages,
        /// and is also the amount of time between Group-Specific Query messages. This value may be tuned to
        /// modify the "leave latency" of the network.
        /// A reduced value results in reduced time to detect the loss of the last member of a group.
        /// </summary>
        [JsonProperty(PropertyName = "last_member_query_interval")]
        [NSXTProperty(IsRequired: false, Description: @"Max Response Time inserted into Group-Specific Queries sent in response to Leave Group messages,and is also the amount of time between Group-Specific Query messages. This value may be tuned tomodify the &quot;leave latency&quot; of the network.A reduced value results in reduced time to detect the loss of the last member of a group.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(25)]
        [NSXTDefaultProperty(Default: "")]
        public long? LastMemberQueryInterval { get; set; }
    }
}