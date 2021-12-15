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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// An endpoint to connect to NSX-Intelligence broker.
        /// Either FQDN or IP address can be used in the endpoint info.
    /// </summary>
    [NSXTProperty(Description: @"An endpoint to connect to NSX-Intelligence broker.Either FQDN or IP address can be used in the endpoint info.")]
    public class NSXTIntelligenceBrokerEndpointInfoType 
    {
        /// <summary>
        /// The port number where the broker is listening to.
        /// </summary>
        [JsonProperty(PropertyName = "port", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The port number where the broker is listening to.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(65535)]
        [System.ComponentModel.DataAnnotations.Required]
        public long Port { get; set; }
        /// <summary>
        /// The IP address or the full qualified domain name of broker.
        /// </summary>
        [JsonProperty(PropertyName = "address", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The IP address or the full qualified domain name of broker.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Address { get; set; }
    }
}