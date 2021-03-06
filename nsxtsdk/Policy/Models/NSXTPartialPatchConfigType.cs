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
    /// This object allows enabling or disabling of partial patch functionality.
        /// Enabling partial patch allows patching of a subset of the fields of any object.
        /// After enabling partial patching, any object payload provided will be merged with the existing object payload.
        /// Note that while all mandatory fields are expected to be provided during the creation of any object,
        /// enabling partial patch will allow patching of existing objects with a subset of mandatory fields.
    /// </summary>
    [NSXTProperty(Description: @"This object allows enabling or disabling of partial patch functionality.Enabling partial patch allows patching of a subset of the fields of any object.After enabling partial patching, any object payload provided will be merged with the existing object payload.Note that while all mandatory fields are expected to be provided during the creation of any object,enabling partial patch will allow patching of existing objects with a subset of mandatory fields.")]
    public class NSXTPartialPatchConfigType 
    {
        /// <summary>
        /// boolean value used to enable/disable partial patch
        /// </summary>
        [JsonProperty(PropertyName = "enable_partial_patch", Required = Required.AllowNull)]
        public bool EnablePartialPatch { get; set; }
    }
}
