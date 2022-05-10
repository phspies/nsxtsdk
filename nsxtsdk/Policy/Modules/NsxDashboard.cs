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
using nsxtsdk.PolicyModels;

namespace nsxtapi.PolicyModules
{
    public class NsxDashboard
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NsxDashboard(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTViewType> UpdateView(string ViewId, NSXTViewType View)
        {
            if (ViewId == null) { throw new System.ArgumentNullException("ViewId cannot be null"); }
            if (View == null) { throw new System.ArgumentNullException("View cannot be null"); }
            StringBuilder UpdateViewServiceURL = new StringBuilder("/ui-views/{view-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateViewServiceURL.Replace("{view-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ViewId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(View);
            request.Resource = UpdateViewServiceURL.ToString();
            RestResponse<NSXTViewType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTViewType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateViewServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeletView(string ViewId)
        {
            if (ViewId == null) { throw new System.ArgumentNullException("ViewId cannot be null"); }
            StringBuilder DeletViewServiceURL = new StringBuilder("/ui-views/{view-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeletViewServiceURL.Replace("{view-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ViewId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletViewServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeletViewServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTViewType> GetView(string ViewId)
        {
            if (ViewId == null) { throw new System.ArgumentNullException("ViewId cannot be null"); }
            StringBuilder GetViewServiceURL = new StringBuilder("/ui-views/{view-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetViewServiceURL.Replace("{view-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ViewId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetViewServiceURL.ToString();
            RestResponse<NSXTViewType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTViewType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetViewServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTWidgetConfigurationType> UpdateWidgetConfiguration(string ViewId, string WidgetconfigurationId, NSXTWidgetConfigurationType WidgetConfiguration)
        {
            if (ViewId == null) { throw new System.ArgumentNullException("ViewId cannot be null"); }
            if (WidgetconfigurationId == null) { throw new System.ArgumentNullException("WidgetconfigurationId cannot be null"); }
            if (WidgetConfiguration == null) { throw new System.ArgumentNullException("WidgetConfiguration cannot be null"); }
            StringBuilder UpdateWidgetConfigurationServiceURL = new StringBuilder("/ui-views/{view-id}/widgetconfigurations/{widgetconfiguration-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateWidgetConfigurationServiceURL.Replace("{view-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ViewId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateWidgetConfigurationServiceURL.Replace("{widgetconfiguration-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(WidgetconfigurationId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(WidgetConfiguration);
            request.Resource = UpdateWidgetConfigurationServiceURL.ToString();
            RestResponse<NSXTWidgetConfigurationType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTWidgetConfigurationType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateWidgetConfigurationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTWidgetConfigurationType> GetWidgetConfiguration(string ViewId, string WidgetconfigurationId)
        {
            if (ViewId == null) { throw new System.ArgumentNullException("ViewId cannot be null"); }
            if (WidgetconfigurationId == null) { throw new System.ArgumentNullException("WidgetconfigurationId cannot be null"); }
            StringBuilder GetWidgetConfigurationServiceURL = new StringBuilder("/ui-views/{view-id}/widgetconfigurations/{widgetconfiguration-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetWidgetConfigurationServiceURL.Replace("{view-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ViewId, System.Globalization.CultureInfo.InvariantCulture)));
            GetWidgetConfigurationServiceURL.Replace("{widgetconfiguration-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(WidgetconfigurationId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetWidgetConfigurationServiceURL.ToString();
            RestResponse<NSXTWidgetConfigurationType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTWidgetConfigurationType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetWidgetConfigurationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteWidgetConfiguration(string ViewId, string WidgetconfigurationId)
        {
            if (ViewId == null) { throw new System.ArgumentNullException("ViewId cannot be null"); }
            if (WidgetconfigurationId == null) { throw new System.ArgumentNullException("WidgetconfigurationId cannot be null"); }
            StringBuilder DeleteWidgetConfigurationServiceURL = new StringBuilder("/ui-views/{view-id}/widgetconfigurations/{widgetconfiguration-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteWidgetConfigurationServiceURL.Replace("{view-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ViewId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteWidgetConfigurationServiceURL.Replace("{widgetconfiguration-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(WidgetconfigurationId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteWidgetConfigurationServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteWidgetConfigurationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTViewType> CreateView(NSXTViewType View)
        {
            if (View == null) { throw new System.ArgumentNullException("View cannot be null"); }
            StringBuilder CreateViewServiceURL = new StringBuilder("/ui-views");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(View);
            request.Resource = CreateViewServiceURL.ToString();
            RestResponse<NSXTViewType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTViewType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateViewServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTViewListType> ListViews(string? Tag = null, string? ViewIds = null, string? WidgetId = null)
        {
            StringBuilder ListViewsServiceURL = new StringBuilder("/ui-views");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Tag != null) { request.AddQueryParameter("tag", Tag.ToString()); }
            if (ViewIds != null) { request.AddQueryParameter("view_ids", ViewIds.ToString()); }
            if (WidgetId != null) { request.AddQueryParameter("widget_id", WidgetId.ToString()); }
            request.Resource = ListViewsServiceURL.ToString();
            RestResponse<NSXTViewListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTViewListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListViewsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTWidgetConfigurationType> CreateWidgetConfiguration(string ViewId, NSXTWidgetConfigurationType WidgetConfiguration)
        {
            if (ViewId == null) { throw new System.ArgumentNullException("ViewId cannot be null"); }
            if (WidgetConfiguration == null) { throw new System.ArgumentNullException("WidgetConfiguration cannot be null"); }
            StringBuilder CreateWidgetConfigurationServiceURL = new StringBuilder("/ui-views/{view-id}/widgetconfigurations");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CreateWidgetConfigurationServiceURL.Replace("{view-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ViewId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(WidgetConfiguration);
            request.Resource = CreateWidgetConfigurationServiceURL.ToString();
            RestResponse<NSXTWidgetConfigurationType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTWidgetConfigurationType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateWidgetConfigurationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTWidgetConfigurationListType> ListWidgetConfigurations(string ViewId, string? Container = null, string? WidgetIds = null)
        {
            if (ViewId == null) { throw new System.ArgumentNullException("ViewId cannot be null"); }
            StringBuilder ListWidgetConfigurationsServiceURL = new StringBuilder("/ui-views/{view-id}/widgetconfigurations");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListWidgetConfigurationsServiceURL.Replace("{view-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ViewId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Container != null) { request.AddQueryParameter("container", Container.ToString()); }
            if (WidgetIds != null) { request.AddQueryParameter("widget_ids", WidgetIds.ToString()); }
            request.Resource = ListWidgetConfigurationsServiceURL.ToString();
            RestResponse<NSXTWidgetConfigurationListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTWidgetConfigurationListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListWidgetConfigurationsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
