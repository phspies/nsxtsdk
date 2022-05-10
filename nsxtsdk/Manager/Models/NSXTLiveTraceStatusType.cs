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
    public class NSXTLiveTraceStatusType : NSXTManagedResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "filter")]
        public NSXTLiveTraceFilterDataType Filter { get; set; }
        /// <summary>
        /// The operation state of Livetrace.
        /// IN_PROGRESS - collecting the session results.
        /// FINISHED - session results collection completes.
        /// PARTIAL_FINISHED - session results may be incomplete.
        /// CANCELED - session is cancelled by exception.
        /// INVALIDATED - session is invalidated by configuration changes such as VM migration.
        /// TIMEOUT - session is not completed on time.
        /// </summary>
        [JsonProperty(PropertyName = "operation_state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLiveTraceStatusOperationStateEnumType? OperationState { get; set; }
        /// <summary>
        /// The detail of invalid filter(s) in a Livetrace session.
        /// This field is only applicable for filters of PlainFilterData type.
        /// </summary>
        [JsonProperty(PropertyName = "filter_invalid_info")]
        public IList<NSXTLiveTraceFilterInvalidInfoType> FilterInvalidInfo { get; set; }
        /// <summary>
        /// Timeout in seconds for livetrace session
        /// </summary>
        [JsonProperty(PropertyName = "timeout")]
        public long? Timeout { get; set; }
        /// <summary>
        /// The source logical port
        /// </summary>
        [JsonProperty(PropertyName = "source_lport")]
        public string? SourceLport { get; set; }
        /// <summary>
        /// The reason of invalidating a Livetrace session.
        /// PORT_DISCONNECT - Source or destination logical port of the session is disconnected.
        /// DP_DESTROY - Dataplane is destroyed.
        /// UNKNOWN - The invalidation reason cannot be determined.
        /// </summary>
        [JsonProperty(PropertyName = "invalidation_reason")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLiveTraceStatusInvalidationReasonEnumType? InvalidationReason { get; set; }
        /// <summary>
        /// The status of a Livetrace request.
        /// SUCCESS_DELIVERED - The request is delivered successfully.
        /// LCP_FAILURE - LCP agent fails to realize the request.
        /// INVALID_FILTER - Filter is invalid.
        /// DATAPATH_FAILURE - Dataplane fails to realize the request.
        /// TIMEOUT - The response to the request is not received within timeout.
        /// CONNECTION_ERROR - There is connection error between host components.
        /// UNKNOWN - The status of request cannot be determined.
        /// </summary>
        [JsonProperty(PropertyName = "request_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLiveTraceStatusRequestStatusEnumType? RequestStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "actions")]
        public NSXTLiveTraceActionConfigType Actions { get; set; }
    }
}
