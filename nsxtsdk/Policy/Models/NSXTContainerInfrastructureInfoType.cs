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
    /// Details of infrastructure hosting the container cluster
        /// e.g. vSphere, AWS, VMC etc..
    /// </summary>
    [NSXTProperty(Description: @"Details of infrastructure hosting the container clustere.g. vSphere, AWS, VMC etc..")]
    public class NSXTContainerInfrastructureInfoType 
    {
        /// <summary>
        /// Type of the infrastructure.
        /// </summary>
        [JsonProperty(PropertyName = "infra_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTContainerInfrastructureInfoInfraTypeEnumType InfraType { get; set; }
    }
}
