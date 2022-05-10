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
    public class NSXTTraceflowType : NSXTManagedResourceType
    {
        /// <summary>
        /// Represents the traceflow operation state
        /// </summary>
        [JsonProperty(PropertyName = "operation_state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTraceflowOperationStateEnumType? OperationState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "logical_counters")]
        public NSXTTraceflowObservationCountersType LogicalCounters { get; set; }
        /// <summary>
        /// Maximum time (in ms) the management plane will be waiting for this traceflow round. Upper limit for federation case is
        /// 90000, for non-federation case is 15000, the maximum is set to 90000 as the higher of the two cases.
        /// </summary>
        [JsonProperty(PropertyName = "timeout")]
        public long? Timeout { get; set; }
        /// <summary>
        /// A flag, when set true, indicates some observations were deleted from the result set.
        /// </summary>
        [JsonProperty(PropertyName = "result_overflowed")]
        public bool? ResultOverflowed { get; set; }
        /// <summary>
        /// id of the source logical port used for injecting the traceflow packet
        /// </summary>
        [JsonProperty(PropertyName = "lport_id")]
        public string? LportId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "counters")]
        public NSXTTraceflowObservationCountersType Counters { get; set; }
        /// <summary>
        /// The status of the traceflow RPC request. SUCCESS - The traceflow request is sent successfully. TIMEOUT - The traceflow
        /// request gets timeout. SOURCE_PORT_NOT_FOUND - The source port of the request cannot be found. DATA_PATH_NOT_READY - The
        /// datapath component cannot be ready to receive request. CONNECTION_ERROR - There is connection error on datapath
        /// component. UNKNOWN - The status of traceflow request cannot be determined.
        /// </summary>
        [JsonProperty(PropertyName = "request_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTraceflowRequestStatusEnumType? RequestStatus { get; set; }
        /// <summary>
        /// Traceflow result analysis notes
        /// </summary>
        [JsonProperty(PropertyName = "analysis")]
        public IList<string> Analysis { get; set; }
        /// <summary>
        /// The id of the traceflow round
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
    }
}
