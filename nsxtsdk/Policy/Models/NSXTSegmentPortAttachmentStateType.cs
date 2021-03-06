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
    /// VIF attachment state of a segment port
    /// </summary>
    [NSXTProperty(Description: @"VIF attachment state of a segment port")]
    public class NSXTSegmentPortAttachmentStateType 
    {
        /// <summary>
        /// A segment port must be in one of following states.
        /// FREE - If there are no active attachers. The port may or
        /// may not have an attachment ID configured on it. This state is
        /// applicable only to port of static type.
        /// ATTACHED - Segment port has exactly one active attacher and no
        /// further configuration is pending.
        /// ATTACHED_PENDING_CONF - Segment port has exactly one attacher,
        /// however it may not have been configured completely. Additional
        /// configuration will be provided by other nsx components.
        /// ATTACHED_IN_MOTION - Segment port has multiple active attachers.
        /// This state represents a scenario where VM is moving from one
        /// location (host or storage) to another (e.g. vmotion, vSphere HA)
        /// DETACHED - A temporary state after all port attachers have
        /// been detached. This state is applicable only to a port of
        /// ephemeral type and the port will soon be deleted.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTSegmentPortAttachmentStateStateEnumType? State { get; set; }
        /// <summary>
        /// VM or vmknic entities that are attached to the Segment Port
        /// </summary>
        [JsonProperty(PropertyName = "attachers")]
        public IList<NSXTPortAttacherType> Attachers { get; set; }
        /// <summary>
        /// VIF ID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
    }
}
