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
    public class NSXTPolicyDraftType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// When specified, a manual draft will be created w.r.t. the specified
        /// draft. If not specified, manual draft will be created w.r.t. the
        /// current published configuration.
        /// For an auto draft, this will always be null.
        /// </summary>
        [JsonProperty(PropertyName = "ref_draft_path")]
        public string? RefDraftPath { get; set; }
        /// <summary>
        /// Comments for a policy draft lock/unlock.
        /// </summary>
        [JsonProperty(PropertyName = "lock_comments")]
        public string? LockComments { get; set; }
        /// <summary>
        /// Indicates whether a draft should be locked. If the draft is locked by
        /// an user, then no other user would be able to modify or publish this
        /// draft. Once the user releases the lock, other users can then modify
        /// or publish this draft.
        /// </summary>
        [JsonProperty(PropertyName = "locked")]
        public bool? Locked { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "user_area")]
        public NSXTInfraType UserArea { get; set; }
        /// <summary>
        /// ID of the user who last modified the lock for a policy draft.
        /// </summary>
        [JsonProperty(PropertyName = "lock_modified_by")]
        public string? LockModifiedBy { get; set; }
        /// <summary>
        /// In case of a large draft, wherein the size of user_area is so big
        /// that it can not be stored into one draft object, the data is then gets
        /// stored into multiple chunks in a draft data store.
        /// This value represents the ID of that data store.
        /// </summary>
        [JsonProperty(PropertyName = "user_area_store_id")]
        public string? UserAreaStoreId { get; set; }
        /// <summary>
        /// In case of a large draft, wherein the size of system_area is so big
        /// that it can not be stored into one draft object, the data is then gets
        /// stored into multiple chunks in a draft data store.
        /// This value represents the ID of that data store.
        /// </summary>
        [JsonProperty(PropertyName = "system_area_store_id")]
        public string? SystemAreaStoreId { get; set; }
        /// <summary>
        /// Policy draft locked/unlocked time in epoch milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "lock_modified_time")]
        public long? LockModifiedTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "system_area")]
        public NSXTInfraType SystemArea { get; set; }
        /// <summary>
        /// Flag to indicate whether draft is auto created.
        /// True indicates that the draft is an auto draft.
        /// False indicates that the draft is a manual draft.
        /// </summary>
        [JsonProperty(PropertyName = "is_auto_draft")]
        public bool? IsAutoDraft { get; set; }
    }
}
