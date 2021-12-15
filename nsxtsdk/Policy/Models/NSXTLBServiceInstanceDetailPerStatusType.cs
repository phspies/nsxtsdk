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
    public class NSXTLBServiceInstanceDetailPerStatusType 
    {
        /// <summary>
        /// The type of load balancer instance status.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [NSXTProperty(IsRequired: false, Description: @"The type of load balancer instance status.")]
        public NSXTLbserviceInstanceDetailPerStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// It means the total number of instances in this status type for the
        /// given transport node.
        /// </summary>
        [JsonProperty(PropertyName = "instance_number")]
        [NSXTProperty(IsRequired: false, Description: @"It means the total number of instances in this status type for thegiven transport node.")]
        public long? InstanceNumber { get; set; }
        /// <summary>
        /// The detailed information of the load balancer instance. This field
        /// will be only returned on realtime status API.
        /// </summary>
        [JsonProperty(PropertyName = "instance_details")]
        [NSXTProperty(IsRequired: false, Description: @"The detailed information of the load balancer instance. This fieldwill be only returned on realtime status API.")]
        public IList<NSXTLBServiceInstanceDetailType> InstanceDetails { get; set; }
    }
}
