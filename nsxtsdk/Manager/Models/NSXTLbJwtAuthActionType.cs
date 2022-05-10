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
    public class NSXTLbJwtAuthActionType : NSXTLbRuleActionType
    {
        /// <summary>
        /// JWT is an open standard that defines a compact and
        /// self-contained way for securely transmitting information between
        /// parties as a JSON object. Load balancer will search for every specified
        /// tokens one by one for the jwt message until found. This parameter is
        /// optional. In case not found or this field is not configured, load
        /// balancer searches the Bearer header by default in the http request
        /// "Authorization: Bearer <token>".
        /// </summary>
        [JsonProperty(PropertyName = "tokens")]
        public IList<string> Tokens { get; set; }
        /// <summary>
        /// Specify whether to pass the JWT to backend server or remove it. By
        /// default, it is false which means will not pass the JWT to backend
        /// servers.
        /// </summary>
        [JsonProperty(PropertyName = "pass_jwt_to_pool")]
        public bool? PassJwtToPool { get; set; }
        /// <summary>
        /// A description of the protected area. If no realm is specified, clients
        /// often display a formatted hostname instead. The configured realm is
        /// returned when client request is rejected with 401 http status. In the
        /// response, it will be "WWW-Authentication: Bearer realm=<realm>".
        /// </summary>
        [JsonProperty(PropertyName = "realm")]
        public string? Realm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public NSXTLbJwtKeyType Key { get; set; }
    }
}
