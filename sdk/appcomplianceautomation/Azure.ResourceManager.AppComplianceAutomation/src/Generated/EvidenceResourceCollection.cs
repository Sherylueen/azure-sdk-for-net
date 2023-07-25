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
    /// A class representing a collection of <see cref="EvidenceResource" /> and their operations.
    /// Each <see cref="EvidenceResource" /> in the collection will belong to the same instance of <see cref="ReportResource" />.
    /// To get an <see cref="EvidenceResourceCollection" /> instance call the GetEvidenceResources method from an instance of <see cref="ReportResource" />.
    /// </summary>
    public partial class EvidenceResourceCollection : ArmCollection, IEnumerable<EvidenceResource>, IAsyncEnumerable<EvidenceResource>
    {
        private readonly ClientDiagnostics _evidenceResourceEvidencesClientDiagnostics;
        private readonly EvidencesRestOperations _evidenceResourceEvidencesRestClient;

        /// <summary> Initializes a new instance of the <see cref="EvidenceResourceCollection"/> class for mocking. </summary>
        protected EvidenceResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EvidenceResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal EvidenceResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _evidenceResourceEvidencesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppComplianceAutomation", EvidenceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(EvidenceResource.ResourceType, out string evidenceResourceEvidencesApiVersion);
            _evidenceResourceEvidencesRestClient = new EvidencesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, evidenceResourceEvidencesApiVersion);
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
        /// Create or Update an evidence a specified report
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/evidences/{evidenceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Evidences_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="evidenceName"> The evidence name. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="offerGuid"> The offerGuid which mapping to the reports. </param>
        /// <param name="reportCreatorTenantId"> The tenant id of the report creator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="evidenceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="evidenceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<EvidenceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string evidenceName, EvidenceResourceData data, string offerGuid = null, string reportCreatorTenantId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(evidenceName, nameof(evidenceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _evidenceResourceEvidencesClientDiagnostics.CreateScope("EvidenceResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _evidenceResourceEvidencesRestClient.CreateOrUpdateAsync(Id.Name, evidenceName, data, offerGuid, reportCreatorTenantId, cancellationToken).ConfigureAwait(false);
                var operation = new AppComplianceAutomationArmOperation<EvidenceResource>(Response.FromValue(new EvidenceResource(Client, response), response.GetRawResponse()));
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
        /// Create or Update an evidence a specified report
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/evidences/{evidenceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Evidences_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="evidenceName"> The evidence name. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="offerGuid"> The offerGuid which mapping to the reports. </param>
        /// <param name="reportCreatorTenantId"> The tenant id of the report creator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="evidenceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="evidenceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<EvidenceResource> CreateOrUpdate(WaitUntil waitUntil, string evidenceName, EvidenceResourceData data, string offerGuid = null, string reportCreatorTenantId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(evidenceName, nameof(evidenceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _evidenceResourceEvidencesClientDiagnostics.CreateScope("EvidenceResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _evidenceResourceEvidencesRestClient.CreateOrUpdate(Id.Name, evidenceName, data, offerGuid, reportCreatorTenantId, cancellationToken);
                var operation = new AppComplianceAutomationArmOperation<EvidenceResource>(Response.FromValue(new EvidenceResource(Client, response), response.GetRawResponse()));
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
        /// Get the evidence metadata
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/evidences/{evidenceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Evidences_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="evidenceName"> The evidence name. </param>
        /// <param name="offerGuid"> The offerGuid which mapping to the reports. </param>
        /// <param name="reportCreatorTenantId"> The tenant id of the report creator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="evidenceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="evidenceName"/> is null. </exception>
        public virtual async Task<Response<EvidenceResource>> GetAsync(string evidenceName, string offerGuid = null, string reportCreatorTenantId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(evidenceName, nameof(evidenceName));

            using var scope = _evidenceResourceEvidencesClientDiagnostics.CreateScope("EvidenceResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _evidenceResourceEvidencesRestClient.GetAsync(Id.Name, evidenceName, offerGuid, reportCreatorTenantId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EvidenceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the evidence metadata
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/evidences/{evidenceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Evidences_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="evidenceName"> The evidence name. </param>
        /// <param name="offerGuid"> The offerGuid which mapping to the reports. </param>
        /// <param name="reportCreatorTenantId"> The tenant id of the report creator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="evidenceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="evidenceName"/> is null. </exception>
        public virtual Response<EvidenceResource> Get(string evidenceName, string offerGuid = null, string reportCreatorTenantId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(evidenceName, nameof(evidenceName));

            using var scope = _evidenceResourceEvidencesClientDiagnostics.CreateScope("EvidenceResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _evidenceResourceEvidencesRestClient.Get(Id.Name, evidenceName, offerGuid, reportCreatorTenantId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EvidenceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a paginated list of evidences for a specified report.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/evidences</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Evidences_ListByReport</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EvidenceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EvidenceResource> GetAllAsync(EvidenceResourceCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new EvidenceResourceCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _evidenceResourceEvidencesRestClient.CreateListByReportRequest(Id.Name, options.SkipToken, options.Top, options.Select, options.Filter, options.Orderby, options.OfferGuid, options.ReportCreatorTenantId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _evidenceResourceEvidencesRestClient.CreateListByReportNextPageRequest(nextLink, Id.Name, options.SkipToken, options.Top, options.Select, options.Filter, options.Orderby, options.OfferGuid, options.ReportCreatorTenantId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new EvidenceResource(Client, EvidenceResourceData.DeserializeEvidenceResourceData(e)), _evidenceResourceEvidencesClientDiagnostics, Pipeline, "EvidenceResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns a paginated list of evidences for a specified report.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/evidences</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Evidences_ListByReport</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EvidenceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EvidenceResource> GetAll(EvidenceResourceCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new EvidenceResourceCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _evidenceResourceEvidencesRestClient.CreateListByReportRequest(Id.Name, options.SkipToken, options.Top, options.Select, options.Filter, options.Orderby, options.OfferGuid, options.ReportCreatorTenantId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _evidenceResourceEvidencesRestClient.CreateListByReportNextPageRequest(nextLink, Id.Name, options.SkipToken, options.Top, options.Select, options.Filter, options.Orderby, options.OfferGuid, options.ReportCreatorTenantId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new EvidenceResource(Client, EvidenceResourceData.DeserializeEvidenceResourceData(e)), _evidenceResourceEvidencesClientDiagnostics, Pipeline, "EvidenceResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/evidences/{evidenceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Evidences_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="evidenceName"> The evidence name. </param>
        /// <param name="offerGuid"> The offerGuid which mapping to the reports. </param>
        /// <param name="reportCreatorTenantId"> The tenant id of the report creator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="evidenceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="evidenceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string evidenceName, string offerGuid = null, string reportCreatorTenantId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(evidenceName, nameof(evidenceName));

            using var scope = _evidenceResourceEvidencesClientDiagnostics.CreateScope("EvidenceResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _evidenceResourceEvidencesRestClient.GetAsync(Id.Name, evidenceName, offerGuid, reportCreatorTenantId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/evidences/{evidenceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Evidences_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="evidenceName"> The evidence name. </param>
        /// <param name="offerGuid"> The offerGuid which mapping to the reports. </param>
        /// <param name="reportCreatorTenantId"> The tenant id of the report creator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="evidenceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="evidenceName"/> is null. </exception>
        public virtual Response<bool> Exists(string evidenceName, string offerGuid = null, string reportCreatorTenantId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(evidenceName, nameof(evidenceName));

            using var scope = _evidenceResourceEvidencesClientDiagnostics.CreateScope("EvidenceResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _evidenceResourceEvidencesRestClient.Get(Id.Name, evidenceName, offerGuid, reportCreatorTenantId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<EvidenceResource> IEnumerable<EvidenceResource>.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IAsyncEnumerator<EvidenceResource> IAsyncEnumerable<EvidenceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(options: null, cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
