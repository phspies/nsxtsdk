using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTManualHealthCheckType : NSXTManagedResourceType
    {
        /// <summary>
        /// The entity ID works as a filter param. Entity ID and entity type should
        /// be both provided or not at a query.
        /// </summary>
        [JsonProperty(PropertyName = "transport_zone_id", Required = Required.AllowNull)]
        public string TransportZoneId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "vlans", Required = Required.AllowNull)]
        public NSXTHealthCheckSpecVlansType Vlans { get; set; }
        /// <summary>
        /// The operation status for health check
        /// </summary>
        [JsonProperty(PropertyName = "operation_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTManualHealthCheckOperationStatusEnumType? OperationStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public NSXTHealthCheckResultType Result { get; set; }
    }
}
