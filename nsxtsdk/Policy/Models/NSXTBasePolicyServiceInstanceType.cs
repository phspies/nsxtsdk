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
    public class NSXTBasePolicyServiceInstanceType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Unique name of Partner Service in the Marketplace
        /// </summary>
        [JsonProperty(PropertyName = "partner_service_name", Required = Required.AllowNull)]
        public string PartnerServiceName { get; set; }
        /// <summary>
        /// Transport to be used while deploying Service-VM.
        /// </summary>
        [JsonProperty(PropertyName = "transport_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTBasePolicyServiceInstanceTransportTypeEnumType? TransportType { get; set; }
        /// <summary>
        /// Deployment mode specifies how the partner appliance will be deployed i.e. in HA or standalone mode.
        /// </summary>
        [JsonProperty(PropertyName = "deployment_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTBasePolicyServiceInstanceDeploymentModeEnumType? DeploymentMode { get; set; }
    }
}
