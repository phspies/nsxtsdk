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
    public class NSXTLbServiceInstanceDetailPerStatusType 
    {
        /// <summary>
        /// The type of load balancer instance status.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbServiceInstanceDetailPerStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// It means the total number of instances in this status type for the
        /// given transport node.
        /// </summary>
        [JsonProperty(PropertyName = "instance_number")]
        public long? InstanceNumber { get; set; }
        /// <summary>
        /// The detailed information of the load balancer instance. This field
        /// will be only returned on realtime status API.
        /// </summary>
        [JsonProperty(PropertyName = "instance_details")]
        public IList<NSXTLbServiceInstanceDetailType> InstanceDetails { get; set; }
    }
}
