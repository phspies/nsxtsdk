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
    /// Details of infrastructure hosting the container cluster
        /// e.g. vSphere, AWS, VMC etc..
    /// </summary>
    [NSXTProperty(Description: @"Details of infrastructure hosting the container clustere.g. vSphere, AWS, VMC etc..")]
    public class NSXTContainerInfrastructureInfoType 
    {
        public NSXTContainerInfrastructureInfoType()
        {
        }
        /// <summary>
        /// Type of the infrastructure.
        /// </summary>
        [JsonProperty(PropertyName = "infra_type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Type of the infrastructure.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTContainerInfrastructureInfoInfraTypeEnumType InfraType { get; set; }
    }
}
