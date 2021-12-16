// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Newtonsoft.Json;
using System.Net;
using nsxtsdk;
using nsxtsdk.Models;
using nsxtsdk.ManagerModels;

namespace nsxtapi.ManagerModules
{
    public class MetadataProxy
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public MetadataProxy(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTMetadataProxyType UpdateMetadataProxy(string ProxyId, NSXTMetadataProxyType MetadataProxy)
        {
            if (ProxyId == null) { throw new System.ArgumentNullException("ProxyId cannot be null"); }
            if (MetadataProxy == null) { throw new System.ArgumentNullException("MetadataProxy cannot be null"); }
            NSXTMetadataProxyType returnValue = default(NSXTMetadataProxyType);
            StringBuilder UpdateMetadataProxyServiceURL = new StringBuilder("/md-proxies/{proxy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            UpdateMetadataProxyServiceURL.Replace("{proxy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProxyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(MetadataProxy, defaultSerializationSettings));
            request.Resource = UpdateMetadataProxyServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + UpdateMetadataProxyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTMetadataProxyType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTMetadataProxyType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTMetadataProxyType ReadMetadataProxy(string ProxyId)
        {
            if (ProxyId == null) { throw new System.ArgumentNullException("ProxyId cannot be null"); }
            NSXTMetadataProxyType returnValue = default(NSXTMetadataProxyType);
            StringBuilder ReadMetadataProxyServiceURL = new StringBuilder("/md-proxies/{proxy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ReadMetadataProxyServiceURL.Replace("{proxy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProxyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadMetadataProxyServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ReadMetadataProxyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTMetadataProxyType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTMetadataProxyType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void DeleteMetadataProxy(string ProxyId)
        {
            if (ProxyId == null) { throw new System.ArgumentNullException("ProxyId cannot be null"); }
            
            StringBuilder DeleteMetadataProxyServiceURL = new StringBuilder("/md-proxies/{proxy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeleteMetadataProxyServiceURL.Replace("{proxy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProxyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteMetadataProxyServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + DeleteMetadataProxyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTMetadataProxyType CreateMetadataProxy(NSXTMetadataProxyType MetadataProxy)
        {
            if (MetadataProxy == null) { throw new System.ArgumentNullException("MetadataProxy cannot be null"); }
            NSXTMetadataProxyType returnValue = default(NSXTMetadataProxyType);
            StringBuilder CreateMetadataProxyServiceURL = new StringBuilder("/md-proxies");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(MetadataProxy, defaultSerializationSettings));
            request.Resource = CreateMetadataProxyServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + CreateMetadataProxyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTMetadataProxyType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTMetadataProxyType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTMetadataProxyListResultType ListMetadataProxy(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            NSXTMetadataProxyListResultType returnValue = default(NSXTMetadataProxyListResultType);
            StringBuilder ListMetadataProxyServiceURL = new StringBuilder("/md-proxies");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListMetadataProxyServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListMetadataProxyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            else
			{
				try
				{
					returnValue = JsonConvert.DeserializeObject<NSXTMetadataProxyListResultType>(response.Content, defaultSerializationSettings);
				}
				catch (Exception ex)
				{
					var message = "Could not deserialize the response body string as " + typeof(NSXTMetadataProxyListResultType).FullName + ".";
					throw new NSXTException(message, (int)response.StatusCode, response.Content, response.Headers, ex.InnerException);
				}
			}
			return returnValue;
        }
    }
}
