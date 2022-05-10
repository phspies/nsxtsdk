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
    /// Parameters to let the admin specify a relative position of a communication
        /// map or communication entry w.r.t to another one.
        /// This type is deprecated. Use the type RuleInsertParameters instead.
    /// </summary>
    [NSXTProperty(Description: @"Parameters to let the admin specify a relative position of a communicationmap or communication entry w.r.t to another one.This type is deprecated. Use the type RuleInsertParameters instead.")]
    public class NSXTCommunicationInsertParametersType 
    {
        /// <summary>
        /// The communication map/communication entry path if operation is
        /// 'insert_after' or 'insert_before'
        /// </summary>
        [JsonProperty(PropertyName = "anchor_path")]
        public string? AnchorPath { get; set; }
        /// <summary>
        /// Operation
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTCommunicationInsertParametersOperationEnumType? Operation { get; set; }
    }
}
