// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppComplianceAutomation
{
    /// <summary>
    /// A class representing a collection of <see cref="WebhookResource" /> and their operations.
    /// Each <see cref="WebhookResource" /> in the collection will belong to the same instance of <see cref="ReportResource" />.
    /// To get a <see cref="WebhookResourceCollection" /> instance call the GetWebhookResources method from an instance of <see cref="ReportResource" />.
    /// </summary>
    public partial class WebhookResourceCollection : ArmCollection, IEnumerable<WebhookResource>, IAsyncEnumerable<WebhookResource>
    {
        private readonly ClientDiagnostics _webhookResourceWebhooksClientDiagnostics;
        private readonly WebhooksRestOperations _webhookResourceWebhooksRestClient;

        /// <summary> Initializes a new instance of the <see cref="WebhookResourceCollection"/> class for mocking. </summary>
        protected WebhookResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WebhookResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WebhookResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webhookResourceWebhooksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppComplianceAutomation", WebhookResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WebhookResource.ResourceType, out string webhookResourceWebhooksApiVersion);
            _webhookResourceWebhooksRestClient = new WebhooksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webhookResourceWebhooksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ReportResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ReportResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a new AppComplianceAutomation webhook or update an exiting AppComplianceAutomation webhook.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/webhooks/{webhookName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Webhooks_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="webhookName"> Webhook Name. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webhookName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webhookName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<WebhookResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string webhookName, WebhookResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webhookName, nameof(webhookName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _webhookResourceWebhooksClientDiagnostics.CreateScope("WebhookResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _webhookResourceWebhooksRestClient.CreateOrUpdateAsync(Id.Name, webhookName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppComplianceAutomationArmOperation<WebhookResource>(Response.FromValue(new WebhookResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a new AppComplianceAutomation webhook or update an exiting AppComplianceAutomation webhook.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/webhooks/{webhookName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Webhooks_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="webhookName"> Webhook Name. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webhookName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webhookName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<WebhookResource> CreateOrUpdate(WaitUntil waitUntil, string webhookName, WebhookResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webhookName, nameof(webhookName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _webhookResourceWebhooksClientDiagnostics.CreateScope("WebhookResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _webhookResourceWebhooksRestClient.CreateOrUpdate(Id.Name, webhookName, data, cancellationToken);
                var operation = new AppComplianceAutomationArmOperation<WebhookResource>(Response.FromValue(new WebhookResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the AppComplianceAutomation webhook and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/webhooks/{webhookName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Webhooks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webhookName"> Webhook Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webhookName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webhookName"/> is null. </exception>
        public virtual async Task<Response<WebhookResource>> GetAsync(string webhookName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webhookName, nameof(webhookName));

            using var scope = _webhookResourceWebhooksClientDiagnostics.CreateScope("WebhookResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _webhookResourceWebhooksRestClient.GetAsync(Id.Name, webhookName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebhookResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the AppComplianceAutomation webhook and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/webhooks/{webhookName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Webhooks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webhookName"> Webhook Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webhookName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webhookName"/> is null. </exception>
        public virtual Response<WebhookResource> Get(string webhookName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webhookName, nameof(webhookName));

            using var scope = _webhookResourceWebhooksClientDiagnostics.CreateScope("WebhookResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _webhookResourceWebhooksRestClient.Get(Id.Name, webhookName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebhookResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the AppComplianceAutomation webhook list.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/webhooks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Webhooks_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> Skip over when retrieving results. </param>
        /// <param name="top"> Number of elements to return when retrieving results. </param>
        /// <param name="select"> OData Select statement. Limits the properties on each entry to just those requested, e.g. ?$select=reportName,id. </param>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="orderby"> OData order by query option. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WebhookResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WebhookResource> GetAllAsync(string skipToken = null, int? top = null, string select = null, string filter = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _webhookResourceWebhooksRestClient.CreateListRequest(Id.Name, skipToken, top, select, filter, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _webhookResourceWebhooksRestClient.CreateListNextPageRequest(nextLink, Id.Name, skipToken, top, select, filter, orderby);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new WebhookResource(Client, WebhookResourceData.DeserializeWebhookResourceData(e)), _webhookResourceWebhooksClientDiagnostics, Pipeline, "WebhookResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the AppComplianceAutomation webhook list.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/webhooks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Webhooks_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> Skip over when retrieving results. </param>
        /// <param name="top"> Number of elements to return when retrieving results. </param>
        /// <param name="select"> OData Select statement. Limits the properties on each entry to just those requested, e.g. ?$select=reportName,id. </param>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="orderby"> OData order by query option. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WebhookResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WebhookResource> GetAll(string skipToken = null, int? top = null, string select = null, string filter = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _webhookResourceWebhooksRestClient.CreateListRequest(Id.Name, skipToken, top, select, filter, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _webhookResourceWebhooksRestClient.CreateListNextPageRequest(nextLink, Id.Name, skipToken, top, select, filter, orderby);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new WebhookResource(Client, WebhookResourceData.DeserializeWebhookResourceData(e)), _webhookResourceWebhooksClientDiagnostics, Pipeline, "WebhookResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/webhooks/{webhookName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Webhooks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webhookName"> Webhook Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webhookName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webhookName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string webhookName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webhookName, nameof(webhookName));

            using var scope = _webhookResourceWebhooksClientDiagnostics.CreateScope("WebhookResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _webhookResourceWebhooksRestClient.GetAsync(Id.Name, webhookName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/webhooks/{webhookName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Webhooks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webhookName"> Webhook Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webhookName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webhookName"/> is null. </exception>
        public virtual Response<bool> Exists(string webhookName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(webhookName, nameof(webhookName));

            using var scope = _webhookResourceWebhooksClientDiagnostics.CreateScope("WebhookResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _webhookResourceWebhooksRestClient.Get(Id.Name, webhookName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WebhookResource> IEnumerable<WebhookResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WebhookResource> IAsyncEnumerable<WebhookResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
