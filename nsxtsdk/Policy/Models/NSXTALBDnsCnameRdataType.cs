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
    /// Advanced load balancer DnsCnameRdata object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DnsCnameRdata object")]
    public class NSXTALBDnsCnameRdataType 
    {
        /// <summary>
        /// Canonical name.
        /// </summary>
        [JsonProperty(PropertyName = "cname", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Canonical name.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Cname { get; set; }
    }
}