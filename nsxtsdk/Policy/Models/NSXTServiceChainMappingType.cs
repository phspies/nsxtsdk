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
    /// A ServiceInsertionServiceProfile can be part of multiple ServiceChains. ServiceChainMapping for a particular profile
        /// will contain a list of all the ServiceChains it's part of. Each Mapping will also contain some metadata to uniquely
        /// identify a profile from other profiles.
    /// </summary>
    [NSXTProperty(Description: @"A ServiceInsertionServiceProfile can be part of multiple ServiceChains. ServiceChainMapping for a particular profile will contain a list of all the ServiceChains it&apos;s part of. Each Mapping will also contain some metadata to uniquely identify a profile from other profiles.")]
    public class NSXTServiceChainMappingType 
    {
        /// <summary>
        /// A unique id generated for every ServiceChain. This is not a uuid.
        /// </summary>
        [JsonProperty(PropertyName = "service_chain_id")]
        public string? ServiceChainId { get; set; }
        /// <summary>
        /// Each ServiceChain has forward_path_service_profiles and reverse_path_service_profiles. This property will indicate which
        /// of them being used. FORWARD - forward_path_service_profiles REVERSE - reverse_path_service_profiles
        /// </summary>
        [JsonProperty(PropertyName = "direction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTServiceChainMappingDirectionEnumType? Direction { get; set; }
        /// <summary>
        /// Service Index represents a numerical position of a ServiceInsertionServiceProfile in a ServiceChain. It will be in
        /// reverse order. Service Index can point to either forward_path_service_profiles or reverse_path_service_profiles
        /// indicated by direction property. Example - For a ServiceChain A-B-C, A will have index of 3, B will have index of 2 and
        /// C will have index of 1.
        /// </summary>
        [JsonProperty(PropertyName = "service_index")]
        public long? ServiceIndex { get; set; }
    }
}
