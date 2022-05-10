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
    /// Event log server connection status
    /// </summary>
    [NSXTProperty(Description: @"Event log server connection status")]
    public class NSXTDirectoryEventLogServerStatusType 
    {
        /// <summary>
        /// Connection status:
        /// OK: All OK
        /// ERROR: Generic error
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTDirectoryEventLogServerStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Additional optional detail error message
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public string? ErrorMessage { get; set; }
        /// <summary>
        /// Time of last successfully received and record event from event log server.
        /// </summary>
        [JsonProperty(PropertyName = "last_event_time_created")]
        public long? LastEventTimeCreated { get; set; }
        /// <summary>
        /// Last polling time
        /// </summary>
        [JsonProperty(PropertyName = "last_polling_time")]
        public long? LastPollingTime { get; set; }
        /// <summary>
        /// Last event record ID is an opaque integer value that shows the last successfully received event from event log server.
        /// </summary>
        [JsonProperty(PropertyName = "last_event_record_id")]
        public long? LastEventRecordId { get; set; }
    }
}
