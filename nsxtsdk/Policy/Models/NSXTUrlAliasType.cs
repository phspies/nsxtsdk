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
    /// Short name or alias of a url. It is used to represent the url.
    /// </summary>
    [NSXTProperty(Description: @"Short name or alias of a url. It is used to represent the url.")]
    public class NSXTUrlAliasType 
    {
        /// <summary>
        /// Short name or alias of url, if any. If not specified, the url can be referenced by its index in the array of urls of the
        /// datasource instance as $<index> (for example, $0).
        /// </summary>
        [JsonProperty(PropertyName = "alias")]
        public string? Alias { get; set; }
        /// <summary>
        /// Type of the http method (Get, Post) to be used while invoking the given url through dashboard datasource framework.
        /// </summary>
        [JsonProperty(PropertyName = "request_method")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTUrlAliasRequestMethodEnumType? RequestMethod { get; set; }
        /// <summary>
        /// A raw request body in the form json format for a given url. This request body will be submitted along with request while
        /// giving a post api call.
        /// </summary>
        [JsonProperty(PropertyName = "request_body")]
        public object? RequestBody { get; set; }
        /// <summary>
        /// Url to fetch data from.
        /// </summary>
        [JsonProperty(PropertyName = "url", Required = Required.AllowNull)]
        public string Url { get; set; }
        /// <summary>
        /// Search query to be applied, if any. If query string is not provided, it will be ignored.
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public string? Query { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "keystore_info")]
        public NSXTKeyStoreInfoType KeystoreInfo { get; set; }
        /// <summary>
        /// A raw request header in the form json format for a given url. This request header will be submitted along with request
        /// while giving a api call.
        /// </summary>
        [JsonProperty(PropertyName = "request_headers")]
        public object? RequestHeaders { get; set; }
    }
}
