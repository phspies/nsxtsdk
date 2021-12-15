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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTCrlObjectDataType : NSXTManagedResourceType
    {
        /// <summary>
        /// PEM encoded CRL data.
        /// </summary>
        [JsonProperty(PropertyName = "pem_encoded", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"PEM encoded CRL data.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string PemEncoded { get; set; }
    }
}