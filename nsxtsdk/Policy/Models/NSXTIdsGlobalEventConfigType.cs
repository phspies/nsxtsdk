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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTIdsGlobalEventConfigType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// When this flag is set to true, IDS events will
        /// be sent to kafka, for consumption by components such as
        /// NSX-I and NDR.
        /// </summary>
        [JsonProperty(PropertyName = "publish_ids_events")]
        public bool? PublishIdsEvents { get; set; }
        /// <summary>
        /// kafka topic into which to publish IDS events.
        /// </summary>
        [JsonProperty(PropertyName = "ids_data_topic_name")]
        public string? IdsDataTopicName { get; set; }
    }
}
