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
    /// Provides insights into details of a specific queue in the flows. For example
        /// Global Manager to Local Manager flow, there is a queue on the Global Manager
        /// for sending and a queue on Local Manager for receiving.
    /// </summary>
    [NSXTProperty(Description: @"Provides insights into details of a specific queue in the flows. For exampleGlobal Manager to Local Manager flow, there is a queue on the Global Managerfor sending and a queue on Local Manager for receiving.")]
    public class NSXTFederationQueueInfoType 
    {
        /// <summary>
        /// Queue type - sender or receiver side
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTFederationQueueInfoTypeEnumType? Type { get; set; }
        /// <summary>
        /// Every persistent queue has name and namespace. For more debugging like
        /// dumping queue, namespace is needed.
        /// </summary>
        [JsonProperty(PropertyName = "namespace")]
        public string? NamespaceProperty { get; set; }
        /// <summary>
        /// Queue name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Maixmum capacity of the queue
        /// </summary>
        [JsonProperty(PropertyName = "max_size")]
        public long? MaxSize { get; set; }
        /// <summary>
        /// Number of messages in the queue
        /// </summary>
        [JsonProperty(PropertyName = "current_size")]
        public long? CurrentSize { get; set; }
    }
}
