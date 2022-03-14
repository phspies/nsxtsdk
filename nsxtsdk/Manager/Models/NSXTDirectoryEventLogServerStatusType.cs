// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

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
        public NSXTDirectoryEventLogServerStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Additional optional detail error message
        /// </summary>
        public string? ErrorMessage { get; set; }
        /// <summary>
        /// Time of last successfully received and record event from event log server.
        /// </summary>
        public long? LastEventTimeCreated { get; set; }
        /// <summary>
        /// Last polling time
        /// </summary>
        public long? LastPollingTime { get; set; }
        /// <summary>
        /// Last event record ID is an opaque integer value that shows the last successfully received event from event log server.
        /// </summary>
        public long? LastEventRecordId { get; set; }
    }
}
