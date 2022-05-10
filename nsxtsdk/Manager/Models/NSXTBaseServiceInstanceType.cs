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
    public class NSXTBaseServiceInstanceType : NSXTManagedResourceType
    {
        /// <summary>
        /// Failure policy of the service instance - if it has to be different from the service. By default the service instance
        /// inherits the FailurePolicy of the service it belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "on_failure_policy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTBaseServiceInstanceOnFailurePolicyEnumType? OnFailurePolicy { get; set; }
        /// <summary>
        /// Transport to be used by this service instance for deploying the Service-VM. This field is to be set Not Applicable(NA)
        /// if the service only caters to functionality EPP(Endpoint Protection) and MPS.
        /// </summary>
        [JsonProperty(PropertyName = "transport_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTBaseServiceInstanceTransportTypeEnumType TransportType { get; set; }
        /// <summary>
        /// ServiceInstance is used when NSX handles the lifecyle of
        /// appliance. Deployment and appliance related all the information is necessary.
        /// ByodServiceInstance is a custom instance to be used when NSX is not handling
        /// the lifecycles of appliance/s. User will manage their own appliance (BYOD)
        /// to connect with NSX.
        /// VirtualServiceInstance is a a custom instance to be used when NSX is not
        /// handling the lifecycle of an appliance and when the user is not bringing
        /// their own appliance.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTBaseServiceInstanceResourceTypeEnumType ResourceType { get; set; }
        /// <summary>
        /// The Service to which the service instance is associated.
        /// </summary>
        [JsonProperty(PropertyName = "service_id")]
        public string? ServiceId { get; set; }
    }
}
