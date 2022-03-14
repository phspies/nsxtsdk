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
        public NSXTBasePolicyServiceInstanceTransportTypeEnumType? TransportType { get; set; }
        /// <summary>
        /// Deployment mode specifies how the partner appliance will be deployed i.e. in HA or standalone mode.
        /// </summary>
        public NSXTBasePolicyServiceInstanceDeploymentModeEnumType? DeploymentMode { get; set; }
    }
}
