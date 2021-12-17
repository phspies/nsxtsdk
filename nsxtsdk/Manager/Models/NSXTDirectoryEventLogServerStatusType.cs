// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Event log server connection status
    /// </summary>
    [NSXTProperty(Description: @"Event log server connection status")]
    public class NSXTDirectoryEventLogServerStatusType 
    {
        public NSXTDirectoryEventLogServerStatusType()
        {
        }
        /// <summary>
        /// Connection status:
        /// OK: All OK
        /// ERROR: Generic error
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [NSXTProperty(IsRequired: false, Description: @"Connection status:    OK: All OK    ERROR: Generic error")]
        public NSXTDirectoryEventLogServerStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Additional optional detail error message
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        [NSXTProperty(IsRequired: false, Description: @"Additional optional detail error message")]
        public string? ErrorMessage { get; set; }
        /// <summary>
        /// Time of last successfully received and record event from event log server.
        /// </summary>
        [JsonProperty(PropertyName = "last_event_time_created")]
        [NSXTProperty(IsRequired: false, Description: @"Time of last successfully received and record event from event log server.")]
        public long? LastEventTimeCreated { get; set; }
        /// <summary>
        /// Last polling time
        /// </summary>
        [JsonProperty(PropertyName = "last_polling_time")]
        [NSXTProperty(IsRequired: false, Description: @"Last polling time")]
        public long? LastPollingTime { get; set; }
        /// <summary>
        /// Last event record ID is an opaque integer value that shows the last successfully received event from event log server.
        /// </summary>
        [JsonProperty(PropertyName = "last_event_record_id")]
        [NSXTProperty(IsRequired: false, Description: @"Last event record ID is an opaque integer value that shows the last successfully received event from event log server.")]
        public long? LastEventRecordId { get; set; }
    }
}
