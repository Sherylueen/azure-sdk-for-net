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
using Azure.ResourceManager.AppComplianceAutomation.Models;

namespace Azure.ResourceManager.AppComplianceAutomation
{
    /// <summary>
    /// A class representing a collection of <see cref="SnapshotResource" /> and their operations.
    /// Each <see cref="SnapshotResource" /> in the collection will belong to the same instance of <see cref="ReportResource" />.
    /// To get a <see cref="SnapshotResourceCollection" /> instance call the GetSnapshotResources method from an instance of <see cref="ReportResource" />.
    /// </summary>
    public partial class SnapshotResourceCollection : ArmCollection, IEnumerable<SnapshotResource>, IAsyncEnumerable<SnapshotResource>
    {
        private readonly ClientDiagnostics _snapshotResourceSnapshotsClientDiagnostics;
        private readonly SnapshotsRestOperations _snapshotResourceSnapshotsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SnapshotResourceCollection"/> class for mocking. </summary>
        protected SnapshotResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SnapshotResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SnapshotResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _snapshotResourceSnapshotsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppComplianceAutomation", SnapshotResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SnapshotResource.ResourceType, out string snapshotResourceSnapshotsApiVersion);
            _snapshotResourceSnapshotsRestClient = new SnapshotsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, snapshotResourceSnapshotsApiVersion);
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
        /// Get the AppComplianceAutomation snapshot and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/snapshots/{snapshotName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Snapshots_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="snapshotName"> Snapshot Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotName"/> is null. </exception>
        public virtual async Task<Response<SnapshotResource>> GetAsync(string snapshotName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(snapshotName, nameof(snapshotName));

            using var scope = _snapshotResourceSnapshotsClientDiagnostics.CreateScope("SnapshotResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _snapshotResourceSnapshotsRestClient.GetAsync(Id.Name, snapshotName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SnapshotResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the AppComplianceAutomation snapshot and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/snapshots/{snapshotName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Snapshots_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="snapshotName"> Snapshot Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotName"/> is null. </exception>
        public virtual Response<SnapshotResource> Get(string snapshotName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(snapshotName, nameof(snapshotName));

            using var scope = _snapshotResourceSnapshotsClientDiagnostics.CreateScope("SnapshotResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _snapshotResourceSnapshotsRestClient.Get(Id.Name, snapshotName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SnapshotResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the AppComplianceAutomation snapshot list.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/snapshots</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Snapshots_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SnapshotResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SnapshotResource> GetAllAsync(SnapshotResourceCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new SnapshotResourceCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _snapshotResourceSnapshotsRestClient.CreateListRequest(Id.Name, options.SkipToken, options.Top, options.Select, options.Filter, options.Orderby, options.ReportCreatorTenantId, options.OfferGuid);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _snapshotResourceSnapshotsRestClient.CreateListNextPageRequest(nextLink, Id.Name, options.SkipToken, options.Top, options.Select, options.Filter, options.Orderby, options.ReportCreatorTenantId, options.OfferGuid);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SnapshotResource(Client, SnapshotResourceData.DeserializeSnapshotResourceData(e)), _snapshotResourceSnapshotsClientDiagnostics, Pipeline, "SnapshotResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the AppComplianceAutomation snapshot list.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/snapshots</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Snapshots_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SnapshotResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SnapshotResource> GetAll(SnapshotResourceCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new SnapshotResourceCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _snapshotResourceSnapshotsRestClient.CreateListRequest(Id.Name, options.SkipToken, options.Top, options.Select, options.Filter, options.Orderby, options.ReportCreatorTenantId, options.OfferGuid);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _snapshotResourceSnapshotsRestClient.CreateListNextPageRequest(nextLink, Id.Name, options.SkipToken, options.Top, options.Select, options.Filter, options.Orderby, options.ReportCreatorTenantId, options.OfferGuid);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SnapshotResource(Client, SnapshotResourceData.DeserializeSnapshotResourceData(e)), _snapshotResourceSnapshotsClientDiagnostics, Pipeline, "SnapshotResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/snapshots/{snapshotName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Snapshots_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="snapshotName"> Snapshot Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string snapshotName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(snapshotName, nameof(snapshotName));

            using var scope = _snapshotResourceSnapshotsClientDiagnostics.CreateScope("SnapshotResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _snapshotResourceSnapshotsRestClient.GetAsync(Id.Name, snapshotName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/snapshots/{snapshotName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Snapshots_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="snapshotName"> Snapshot Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="snapshotName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="snapshotName"/> is null. </exception>
        public virtual Response<bool> Exists(string snapshotName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(snapshotName, nameof(snapshotName));

            using var scope = _snapshotResourceSnapshotsClientDiagnostics.CreateScope("SnapshotResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _snapshotResourceSnapshotsRestClient.Get(Id.Name, snapshotName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SnapshotResource> IEnumerable<SnapshotResource>.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IAsyncEnumerator<SnapshotResource> IAsyncEnumerable<SnapshotResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(options: null, cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
