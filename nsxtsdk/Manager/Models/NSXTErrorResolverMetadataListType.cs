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
    /// List of errors with their metadata
    /// </summary>
    [NSXTProperty(Description: @"List of errors with their metadata")]
    public class NSXTErrorResolverMetadataListType 
    {
        /// <summary>
        /// List of errors with their corresponding metadata.
        /// </summary>
        [JsonProperty(PropertyName = "errors", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"List of errors with their corresponding metadata.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTErrorResolverMetadataType> Errors { get; set; }
    }
}