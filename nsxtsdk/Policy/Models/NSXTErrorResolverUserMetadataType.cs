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
    /// User supplied metadata needed for resolving errors
    /// </summary>
    [NSXTProperty(Description: @"User supplied metadata needed for resolving errors")]
    public class NSXTErrorResolverUserMetadataType 
    {
        /// <summary>
        /// List of user supplied input data.
        /// </summary>
        [JsonProperty(PropertyName = "user_input_list")]
        public IList<NSXTErrorResolverUserInputDataType> UserInputList { get; set; }
    }
}
