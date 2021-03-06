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
    public class NSXTLbVirtualServerWithRuleType 
    {
        /// <summary>
        /// It is used to add rules, update rules and bind rules to the virtual
        /// server.
        /// To add new rules, make sure that the rules have no identifier
        /// specified, the new rules are automatically generated and associated to
        /// the virtual server.
        /// If the virtual server need to consume some existed rules without
        /// change, those rules should not be specified in the list, otherwise,
        /// the rules are updated.
        /// For update_with_rules action, it supports rules delete and update.
        /// To delete old rules, the rules should not be configured in new action,
        /// the UUID of deleted rules should be removed from rule_ids.
        /// To update rules, the rules should be specified with new change and
        /// configured with identifier.
        /// If there are some rules which are not modified, those rule should not
        /// be specified in the rules list, the UUID list of rules should be
        /// specified in rule_ids of LbVirtualServer.
        /// The property is deprecated as NSX-T Load Balancer is deprecated.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<NSXTLbRuleType> Rules { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "virtual_server", Required = Required.AllowNull)]
        public NSXTLbVirtualServerType VirtualServer { get; set; }
    }
}
