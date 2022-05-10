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
    /// An entity that holds the list of IDS signatures attached
        /// to an IDS Profile depending upon the Profile's criteria.
        /// These are the Signatures which needs to be detected.
    /// </summary>
    [NSXTProperty(Description: @"An entity that holds the list of IDS signatures attachedto an IDS Profile depending upon the Profile&apos;s criteria.These are the Signatures which needs to be detected.")]
    public class NSXTIdsProfileSignaturesType 
    {
        /// <summary>
        /// List of IDS signature ids which need to be detected.
        /// </summary>
        [JsonProperty(PropertyName = "signatures")]
        public IList<string> Signatures { get; set; }
        /// <summary>
        /// Represents the Path of the IDS Profile.
        /// </summary>
        [JsonProperty(PropertyName = "profile_path")]
        public string? ProfilePath { get; set; }
    }
}
