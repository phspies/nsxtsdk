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
    /// List of errors with their metadata
    /// </summary>
    [NSXTProperty(Description: @"List of errors with their metadata")]
    public class NSXTErrorResolverMetadataListType 
    {
        /// <summary>
        /// List of errors with their corresponding metadata.
        /// </summary>
        [JsonProperty(PropertyName = "errors", Required = Required.AllowNull)]
        public IList<NSXTErrorResolverMetadataType> Errors { get; set; }
    }
}
